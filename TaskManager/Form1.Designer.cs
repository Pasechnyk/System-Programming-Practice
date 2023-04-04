
namespace TaskManager
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.each1SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.each2SecToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.each5SecToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.processToolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(740, 371);
            this.dataGridView1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripDropDownButton1,
            this.processToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripLabel1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(116, 24);
            this.toolStripLabel1.Text = "Show Processes";
            this.toolStripLabel1.Click += new System.EventHandler(this.ShowProcessesBtnClick);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.each1SToolStripMenuItem,
            this.each2SecToolStripMenuItem,
            this.each5SecToolStripMenuItem,
            this.autoToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(139, 24);
            this.toolStripDropDownButton1.Text = "Refresh Processes";
            // 
            // each1SToolStripMenuItem
            // 
            this.each1SToolStripMenuItem.Name = "each1SToolStripMenuItem";
            this.each1SToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.each1SToolStripMenuItem.Text = "Each 1 sec.";
            this.each1SToolStripMenuItem.Click += new System.EventHandler(this.RefreshEachSecondToolStripMenuItemClick);
            // 
            // each2SecToolStripMenuItem
            // 
            this.each2SecToolStripMenuItem.Name = "each2SecToolStripMenuItem";
            this.each2SecToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.each2SecToolStripMenuItem.Text = "Each 2 sec.";
            this.each2SecToolStripMenuItem.Click += new System.EventHandler(this.RefreshEach2SecondsToolStripMenuItemClick);
            // 
            // each5SecToolStripMenuItem
            // 
            this.each5SecToolStripMenuItem.Name = "each5SecToolStripMenuItem";
            this.each5SecToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.each5SecToolStripMenuItem.Text = "Each 5 sec.";
            this.each5SecToolStripMenuItem.Click += new System.EventHandler(this.RefreshEach5SecondsToolStripMenuItemClick);
            // 
            // autoToolStripMenuItem
            // 
            this.autoToolStripMenuItem.Name = "autoToolStripMenuItem";
            this.autoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.autoToolStripMenuItem.Text = "Manual";
            this.autoToolStripMenuItem.Click += new System.EventHandler(this.ManualRefreshToolStripMenuItemClick);
            // 
            // processToolStripButton
            // 
            this.processToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.processToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("processToolStripButton.Image")));
            this.processToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.processToolStripButton.Name = "processToolStripButton";
            this.processToolStripButton.Size = new System.Drawing.Size(102, 24);
            this.processToolStripButton.Text = "Open Process";
            this.processToolStripButton.Click += new System.EventHandler(this.OpenProcessToolStripButtonClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripLabel1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem each1SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem each2SecToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem each5SecToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton processToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem autoToolStripMenuItem;
    }
}

