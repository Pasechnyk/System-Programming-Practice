using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// - Process opener child form

namespace TaskManager
{
    public partial class ProcessForm : Form
    {
        public string ProcessPath { get; set; }

        public ProcessForm()
        {
            InitializeComponent();
        }

        private void ConfirmBtnClick(object sender, EventArgs e)
        {
            ProcessPath = processTextBox.Text;

            if (string.IsNullOrWhiteSpace(ProcessPath))
            {
                MessageBox.Show("Incorrect path.");
                return;
            }

            Process.Start(ProcessPath);

            this.Close();
        }

        private void CancelBtnClick(object sender, EventArgs e)
        {
            this.Close();

            Form1 form = new Form1();
        }
    }
}
