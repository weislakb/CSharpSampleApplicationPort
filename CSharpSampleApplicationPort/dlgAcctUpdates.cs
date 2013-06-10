//  ported by bweisl on 2013.05.16
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
    public partial class dlgAcctUpdates : Form
    {
        // ===============================================================================
	    // Private Members
	    // ===============================================================================
        private string m_acctCode;
	    private bool m_subscribe;
	    private bool m_ok;
        // ========================================================
        // Form constructor
        // ========================================================                
        public dlgAcctUpdates()
        {
            InitializeComponent();
        }
        // ===============================================================================
	    // Get/Set Properties
	    // ===============================================================================
        public string acctCode //Removed readonly property
        {
            get { return m_acctCode; }
        }
        public bool subscribe //Removed readonly property
        {
            get { return m_subscribe; }
        }
        public bool ok //Removed readonly property
        {
            get { return m_ok; }
        }        
        // ========================================================
	    // Button Events
	    // ========================================================
        private void cmdSubscribe_Click(object sender, EventArgs e)
        {
            m_acctCode = txtAcctCode.Text;
		    m_subscribe = true;
		    m_ok = true;
            this.Hide();
        }

        private void cmdUnSubscribe_Click(object sender, EventArgs e)
        {
            m_acctCode = txtAcctCode.Text;
            m_subscribe = false;
            m_ok = true;
            this.Hide();
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            m_acctCode = "";
            m_ok = false;
            this.Hide();
        }
    }
}
