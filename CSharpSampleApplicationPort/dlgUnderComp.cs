using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpSampleApplicationPort
{
    public partial class dlgUnderComp : Form
    {
        // ========================================================
        // Member variables
        // ========================================================
        private TWSLib.IUnderComp m_underComp;

        // ===============================================================================
        // Public Methods
        // ===============================================================================
        public void init(TWSLib.IUnderComp underComp)
        {
            m_underComp = underComp;

            txtConId.Text = underComp.conId.ToString();
            txtDelta.Text = underComp.delta.ToString();
            txtPrice.Text = underComp.price.ToString();
        }

        public dlgUnderComp()
        {
            InitializeComponent();
        }

        // ========================================================
        // Button Events
        // ========================================================
        private void cmdOk_Click(object sender, EventArgs e)
        {
            
            m_underComp.conId = Convert.ToInt32(txtConId.Text);
            m_underComp.delta = Convert.ToDouble(txtDelta.Text);
            m_underComp.price = Convert.ToDouble(txtPrice.Text);


            m_underComp = null; //Is this needed since .NET does GC?

            this.DialogResult = System.Windows.Forms.DialogResult.OK; //Verify what this does
            this.Close();
        }

        private void cmdReset_Click(object sender, EventArgs e)
        {
            m_underComp.conId = 0;
            m_underComp.delta = 0;
            m_underComp.price = 0;

            m_underComp = null; //Is this needed since .NET does GC?

            this.DialogResult = System.Windows.Forms.DialogResult.Abort; //Verify what this does
            this.Close();
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            m_underComp = null; //Is this needed since .NET does GC?

            this.DialogResult = System.Windows.Forms.DialogResult.Cancel; //Verify what this does
            this.Close();
        }
    }
}
