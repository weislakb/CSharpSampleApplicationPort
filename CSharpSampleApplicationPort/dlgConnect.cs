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
    }
}
