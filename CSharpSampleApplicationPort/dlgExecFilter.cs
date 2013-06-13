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

            txtClientId.text = execFilter.clientId;
            txtAcctCode.text = execFilter.acctCode;
            txtTime.text = execFilter.time;
            txtSymbol.text = execFilter.symbol;
            txtSecType.text = execFilter.secType;
            txtExchange.text = execFilter.exchange;
            txtAction.text = execFilter.side;

        }
    }
}
