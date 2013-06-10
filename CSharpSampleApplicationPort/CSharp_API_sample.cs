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
    public partial class dlgMainWnd : Form
    {
        //================================================================================
	    // Private Members
	    //================================================================================
        // data members
        private TWSLib.IContract m_contractInfo;
        private TWSLib.IOrder m_orderInfo;
        private TWSLib.IExecutionFilter m_execFilter;
        private TWSLib.IUnderComp m_underComp;

        private dlgOrder m_dlgOrder = new dlgOrder();
        private dlgConnect m_dlgConnect = new dlgConnect();
	    private dlgMktDepth m_dlgMktDepth = new dlgMktDepth();
	    private dlgAcctData m_dlgAcctData = new dlgAcctData();
	    private Utils m_utils;
	    private dlgNewsBulletins m_dlgNewsBulletins = new dlgNewsBulletins();
	    private dlgLogConfig m_dlgLogConfig = new dlgLogConfig();
        private dlgFinancialAdvisor m_dlgFinancialAdvisor = new dlgFinancialAdvisor();
        private dlgScanner m_dlgScanner = new dlgScanner();

        private bool m_faAccount, faError;
	    private string m_faAcctsList;
        private string faGroupXML, faProfilesXML, faAliasesXML;
        //private short faErrorCodes(5);
        //private const int MKT_DEPTH_DATA_RESET = 317;
        
        //================================================================================
        // Public functions
        //================================================================================
        public bool isFAAccount //Removed readonly property
        {
            get { return m_faAccount;  }
        }
        public string FAManagedAccounts //Removed readonly property
        {
            get { return m_faAcctsList; }
        }
        public void requestScannerParameters()
        {
            Tws1.reqScannerParameters();
        }
        public void cancelScannerSubscription(ref short id)
        {
            Tws1.cancelScannerSubscription(id);
        }
        public void scannerSubscription(int id, TWSLib.IScannerSubscription subscription)
        {
            Tws1.reqScannerSubscriptionEx(id, subscription);
        }
        //================================================================================
        // Form constructor
        //================================================================================
        public dlgMainWnd()
        {
            InitializeComponent();
        }
        //================================================================================
        // Button Events
        //================================================================================
        //--------------------------------------------------------------------------------
        // Connect this API client to the TWS instance
        //--------------------------------------------------------------------------------
        private void cmdConnect_Click(object sender, EventArgs e)
        {
            // assume this is a non Financial Advisor account. If it is the managedAccounts()
            // event will be fired.
            m_faAccount = false;

            m_dlgConnect.ShowDialog();            
            if (m_dlgConnect.ok)
            {
                m_utils.addListItem(Utils.List_Types.SERVER_RESPONSES + "Connecting to Tws using clientId " + m_dlgConnect.clientId & " ...");
                Tws1.connect(m_dlgConnect.hostIP, m_dlgConnect.port, m_dlgConnect.clientId);
                if (Tws1.serverVersion > 0)
                {
                    string msg;
                    msg = "Connected to Tws server version " + Tws1.serverVersion + " at " + Tws1.TwsConnectionTime;
                    m_utils.addListItem(Utils.List_Types.SERVER_RESPONSES, msg);
                }                
            }            
        }
        //--------------------------------------------------------------------------------
        // Disconnect this API client from the TWS instance
        //--------------------------------------------------------------------------------
        private void cmdDisconnect_Click(object sender, EventArgs e)
        {
            Tws1.disconnect();
        }
        //--------------------------------------------------------------------------------
        // Request market data for a security
        //--------------------------------------------------------------------------------
        private void cmdReqMktData_Click(object sender, EventArgs e)
        {
            // Set the dialog state
            m_dlgOrder.init((dlgOrder.Dlg_Type.REQ_MKT_DATA_DLG), m_contractInfo, m_orderInfo, m_underComp, Me);

            m_dlgOrder.ShowDialog();
            if (m_dlgOrder.ok)
            {
                Tws1.reqMktDataEx(m_dlgOrder.orderId, m_contractInfo, m_dlgOrder.genericTickTags, m_dlgOrder.snapshotMktData);
            }
        }
        //--------------------------------------------------------------------------------
        // Cancel market data for a security
        //--------------------------------------------------------------------------------
        private void cmdCancelMktData_Click(object sender, EventArgs e)
        {
            // Set the dialog state
            m_dlgOrder.init((dlgOrder.Dlg_Type.CANCEL_MKT_DATA_DLG), m_contractInfo, m_orderInfo, m_underComp, Me);

            m_dlgOrder.ShowDialog();
            if (m_dlgOrder.ok) 
            {
                Tws1.cancelMktData(m_dlgOrder.orderId);
            }
        }

        private void cmdReqMktDepth_Click(object sender, EventArgs e)
        {

        }

        private void cmdCancelMktDepth_Click(object sender, EventArgs e)
        {

        }

        private void cmdReqHistoricalData_Click(object sender, EventArgs e)
        {

        }

        private void cmdCancelHistData_Click(object sender, EventArgs e)
        {

        }

        private void cmdReqRealTimeBars_Click(object sender, EventArgs e)
        {

        }

        private void cmdCancelRealTimeBars_Click(object sender, EventArgs e)
        {

        }

        private void cmdReqCurrentTime_Click(object sender, EventArgs e)
        {

        }

        private void cmdScanner_Click(object sender, EventArgs e)
        {

        }
        private void cmdWhatIf_Click(object sender, EventArgs e)
        {

        }

        private void cmdPlaceOrder_Click(object sender, EventArgs e)
        {

        }

        private void cmdCancelOrder_Click(object sender, EventArgs e)
        {

        }

        private void cmdExerciseOptions_Click(object sender, EventArgs e)
        {

        }

        private void cmdExtendedOrderAtribs_Click(object sender, EventArgs e)
        {

        }

        private void cmdReqContractData_Click(object sender, EventArgs e)
        {

        }

        private void cmdReqOpenOrders_Click(object sender, EventArgs e)
        {

        }

        private void cmdReqAllOpenOrders_Click(object sender, EventArgs e)
        {

        }

        private void cmdReqAutoOpenOrders_Click(object sender, EventArgs e)
        {

        }

        private void cmdReqAcctData_Click(object sender, EventArgs e)
        {

        }

        private void cmdReqExecutions_Click(object sender, EventArgs e)
        {

        }

        private void cmdReqIds_Click(object sender, EventArgs e)
        {

        }

        private void cmdReqNews_Click(object sender, EventArgs e)
        {

        }

        private void cmdServerLogLevel_Click(object sender, EventArgs e)
        {

        }

        private void cmdReqAccts_Click(object sender, EventArgs e)
        {

        }

        private void cmdFinancialAdvisor_Click(object sender, EventArgs e)
        {

        }

        private void cmdCalcImpliedVolatility_Click(object sender, EventArgs e)
        {

        }

        private void cmdCalcOptionPrice_Click(object sender, EventArgs e)
        {

        }

        private void cmdCancelCalcImpliedVolatility_Click(object sender, EventArgs e)
        {

        }

        private void cmdCancelCalcOptionPrice_Click(object sender, EventArgs e)
        {

        }

        private void cmdReqGlobalCancel_Click(object sender, EventArgs e)
        {

        }

        private void cmdReqMarketDataType_Click(object sender, EventArgs e)
        {

        }

        private void cmdClearForm_Click(object sender, EventArgs e)
        {

        }

        private void cmdClose_Click(object sender, EventArgs e)
        {

        }

    }
}
