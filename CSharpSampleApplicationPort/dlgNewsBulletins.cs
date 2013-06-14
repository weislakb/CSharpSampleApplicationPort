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
    public partial class dlgNewsBulletins : Form
    {
        //================================================================================
        // Private Members
        //================================================================================
        private bool m_subscribe;
        private bool m_allMsgs;
        private bool m_ok;

        // ========================================================
        // Get/Set Methods
        // ========================================================
        public bool subscribe //remove ReadOnly
        {
            get { return m_subscribe; }
        }

        public bool allMsgs //remove ReadOnly
        {
            get { return m_allMsgs; }
        }

        public bool ok //remove ReadOnly
        {
            get { return m_ok; }
        }

        public dlgNewsBulletins()
        {
            InitializeComponent();
        }

        //================================================================================
        // Button Events
        //================================================================================

        //--------------------------------------------------------------------------------
        //   Aborts the news bulletin request and hides this dialog
        //--------------------------------------------------------------------------------
        private void cmdClose_Click(object sender, EventArgs e)
        {
            m_ok = false;
            this.Hide();
        }

        //--------------------------------------------------------------------------------
        //   Subscribes to IB news bulletins. When subscribing users can get all the existing
        //   days messages and will be notified of new messages
        //--------------------------------------------------------------------------------
        private void cmdSubscribe_Click(object sender, EventArgs e)
        {
            m_ok = true;
            m_subscribe = true;
            m_allMsgs = (optAllMsgs.Checked = true);
            this.Hide();
        }

        //--------------------------------------------------------------------------------
        //   Unsubscribes to news bulletins so users will not receive IB new bulletin
        //   notifications.
        //--------------------------------------------------------------------------------
        private void cmdUnsubscribe_Click(object sender, EventArgs e)
        {
            m_ok = true;
            m_subscribe = false;
            this.Hide();
        }

        //--------------------------------------------------------------------------------
        //   Default to the 'new messages only' subscription option if not is specified.
        //--------------------------------------------------------------------------------
        private void dlgNewsBulletins_Load(object sender, EventArgs e)
        {
            optNewMsgs.Checked = true;
        }


    }
}
