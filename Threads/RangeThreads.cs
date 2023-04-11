using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

// Tasks 4 -7 - Create threads generator with set range 

namespace Threads
{
    public partial class RangeThreads : Form
    {
        Random random = new Random();
        public int MinRange { get; set; }
        public int MaxRange { get; set; }
        public int Average { get; set; }

        List<int> numbers = new List<int>();

        public RangeThreads()
        {
            InitializeComponent();
        }

        // set range
        private void SetNumbers()
        {
            for (int i = 0; i < 10000; i++)
            {
                lock (this)
                numbers.Add(random.Next());
            }
        }

        // get max value
        private void GetMaxValue()
        {
            foreach (var number in numbers)
            {
                lock(this)
                MaxRange = Math.Max(MaxRange, number);
            }
        }

        // get min value
        private void GetMinValue()
        {
            foreach (var number in numbers)
            {
                lock (this)
                MinRange = Math.Min(MinRange, number);
            }
        }

        // get average value
        private void GetAverageValue()
        {
            int summ = 0;
            foreach (var number in numbers)
            {
                lock (this)
                summ += number;
            }

            Average = summ / numbers.Count;
        }

        // generate thread results
        private void GenerateBtnClick(object sender, EventArgs e)
        {
            Thread thread1 = new Thread(SetNumbers);
            thread1.Start();

            Thread thread2 = new Thread(GetMaxValue);
            thread2.Start();

            Thread thread3 = new Thread(GetMinValue);
            thread3.Start();

            Thread thread4 = new Thread(GetAverageValue);
            thread4.Start();

            // show results
            maxLabel.Text = MaxRange.ToString();
            minLabel.Text = MinRange.ToString();
            averageLabel.Text = Average.ToString();
        }
    }
}
