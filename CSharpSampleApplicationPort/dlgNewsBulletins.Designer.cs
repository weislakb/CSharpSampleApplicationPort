namespace CSharpSampleApplicationPort
{
    partial class dlgNewsBulletins
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
            this.cmdSubscribe = new System.Windows.Forms.Button();
            this.Frame1 = new System.Windows.Forms.GroupBox();
            this.optAllMsgs = new System.Windows.Forms.RadioButton();
            this.optNewMsgs = new System.Windows.Forms.RadioButton();
            this.Label1 = new System.Windows.Forms.Label();
            this.cmdClose = new System.Windows.Forms.Button();
            this.cmdUnsubscribe = new System.Windows.Forms.Button();
            this.Frame1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdSubscribe
            // 
            this.cmdSubscribe.BackColor = System.Drawing.SystemColors.Control;
            this.cmdSubscribe.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdSubscribe.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSubscribe.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdSubscribe.Location = new System.Drawing.Point(76, 116);
            this.cmdSubscribe.Name = "cmdSubscribe";
            this.cmdSubscribe.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdSubscribe.Size = new System.Drawing.Size(81, 25);
            this.cmdSubscribe.TabIndex = 8;
            this.cmdSubscribe.Text = "Subscribe";
            this.cmdSubscribe.UseVisualStyleBackColor = false;
            // 
            // Frame1
            // 
            this.Frame1.BackColor = System.Drawing.SystemColors.Control;
            this.Frame1.Controls.Add(this.optAllMsgs);
            this.Frame1.Controls.Add(this.optNewMsgs);
            this.Frame1.Controls.Add(this.Label1);
            this.Frame1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Frame1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Frame1.Location = new System.Drawing.Point(12, 12);
            this.Frame1.Name = "Frame1";
            this.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Frame1.Size = new System.Drawing.Size(353, 89);
            this.Frame1.TabIndex = 7;
            this.Frame1.TabStop = false;
            // 
            // optAllMsgs
            // 
            this.optAllMsgs.BackColor = System.Drawing.SystemColors.Control;
            this.optAllMsgs.Cursor = System.Windows.Forms.Cursors.Default;
            this.optAllMsgs.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optAllMsgs.ForeColor = System.Drawing.SystemColors.ControlText;
            this.optAllMsgs.Location = new System.Drawing.Point(32, 56);
            this.optAllMsgs.Name = "optAllMsgs";
            this.optAllMsgs.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.optAllMsgs.Size = new System.Drawing.Size(305, 17);
            this.optAllMsgs.TabIndex = 6;
            this.optAllMsgs.TabStop = true;
            this.optAllMsgs.Text = "receive all current day\'s messages and any new messages.";
            this.optAllMsgs.UseVisualStyleBackColor = false;
            // 
            // optNewMsgs
            // 
            this.optNewMsgs.BackColor = System.Drawing.SystemColors.Control;
            this.optNewMsgs.Cursor = System.Windows.Forms.Cursors.Default;
            this.optNewMsgs.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optNewMsgs.ForeColor = System.Drawing.SystemColors.ControlText;
            this.optNewMsgs.Location = new System.Drawing.Point(32, 32);
            this.optNewMsgs.Name = "optNewMsgs";
            this.optNewMsgs.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.optNewMsgs.Size = new System.Drawing.Size(241, 17);
            this.optNewMsgs.TabIndex = 5;
            this.optNewMsgs.TabStop = true;
            this.optNewMsgs.Text = "receive new messages only.";
            this.optNewMsgs.UseVisualStyleBackColor = false;
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.SystemColors.Control;
            this.Label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label1.Location = new System.Drawing.Point(8, 16);
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label1.Size = new System.Drawing.Size(297, 25);
            this.Label1.TabIndex = 3;
            this.Label1.Text = "When subscribing to IB news bulletins you have 2 options:";
            // 
            // cmdClose
            // 
            this.cmdClose.BackColor = System.Drawing.SystemColors.Control;
            this.cmdClose.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdClose.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdClose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdClose.Location = new System.Drawing.Point(284, 116);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdClose.Size = new System.Drawing.Size(81, 25);
            this.cmdClose.TabIndex = 6;
            this.cmdClose.Text = "Close";
            this.cmdClose.UseVisualStyleBackColor = false;
            // 
            // cmdUnsubscribe
            // 
            this.cmdUnsubscribe.BackColor = System.Drawing.SystemColors.Control;
            this.cmdUnsubscribe.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdUnsubscribe.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdUnsubscribe.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdUnsubscribe.Location = new System.Drawing.Point(164, 116);
            this.cmdUnsubscribe.Name = "cmdUnsubscribe";
            this.cmdUnsubscribe.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdUnsubscribe.Size = new System.Drawing.Size(81, 25);
            this.cmdUnsubscribe.TabIndex = 5;
            this.cmdUnsubscribe.Text = "UnSubscribe";
            this.cmdUnsubscribe.UseVisualStyleBackColor = false;
            // 
            // dlgNewsBulletins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 152);
            this.Controls.Add(this.cmdSubscribe);
            this.Controls.Add(this.Frame1);
            this.Controls.Add(this.cmdClose);
            this.Controls.Add(this.cmdUnsubscribe);
            this.Name = "dlgNewsBulletins";
            this.Text = "dlgNewsBulletins";
            this.Frame1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button cmdSubscribe;
        public System.Windows.Forms.GroupBox Frame1;
        public System.Windows.Forms.RadioButton optAllMsgs;
        public System.Windows.Forms.RadioButton optNewMsgs;
        public System.Windows.Forms.Label Label1;
        public System.Windows.Forms.Button cmdClose;
        public System.Windows.Forms.Button cmdUnsubscribe;
    }
}