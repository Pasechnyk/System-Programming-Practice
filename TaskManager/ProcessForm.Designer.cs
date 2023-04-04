
namespace TaskManager
{
    partial class ProcessForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.processPath = new System.Windows.Forms.Label();
            this.processTextBox = new System.Windows.Forms.TextBox();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // processPath
            // 
            this.processPath.AutoSize = true;
            this.processPath.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.processPath.Location = new System.Drawing.Point(57, 23);
            this.processPath.Name = "processPath";
            this.processPath.Size = new System.Drawing.Size(233, 28);
            this.processPath.TabIndex = 0;
            this.processPath.Text = "Enter path of the process:";
            // 
            // processTextBox
            // 
            this.processTextBox.Location = new System.Drawing.Point(39, 71);
            this.processTextBox.Name = "processTextBox";
            this.processTextBox.Size = new System.Drawing.Size(283, 27);
            this.processTextBox.TabIndex = 1;
            // 
            // confirmBtn
            // 
            this.confirmBtn.Location = new System.Drawing.Point(57, 141);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(94, 29);
            this.confirmBtn.TabIndex = 2;
            this.confirmBtn.Text = "Confirm";
            this.confirmBtn.UseVisualStyleBackColor = true;
            this.confirmBtn.Click += new System.EventHandler(this.ConfirmBtnClick);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(204, 141);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(94, 29);
            this.cancelBtn.TabIndex = 3;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.CancelBtnClick);
            // 
            // ProcessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 197);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.confirmBtn);
            this.Controls.Add(this.processTextBox);
            this.Controls.Add(this.processPath);
            this.Name = "ProcessForm";
            this.Text = "ProcessForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label processPath;
        private System.Windows.Forms.TextBox processTextBox;
        private System.Windows.Forms.Button confirmBtn;
        private System.Windows.Forms.Button cancelBtn;
    }
}