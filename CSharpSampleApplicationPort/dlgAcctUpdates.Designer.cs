namespace CSharpSampleApplicationPort
{
    partial class dlgAcctUpdates
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
            this.Frame1 = new System.Windows.Forms.GroupBox();
            this.cmdUnSubscribe = new System.Windows.Forms.Button();
            this.cmdSubscribe = new System.Windows.Forms.Button();
            this.txtAcctCode = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.Frame1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Frame1
            // 
            this.Frame1.BackColor = System.Drawing.SystemColors.Control;
            this.Frame1.Controls.Add(this.cmdUnSubscribe);
            this.Frame1.Controls.Add(this.cmdSubscribe);
            this.Frame1.Controls.Add(this.txtAcctCode);
            this.Frame1.Controls.Add(this.Label2);
            this.Frame1.Controls.Add(this.Label1);
            this.Frame1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Frame1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Frame1.Location = new System.Drawing.Point(8, 9);
            this.Frame1.Name = "Frame1";
            this.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Frame1.Size = new System.Drawing.Size(241, 139);
            this.Frame1.TabIndex = 5;
            this.Frame1.TabStop = false;
            // 
            // cmdUnSubscribe
            // 
            this.cmdUnSubscribe.BackColor = System.Drawing.SystemColors.Control;
            this.cmdUnSubscribe.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdUnSubscribe.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdUnSubscribe.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdUnSubscribe.Location = new System.Drawing.Point(136, 103);
            this.cmdUnSubscribe.Name = "cmdUnSubscribe";
            this.cmdUnSubscribe.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdUnSubscribe.Size = new System.Drawing.Size(89, 27);
            this.cmdUnSubscribe.TabIndex = 4;
            this.cmdUnSubscribe.Text = "UnSubscribe";
            this.cmdUnSubscribe.UseVisualStyleBackColor = false;
            this.cmdUnSubscribe.Click += new System.EventHandler(this.cmdUnSubscribe_Click);
            // 
            // cmdSubscribe
            // 
            this.cmdSubscribe.BackColor = System.Drawing.SystemColors.Control;
            this.cmdSubscribe.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdSubscribe.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSubscribe.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdSubscribe.Location = new System.Drawing.Point(16, 103);
            this.cmdSubscribe.Name = "cmdSubscribe";
            this.cmdSubscribe.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdSubscribe.Size = new System.Drawing.Size(89, 27);
            this.cmdSubscribe.TabIndex = 3;
            this.cmdSubscribe.Text = "Subscribe";
            this.cmdSubscribe.UseVisualStyleBackColor = false;
            this.cmdSubscribe.Click += new System.EventHandler(this.cmdSubscribe_Click);
            // 
            // txtAcctCode
            // 
            this.txtAcctCode.AcceptsReturn = true;
            this.txtAcctCode.BackColor = System.Drawing.SystemColors.Window;
            this.txtAcctCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAcctCode.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAcctCode.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtAcctCode.Location = new System.Drawing.Point(112, 69);
            this.txtAcctCode.MaxLength = 0;
            this.txtAcctCode.Name = "txtAcctCode";
            this.txtAcctCode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtAcctCode.Size = new System.Drawing.Size(121, 20);
            this.txtAcctCode.TabIndex = 2;
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.SystemColors.Control;
            this.Label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label2.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label2.Location = new System.Drawing.Point(16, 69);
            this.Label2.Name = "Label2";
            this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label2.Size = new System.Drawing.Size(81, 18);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "Account Code :";
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.SystemColors.Control;
            this.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label1.Location = new System.Drawing.Point(8, 17);
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label1.Size = new System.Drawing.Size(225, 36);
            this.Label1.TabIndex = 0;
            this.Label1.Text = " Enter the account code for the FA managed account you wish to receive updates fo" +
    "r : ";
            // 
            // cmdCancel
            // 
            this.cmdCancel.BackColor = System.Drawing.SystemColors.Control;
            this.cmdCancel.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdCancel.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdCancel.Location = new System.Drawing.Point(88, 164);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdCancel.Size = new System.Drawing.Size(81, 27);
            this.cmdCancel.TabIndex = 6;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = false;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // dlgAcctUpdates
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(257, 199);
            this.Controls.Add(this.Frame1);
            this.Controls.Add(this.cmdCancel);
            this.Font = new System.Drawing.Font("Arial", 8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Location = new System.Drawing.Point(184, 250);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "dlgAcctUpdates";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Account Updates (FA customers only)";
            this.Frame1.ResumeLayout(false);
            this.Frame1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox Frame1;
        public System.Windows.Forms.Button cmdUnSubscribe;
        public System.Windows.Forms.Button cmdSubscribe;
        public System.Windows.Forms.TextBox txtAcctCode;
        public System.Windows.Forms.Label Label2;
        public System.Windows.Forms.Label Label1;
        public System.Windows.Forms.Button cmdCancel;
    }
}