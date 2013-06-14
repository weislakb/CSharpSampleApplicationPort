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
    public partial class dlgLogConfig : Form
    {
        // ===============================================================================
        // Public Members
        // ===============================================================================
        public enum LOG_LEVEL
        {
            Sys = 1,
            Err,
            Warn,
            Info,
            Detail
        }

        // ===============================================================================
        // Private Members
        // ===============================================================================
        private int m_serverLogLevel;   //Change from short to int
        private bool m_ok;

        // ===============================================================================
        // Get/Set Properties
        // ===============================================================================
        public int serverLogLevel //removed ReadOnly
        {
            get { return m_serverLogLevel; }
        }
        public bool ok //removed ReadOnly
        {
            get { return m_ok; }
        }

        public dlgLogConfig()
        {
            InitializeComponent();
        }
        
        // ========================================================
        // Private Methods
        // ========================================================
        private void dlgLogConfig_Load()
        {
            cmbServerLogLevel.Items.Add(("System"));
            cmbServerLogLevel.Items.Add(("Error"));
            cmbServerLogLevel.Items.Add(("Warning"));
            cmbServerLogLevel.Items.Add(("Information"));
            cmbServerLogLevel.Items.Add(("Detail"));

            cmbServerLogLevel.SelectedIndex = (int)LOG_LEVEL.Err - 1; // Default TWS log level is ERROR
        }


        // ========================================================
        // Button Events
        // ========================================================
        private void OKButton_Click(object sender, EventArgs e)
        {
            m_serverLogLevel = cmbServerLogLevel.SelectedIndex + 1;
            m_ok = true;

            this.Hide();
        }

        private void CancelButton_Renamed_Click(object sender, EventArgs e)
        {
            m_ok = false;
            this.Hide();
        }


    }
}
