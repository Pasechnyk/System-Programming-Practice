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

// Tasks 1-3 Create thread generator with min/max range and thread amount option

namespace Threads
{
    public partial class SetThreads : Form
    {
        public SetThreads()
        {
            InitializeComponent();
            SetThread();
        }

        // set thread values
        private void SetThread()
        {
            int number = 0;

            int min = (int)minNumericUpDown.Value;
            int max = (int)maxNumericUpDown.Value;

            for (int i = min; i < max + 1; i++)
            {
                lock (this)
                {
                    numbersListBox.Items.Add(number);
                    number++;
                }
            }
        }

        // generate thread 
        private void GenerateBtnClick(object sender, EventArgs e)
        {
            numbersListBox.Items.Clear();

            int amount = (int)amountNumericUpDown.Value;
            Thread[] threads = new Thread[amount];

            for (int i = 0; i < threads.Length; i++)
            {
                threads[i] = new Thread(Update);

                threads[i].Start();
            }
        }
    }
}
