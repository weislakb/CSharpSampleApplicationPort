// ported by bweisl on 2013.06.13
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

    public partial class dlgExecFilter : Form
    {
        // ========================================================
        // Member variables
        // ========================================================
        private TWSLib.IExecutionFilter m_execFilter;

        private int m_reqId;
        private bool m_ok;

        // ========================================================
        // Get/Set Methods
        // ========================================================

        public int reqId //removed ReadOnly
        {
            get { return m_reqId; }
        }
        public TWSLib.IExecutionFilter execFilter //removed ReadOnly
        {
            get { return m_execFilter; }
        }
        public bool ok //removed ReadOnly
        {
            get { return m_ok; }
        }

        public dlgExecFilter()
        {
            InitializeComponent();
        }

        // ===============================================================================
        // Public Methods
        // ===============================================================================
        public void init()
        {
            m_execFilter = execFilter;

            txtClientId.Text = execFilter.clientId.ToString();
            txtAcctCode.Text = execFilter.acctCode;
            txtTime.Text = execFilter.time;
            txtSymbol.Text = execFilter.symbol;
            txtSecType.Text = execFilter.secType;
            txtExchange.Text = execFilter.exchange;
            txtAction.Text = execFilter.side;

        }

        private void cmdOk_Click(object sender, EventArgs e)
        {
            m_reqId = Text2Int(txtReqId.Text);

            m_execFilter.clientId = Text2Int(txtClientId.Text);
            m_execFilter.acctCode = txtAcctCode.Text;
            m_execFilter.time = txtTime.Text;
            m_execFilter.symbol = txtSymbol.Text;
            m_execFilter.secType = txtSecType.Text;
            m_execFilter.exchange = txtExchange.Text;
            m_execFilter.side = txtAction.Text;

            m_ok = true;
            this.Hide();
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            m_ok = false;
            this.Hide();
        }

        private void dlgExecFilter_Load(object sender, EventArgs e)
        {
            m_reqId = 0;
        }
        /*
        Might be good to rewrite this using If then and int.tryparse(string)
        Does this also need to include validataion
        */
        private int Text2Int(string text)   //removed reference type in signature
        {
            if (string.IsNullOrEmpty(text))
            {
                return 0;
            }
            else
            {
                return int.Parse(text);
            }
        }
    }
}
