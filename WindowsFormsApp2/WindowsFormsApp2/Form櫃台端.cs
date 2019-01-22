using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp2
{    
    public partial class Form櫃台端 : Form
    {
        SqlConnectionStringBuilder scsb;
        public Form櫃台端()
        {
            InitializeComponent();
        }
        public Form櫃台端(string strTextMsg)
        {
            InitializeComponent();
            櫃lbl值日生輸出.Text = strTextMsg;
        }

        public string lblMsg
        {
            set
            {
                櫃lbl值日生輸出.Text = value;
            }
        }

        private void Form櫃台端_Load(object sender, EventArgs e)
        {
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "MidReport";
            scsb.IntegratedSecurity = true;


        }
    }
}
