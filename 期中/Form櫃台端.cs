using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 期中
{
    public partial class Form櫃台端 : Form
    {
        public Form櫃台端()
        {
            InitializeComponent();
        }
        public Form櫃台端(string strTextMsg)
        {
            InitializeComponent();

            櫃lbl值日生輸出.Text = strTextMsg;
        }
        
        private void Form櫃台端_Load(object sender, EventArgs e)
        {
            
        }

        private void btn最小化_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
