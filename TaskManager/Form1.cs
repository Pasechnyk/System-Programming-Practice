using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;

// Task - Create Task manager of processes

namespace TaskManager
{
    public partial class Form1 : Form
    {
        private int refreshInterval = 30000;
        public Form1()
        {
            InitializeComponent();

            // auto startup
            Thread thread = new Thread(ListProcesses);
            thread.Start();
        }

        // Show processes with button
        private void ShowProcessesBtnClick(object sender, EventArgs e)
        {
            var list = Process.GetProcesses().Select(x => new ProcessViewModel(x)).ToList();

            dataGridView1.DataSource = list;
        }

        // Update processes with interval
        private void ListProcesses()
        {
            var list = Process.GetProcesses().Select(x => new ProcessViewModel(x)).ToList();

            dataGridView1.DataSource = list;

            Thread.Sleep(refreshInterval);
        }

        // Set refresh to 1, 2, 5 seconds and manual
        private void RefreshEachSecondToolStripMenuItemClick(object sender, EventArgs e)
        {
            Thread thread = new Thread(ListProcesses);

            refreshInterval = 1000;
            thread.Start();
        }

        private void RefreshEach2SecondsToolStripMenuItemClick(object sender, EventArgs e)
        {
            Thread thread = new Thread(ListProcesses);

            refreshInterval = 2000;
            thread.Start();
        }

        private void RefreshEach5SecondsToolStripMenuItemClick(object sender, EventArgs e)
        {
            Thread thread = new Thread(ListProcesses);

            refreshInterval = 5000;
            thread.Start();
        }

        private void ManualRefreshToolStripMenuItemClick(object sender, EventArgs e)
        {
            Thread thread = new Thread(ListProcesses);

            thread.Start();
        }

        private void OpenProcessToolStripButtonClick(object sender, EventArgs e)
        {
            ProcessForm form = new ProcessForm();
            form.ShowDialog();

            this.Hide();
        }
    }

    class ProcessViewModel
    {
        public int PID { get; set; }
        public string Name { get; set; }
        public string Priority { get; set; }
        public long Memory { get; set; }
        public string ProcessStartTime { get; set; }

        public ProcessViewModel(Process x)
        {
            try
            {
                PID = x.Id;
                Name = x.ProcessName;
                Priority = x.PriorityClass.ToString();
                Memory = x.PrivateMemorySize64 / 1024;
                ProcessStartTime = x.StartTime.ToString();
            }
            catch { }
        }
    }
}
