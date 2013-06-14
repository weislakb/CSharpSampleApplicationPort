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
    public partial class dlgSharesAlloc : Form
    {
        // ===============================================================================
        // Private Members
        // ===============================================================================
        private bool m_ok;
        private string m_faGroup;
        private string m_faMethod;
        private string m_faPercentage;
        private string m_faProfile;
        public string faGroup
        {
            get { return m_faGroup; }
        }
        public string faMethod
        {
            get { return m_faMethod; }
        }
        public string faPercentage
        {
            get { return m_faPercentage; }
        }
        public string faProfile
        {
            get { return m_faProfile; }
        }
        public bool ok
        {
            get { return m_ok; }
        }
	

        public dlgSharesAlloc()
        {
            InitializeComponent();
        }

        // ========================================================
        // Button Events
        // ========================================================
        private void cmdOK_Click(object sender, EventArgs e)
        {
            m_faGroup = txtFaGroup.Text;
            m_faMethod = txtFaMethod.Text;
            m_faPercentage = txtFaPercentage.Text;
            m_faProfile = txtFaProfile.Text;
            m_ok = true;
            this.Hide();
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            m_ok = false;
		    this.Hide();
        }

        // ========================================================
        // Public Methods
        // ========================================================
        public void init(ref string acctsList)
        {
            //What goes here???
        }
    }
}
