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
    public partial class dlgFinancialAdvisor : Form
    {
        private Utils m_utils;
        private bool m_ok;
        public Object aliasesXML, groupsXML, profilesXML, CRSTR;
        public string CRLFSTR;
        public dlgFinancialAdvisor()
        {
            InitializeComponent();
        }

        // ========================================================
        // Button Events
        // ========================================================
        private void cmdClose_Click(object sender, EventArgs e)
        {
            // clear any existing list details
            m_ok = true;
            this.Hide();
        }

        // ========================================================
        // Public methods
        // ========================================================

        public void init(Utils utilities, string faGroupXML, string faProfilesXML, string faAliasesXML)
        {
            m_utils = utilities;
            CRSTR = (char)10;  //verify cast output will be equivalent to Chr() output
            CRLFSTR = (char)13 + (char)10; //verify cast output will be equivalent to Chr() output
            lstGroups.Text = faGroupXML.Replace(CRSTR, CRLFSTR);
            lstProfiles.Text = faProfilesXML.Replace(CRSTR, CRLFSTR);
            lstAliases.Text = faAliasesXML.Replace(CRSTR, CRLFSTR);            
            m_ok = false;
        }
        public Object ok()
        {
            //Figure out why this returns type object rather than type bool
            groupsXML = lstGroups.Text.Replace(CRLFSTR, CRSTR);
            profilesXML = lstProfiles.Text.Replace(CRLFSTR, CRSTR);
            aliasesXML = lstAliases.Text.Replace(CRLFSTR, CRSTR);
            return m_ok;
        }

    }
}
