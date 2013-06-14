namespace CSharpSampleApplicationPort
{
    partial class dlgUnderComp
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
            this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtDelta = new System.Windows.Forms.TextBox();
            this.cmdOk = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdReset = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtConId = new System.Windows.Forms.TextBox();
            this.TableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TableLayoutPanel1
            // 
            this.TableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TableLayoutPanel1.ColumnCount = 3;
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.TableLayoutPanel1.Controls.Add(this.txtPrice, 1, 2);
            this.TableLayoutPanel1.Controls.Add(this.txtDelta, 1, 1);
            this.TableLayoutPanel1.Controls.Add(this.cmdOk, 2, 0);
            this.TableLayoutPanel1.Controls.Add(this.cmdCancel, 2, 2);
            this.TableLayoutPanel1.Controls.Add(this.cmdReset, 2, 1);
            this.TableLayoutPanel1.Controls.Add(this.Label1, 0, 0);
            this.TableLayoutPanel1.Controls.Add(this.Label2, 0, 1);
            this.TableLayoutPanel1.Controls.Add(this.Label3, 0, 2);
            this.TableLayoutPanel1.Controls.Add(this.txtConId, 1, 0);
            this.TableLayoutPanel1.Location = new System.Drawing.Point(10, 11);
            this.TableLayoutPanel1.Name = "TableLayoutPanel1";
            this.TableLayoutPanel1.RowCount = 3;
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.TableLayoutPanel1.Size = new System.Drawing.Size(293, 115);
            this.TableLayoutPanel1.TabIndex = 1;
            // 
            // txtPrice
            // 
            this.txtPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPrice.Location = new System.Drawing.Point(100, 85);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(91, 20);
            this.txtPrice.TabIndex = 2;
            // 
            // txtDelta
            // 
            this.txtDelta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDelta.Location = new System.Drawing.Point(100, 47);
            this.txtDelta.Name = "txtDelta";
            this.txtDelta.Size = new System.Drawing.Size(91, 20);
            this.txtDelta.TabIndex = 1;
            // 
            // cmdOk
            // 
            this.cmdOk.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdOk.Location = new System.Drawing.Point(210, 7);
            this.cmdOk.Name = "cmdOk";
            this.cmdOk.Size = new System.Drawing.Size(67, 23);
            this.cmdOk.TabIndex = 0;
            this.cmdOk.Text = "OK";
            // 
            // cmdCancel
            // 
            this.cmdCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancel.Location = new System.Drawing.Point(210, 84);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(67, 23);
            this.cmdCancel.TabIndex = 2;
            this.cmdCancel.Text = "Cancel";
            // 
            // cmdReset
            // 
            this.cmdReset.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdReset.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.cmdReset.Location = new System.Drawing.Point(210, 45);
            this.cmdReset.Name = "cmdReset";
            this.cmdReset.Size = new System.Drawing.Size(67, 23);
            this.cmdReset.TabIndex = 1;
            this.cmdReset.Text = "Reset";
            // 
            // Label1
            // 
            this.Label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(19, 12);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(59, 13);
            this.Label1.TabIndex = 3;
            this.Label1.Text = "Contract Id";
            // 
            // Label2
            // 
            this.Label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(32, 50);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(32, 13);
            this.Label2.TabIndex = 4;
            this.Label2.Text = "Delta";
            // 
            // Label3
            // 
            this.Label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(33, 89);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(31, 13);
            this.Label3.TabIndex = 5;
            this.Label3.Text = "Price";
            // 
            // txtConId
            // 
            this.txtConId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtConId.Location = new System.Drawing.Point(100, 9);
            this.txtConId.Name = "txtConId";
            this.txtConId.Size = new System.Drawing.Size(91, 20);
            this.txtConId.TabIndex = 0;
            // 
            // dlgUnderComp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 136);
            this.Controls.Add(this.TableLayoutPanel1);
            this.Name = "dlgUnderComp";
            this.Text = "dlgUnderComp";
            this.TableLayoutPanel1.ResumeLayout(false);
            this.TableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel1;
        internal System.Windows.Forms.TextBox txtPrice;
        internal System.Windows.Forms.TextBox txtDelta;
        internal System.Windows.Forms.Button cmdOk;
        internal System.Windows.Forms.Button cmdCancel;
        internal System.Windows.Forms.Button cmdReset;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txtConId;
    }
}