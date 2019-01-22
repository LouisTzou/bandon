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

namespace 期中
{
    public partial class Form櫃台端 : Form
    {
        public List<string> list = new List<string>();
        //public string StrTTTTT = "";
        public string strDutyClass = "";
        public string strDutyName = "";
        public int strtotalMsg1S = 0;
        public int strtotalMsgS = 0;
        public string strStoreName = "";
        public string strStorePhoneNum = "";



        public Form櫃台端()
        {
            InitializeComponent();
        }
        
        
        private void Form櫃台端_Load(object sender, EventArgs e)
        {
            foreach (var item in list)
            {
                櫃lbox.Items.Add(item);
            }
            
            櫃lbl班級輸出.Text = strDutyClass;
            櫃lbl值日生輸出.Text = strDutyName;
            櫃lbl便當總數輸出.Text = strtotalMsg1S.ToString();
            櫃lbl總價輸出.Text = strtotalMsgS.ToString();
            櫃lbl店名輸出.Text = strStoreName;
            櫃lbl電話輸出.Text = strStorePhoneNum;
        }

        private void btn最小化_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
