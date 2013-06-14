namespace CSharpSampleApplicationPort
{
    partial class dlgServerResponse
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
            this.components = new System.ComponentModel.Container();
            this.OKButton = new System.Windows.Forms.Button();
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblMsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OKButton
            // 
            this.OKButton.BackColor = System.Drawing.SystemColors.Control;
            this.OKButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.OKButton.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OKButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.OKButton.Location = new System.Drawing.Point(145, 337);
            this.OKButton.Name = "OKButton";
            this.OKButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.OKButton.Size = new System.Drawing.Size(81, 25);
            this.OKButton.TabIndex = 2;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = false;
            // 
            // lblMsg
            // 
            this.lblMsg.BackColor = System.Drawing.SystemColors.Control;
            this.lblMsg.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblMsg.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsg.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMsg.Location = new System.Drawing.Point(12, 9);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblMsg.Size = new System.Drawing.Size(337, 313);
            this.lblMsg.TabIndex = 3;
            // 
            // dlgServerResponse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 380);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.lblMsg);
            this.Name = "dlgServerResponse";
            this.Text = "dlgServerResponse";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button OKButton;
        public System.Windows.Forms.ToolTip ToolTip1;
        public System.Windows.Forms.Label lblMsg;
    }
}