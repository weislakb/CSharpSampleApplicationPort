namespace CSharpSampleApplicationPort
{
    partial class dlgLogConfig
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
            this.cmbServerLogLevel = new System.Windows.Forms.ComboBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.CancelButton_Renamed = new System.Windows.Forms.Button();
            this.OKButton = new System.Windows.Forms.Button();
            this.Frame1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Frame1
            // 
            this.Frame1.BackColor = System.Drawing.SystemColors.Control;
            this.Frame1.Controls.Add(this.cmbServerLogLevel);
            this.Frame1.Controls.Add(this.Label1);
            this.Frame1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Frame1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Frame1.Location = new System.Drawing.Point(12, 12);
            this.Frame1.Name = "Frame1";
            this.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Frame1.Size = new System.Drawing.Size(209, 57);
            this.Frame1.TabIndex = 5;
            this.Frame1.TabStop = false;
            this.Frame1.Text = "TWS Server";
            // 
            // cmbServerLogLevel
            // 
            this.cmbServerLogLevel.BackColor = System.Drawing.SystemColors.Window;
            this.cmbServerLogLevel.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmbServerLogLevel.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbServerLogLevel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbServerLogLevel.Location = new System.Drawing.Point(80, 24);
            this.cmbServerLogLevel.Name = "cmbServerLogLevel";
            this.cmbServerLogLevel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbServerLogLevel.Size = new System.Drawing.Size(121, 22);
            this.cmbServerLogLevel.TabIndex = 3;
            this.cmbServerLogLevel.Text = "Combo1";
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.SystemColors.Control;
            this.Label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label1.Location = new System.Drawing.Point(16, 32);
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label1.Size = new System.Drawing.Size(65, 17);
            this.Label1.TabIndex = 4;
            this.Label1.Text = "Log Level :";
            // 
            // CancelButton_Renamed
            // 
            this.CancelButton_Renamed.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton_Renamed.Cursor = System.Windows.Forms.Cursors.Default;
            this.CancelButton_Renamed.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton_Renamed.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CancelButton_Renamed.Location = new System.Drawing.Point(120, 84);
            this.CancelButton_Renamed.Name = "CancelButton_Renamed";
            this.CancelButton_Renamed.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CancelButton_Renamed.Size = new System.Drawing.Size(65, 25);
            this.CancelButton_Renamed.TabIndex = 4;
            this.CancelButton_Renamed.Text = "Cancel";
            this.CancelButton_Renamed.UseVisualStyleBackColor = false;
            // 
            // OKButton
            // 
            this.OKButton.BackColor = System.Drawing.SystemColors.Control;
            this.OKButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.OKButton.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OKButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.OKButton.Location = new System.Drawing.Point(48, 84);
            this.OKButton.Name = "OKButton";
            this.OKButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.OKButton.Size = new System.Drawing.Size(65, 25);
            this.OKButton.TabIndex = 3;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = false;
            // 
            // dlgLogConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 123);
            this.Controls.Add(this.Frame1);
            this.Controls.Add(this.CancelButton_Renamed);
            this.Controls.Add(this.OKButton);
            this.Name = "dlgLogConfig";
            this.Text = "dlgLogConfig";
            this.Frame1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox Frame1;
        public System.Windows.Forms.ComboBox cmbServerLogLevel;
        public System.Windows.Forms.Label Label1;
        public System.Windows.Forms.Button CancelButton_Renamed;
        public System.Windows.Forms.Button OKButton;
    }
}