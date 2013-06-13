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
    public partial class dlgConnect : Form
    {
        // ===============================================================================
	    // Private Members
	    // ===============================================================================
        private string m_hostIP;
	    private int m_port;
	    private int m_clientId;
	    private bool m_ok;

        // ===============================================================================
	    // Get/Set Properties
	    // ===============================================================================
	    public string hostIP
        {
		    get { return m_hostIP; }
		}
	
	    public int port
    	{
		    get { return m_port; }
		}

	    public int clientId
    	{
		    get { return m_clientId; }
		}
	
	    public bool ok
    	{
		    get { return m_ok; }
		}


        public dlgConnect()
        {
            InitializeComponent();
        }

        // ========================================================
        // Button Events
        // ========================================================
        private void cmdOk_Click(object sender, EventArgs e)
        {
            m_hostIP = txtHostIP.Text;
            m_port = Convert.ToInt32(txtPort.Text);
            m_clientId = Convert.ToInt32(txtClientId.Text);
            m_ok = true;

            this.Hide();
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            m_ok = false;
            this.Hide();
        }
    }
}
