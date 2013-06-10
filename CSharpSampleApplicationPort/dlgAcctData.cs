//  ported by bweisl on 2013.05.17
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
    public partial class dlgAcctData : Form
    {
        private Utils m_utils;

        private string m_accountName;
        private bool m_complete;
        // ========================================================
        // Form constructor
        // ========================================================
        public dlgAcctData()
        {
            InitializeComponent();
        }
        // ========================================================
	    // Button Events
	    // ========================================================
        private void cmdClose_Click(object sender, EventArgs e)
        {
      		// clear any existing list details
	    	lstKeyValueData.Items.Clear();
		    lstPortfolioData.Items.Clear();
            txtLastUpdateTime.Text = "00:00";

            this.Hide();
        }
        // ========================================================
	    // Public methods
	    // ========================================================
	    //--------------------------------------------------------------------------------
	    // Class initializer. Make utilites available to this class
	    //--------------------------------------------------------------------------------
        public void init(Utils utilities)
        {
            m_utils = utilities;
        }
        //--------------------------------------------------------------------------------
	    // Updates a user account property
	    //--------------------------------------------------------------------------------
        public void updateAccountValue(ref string key, ref string val_Renamed, ref string currency, ref string accountName)
        {
            string msg;

            msg = "key=" + key + " value=" + val_Renamed + " currency=" + currency + " account=" + accountName;
            m_utils.addListItem(Utils.List_Types.ACCOUNT_DATA, msg);
        }
        //--------------------------------------------------------------------------------
        // Updates a portfolio position details
        //--------------------------------------------------------------------------------
        public void updatePortfolio(TWSLib.IContract contract, ref int position, ref double marketPrice, ref double marketValue, ref double averageCost, ref double unrealizedPNL, ref double realizedPNL, ref string accountName)
        {
            string msg;
                        
            msg = "conId=" + contract.conId + " symbol=" + contract.symbol + " secType=" + contract.secType + " expiry=" + contract.expiry + " strike=" + contract.strike +
            " right=" + contract.right + " multiplier=" + contract.multiplier + " primaryExch=" + contract.primaryExchange + " currency=" + contract.currency +
            " localSymbol=" + contract.localSymbol + " position=" + position + " mktPrice=" + marketPrice + " mktValue=" + marketValue +
            " avgCost=" + averageCost + " unrealizedPNL=" + unrealizedPNL + " realizedPNL=" + realizedPNL + " account=" + accountName;
        
            m_utils.addListItem(Utils.List_Types.PORTFOLIO_DATA, msg);
        }
        //--------------------------------------------------------------------------------
        // Updates the server clock time
        //--------------------------------------------------------------------------------
        public void updateAccountTime(ref string timeStamp)
        {
            txtLastUpdateTime.Text = timeStamp;
        }
        public void accountDownloadBegin(string accountName)
        {
            m_accountName = accountName;
            m_complete = false;
            updateTitle();
        }
        public void accountDownloadEnd(string accountName)
        {
            if ((m_accountName.Length != 0) && (m_accountName != accountName))
            {
                return;
            }

            m_complete = true;
            updateTitle();
        }
        private void updateTitle()
        {
            string title = "";
        
            if (m_accountName.Length != 0)
            {
                title = m_accountName;
            }
            
            if (m_complete)
            {
                if (title.Length != 0)
                {
                    title = title + " ";
                }                
                title += "[complete]";
            }
            this.Text = title;
        }
    }
}
