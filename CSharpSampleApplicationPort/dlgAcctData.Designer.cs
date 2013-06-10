namespace CSharpSampleApplicationPort
{
    partial class dlgAcctData
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
            this.txtLastUpdateTime = new System.Windows.Forms.TextBox();
            this.Frame2 = new System.Windows.Forms.GroupBox();
            this.lstPortfolioData = new System.Windows.Forms.ListBox();
            this.Frame1 = new System.Windows.Forms.GroupBox();
            this.lstKeyValueData = new System.Windows.Forms.ListBox();
            this.cmdClose = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.Frame2.SuspendLayout();
            this.Frame1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtLastUpdateTime
            // 
            this.txtLastUpdateTime.AcceptsReturn = true;
            this.txtLastUpdateTime.BackColor = System.Drawing.SystemColors.Window;
            this.txtLastUpdateTime.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLastUpdateTime.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastUpdateTime.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtLastUpdateTime.Location = new System.Drawing.Point(104, 352);
            this.txtLastUpdateTime.MaxLength = 0;
            this.txtLastUpdateTime.Name = "txtLastUpdateTime";
            this.txtLastUpdateTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtLastUpdateTime.Size = new System.Drawing.Size(89, 20);
            this.txtLastUpdateTime.TabIndex = 6;
            this.txtLastUpdateTime.Text = "00:00";
            // 
            // Frame2
            // 
            this.Frame2.BackColor = System.Drawing.SystemColors.Control;
            this.Frame2.Controls.Add(this.lstPortfolioData);
            this.Frame2.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Frame2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Frame2.Location = new System.Drawing.Point(8, 192);
            this.Frame2.Name = "Frame2";
            this.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Frame2.Size = new System.Drawing.Size(649, 137);
            this.Frame2.TabIndex = 3;
            this.Frame2.TabStop = false;
            this.Frame2.Text = "Portfolio Data";
            // 
            // lstPortfolioData
            // 
            this.lstPortfolioData.BackColor = System.Drawing.SystemColors.Window;
            this.lstPortfolioData.Cursor = System.Windows.Forms.Cursors.Default;
            this.lstPortfolioData.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPortfolioData.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lstPortfolioData.HorizontalScrollbar = true;
            this.lstPortfolioData.ItemHeight = 14;
            this.lstPortfolioData.Location = new System.Drawing.Point(8, 24);
            this.lstPortfolioData.Name = "lstPortfolioData";
            this.lstPortfolioData.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lstPortfolioData.Size = new System.Drawing.Size(633, 88);
            this.lstPortfolioData.TabIndex = 4;
            // 
            // Frame1
            // 
            this.Frame1.BackColor = System.Drawing.SystemColors.Control;
            this.Frame1.Controls.Add(this.lstKeyValueData);
            this.Frame1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Frame1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Frame1.Location = new System.Drawing.Point(8, 16);
            this.Frame1.Name = "Frame1";
            this.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Frame1.Size = new System.Drawing.Size(649, 173);
            this.Frame1.TabIndex = 1;
            this.Frame1.TabStop = false;
            this.Frame1.Text = "Key, Value, and Currency";
            // 
            // lstKeyValueData
            // 
            this.lstKeyValueData.BackColor = System.Drawing.SystemColors.Window;
            this.lstKeyValueData.Cursor = System.Windows.Forms.Cursors.Default;
            this.lstKeyValueData.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstKeyValueData.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lstKeyValueData.ItemHeight = 14;
            this.lstKeyValueData.Location = new System.Drawing.Point(8, 24);
            this.lstKeyValueData.Name = "lstKeyValueData";
            this.lstKeyValueData.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lstKeyValueData.Size = new System.Drawing.Size(633, 116);
            this.lstKeyValueData.TabIndex = 2;
            // 
            // cmdClose
            // 
            this.cmdClose.BackColor = System.Drawing.SystemColors.Control;
            this.cmdClose.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdClose.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdClose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdClose.Location = new System.Drawing.Point(293, 352);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdClose.Size = new System.Drawing.Size(81, 25);
            this.cmdClose.TabIndex = 0;
            this.cmdClose.Text = "Close";
            this.cmdClose.UseVisualStyleBackColor = false;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.SystemColors.Control;
            this.Label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label1.Location = new System.Drawing.Point(16, 352);
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label1.Size = new System.Drawing.Size(89, 18);
            this.Label1.TabIndex = 5;
            this.Label1.Text = "Last update time :";
            // 
            // dlgAcctData
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(667, 392);
            this.Controls.Add(this.txtLastUpdateTime);
            this.Controls.Add(this.Frame2);
            this.Controls.Add(this.Frame1);
            this.Controls.Add(this.cmdClose);
            this.Controls.Add(this.Label1);
            this.Font = new System.Drawing.Font("Arial", 8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Location = new System.Drawing.Point(315, 341);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "dlgAcctData";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Account Update";
            this.Frame2.ResumeLayout(false);
            this.Frame1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtLastUpdateTime;
        public System.Windows.Forms.GroupBox Frame2;
        public System.Windows.Forms.ListBox lstPortfolioData;
        public System.Windows.Forms.GroupBox Frame1;
        public System.Windows.Forms.ListBox lstKeyValueData;
        public System.Windows.Forms.Button cmdClose;
        public System.Windows.Forms.Label Label1;

    }
}