namespace CSharpSampleApplicationPort
{
    partial class dlgFinancialAdvisor
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
            this.lstProfiles = new System.Windows.Forms.TextBox();
            this.lstAliases = new System.Windows.Forms.TextBox();
            this.Frame1 = new System.Windows.Forms.GroupBox();
            this.lstGroups = new System.Windows.Forms.TextBox();
            this.cmdClose = new System.Windows.Forms.Button();
            this.Frame2 = new System.Windows.Forms.GroupBox();
            this.Frame3 = new System.Windows.Forms.GroupBox();
            this.Frame1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstProfiles
            // 
            this.lstProfiles.AcceptsReturn = true;
            this.lstProfiles.BackColor = System.Drawing.SystemColors.Window;
            this.lstProfiles.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lstProfiles.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstProfiles.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lstProfiles.Location = new System.Drawing.Point(20, 211);
            this.lstProfiles.MaxLength = 0;
            this.lstProfiles.Multiline = true;
            this.lstProfiles.Name = "lstProfiles";
            this.lstProfiles.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lstProfiles.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.lstProfiles.Size = new System.Drawing.Size(633, 121);
            this.lstProfiles.TabIndex = 10;
            this.lstProfiles.Text = "Start\r\n";
            this.lstProfiles.WordWrap = false;
            // 
            // lstAliases
            // 
            this.lstAliases.AcceptsReturn = true;
            this.lstAliases.BackColor = System.Drawing.SystemColors.Window;
            this.lstAliases.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lstAliases.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstAliases.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lstAliases.Location = new System.Drawing.Point(20, 387);
            this.lstAliases.MaxLength = 0;
            this.lstAliases.Multiline = true;
            this.lstAliases.Name = "lstAliases";
            this.lstAliases.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lstAliases.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.lstAliases.Size = new System.Drawing.Size(633, 121);
            this.lstAliases.TabIndex = 9;
            this.lstAliases.Text = "Start\r\n";
            this.lstAliases.WordWrap = false;
            // 
            // Frame1
            // 
            this.Frame1.BackColor = System.Drawing.SystemColors.Control;
            this.Frame1.Controls.Add(this.lstGroups);
            this.Frame1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Frame1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Frame1.Location = new System.Drawing.Point(12, 11);
            this.Frame1.Name = "Frame1";
            this.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Frame1.Size = new System.Drawing.Size(649, 161);
            this.Frame1.TabIndex = 8;
            this.Frame1.TabStop = false;
            this.Frame1.Text = "Groups:";
            // 
            // lstGroups
            // 
            this.lstGroups.AcceptsReturn = true;
            this.lstGroups.BackColor = System.Drawing.SystemColors.Window;
            this.lstGroups.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lstGroups.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstGroups.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lstGroups.Location = new System.Drawing.Point(8, 24);
            this.lstGroups.MaxLength = 0;
            this.lstGroups.Multiline = true;
            this.lstGroups.Name = "lstGroups";
            this.lstGroups.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lstGroups.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.lstGroups.Size = new System.Drawing.Size(633, 121);
            this.lstGroups.TabIndex = 2;
            this.lstGroups.Text = "Start\r\n";
            this.lstGroups.WordWrap = false;
            // 
            // cmdClose
            // 
            this.cmdClose.BackColor = System.Drawing.SystemColors.Control;
            this.cmdClose.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdClose.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdClose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdClose.Location = new System.Drawing.Point(297, 555);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdClose.Size = new System.Drawing.Size(81, 25);
            this.cmdClose.TabIndex = 7;
            this.cmdClose.Text = "Accept Edits";
            this.cmdClose.UseVisualStyleBackColor = false;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // Frame2
            // 
            this.Frame2.BackColor = System.Drawing.SystemColors.Control;
            this.Frame2.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Frame2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Frame2.Location = new System.Drawing.Point(12, 187);
            this.Frame2.Name = "Frame2";
            this.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Frame2.Size = new System.Drawing.Size(649, 161);
            this.Frame2.TabIndex = 11;
            this.Frame2.TabStop = false;
            this.Frame2.Text = "Profiles:";
            // 
            // Frame3
            // 
            this.Frame3.BackColor = System.Drawing.SystemColors.Control;
            this.Frame3.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Frame3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Frame3.Location = new System.Drawing.Point(12, 363);
            this.Frame3.Name = "Frame3";
            this.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Frame3.Size = new System.Drawing.Size(649, 161);
            this.Frame3.TabIndex = 12;
            this.Frame3.TabStop = false;
            this.Frame3.Text = "Aliases";
            // 
            // dlgFinancialAdvisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 593);
            this.Controls.Add(this.lstProfiles);
            this.Controls.Add(this.lstAliases);
            this.Controls.Add(this.Frame1);
            this.Controls.Add(this.cmdClose);
            this.Controls.Add(this.Frame2);
            this.Controls.Add(this.Frame3);
            this.Name = "dlgFinancialAdvisor";
            this.Text = "dlgFinancialAdvisor";
            this.Frame1.ResumeLayout(false);
            this.Frame1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox lstProfiles;
        public System.Windows.Forms.TextBox lstAliases;
        public System.Windows.Forms.GroupBox Frame1;
        public System.Windows.Forms.TextBox lstGroups;
        public System.Windows.Forms.Button cmdClose;
        public System.Windows.Forms.GroupBox Frame2;
        public System.Windows.Forms.GroupBox Frame3;
    }
}