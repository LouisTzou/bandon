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
    public partial class Form值日生端 : Form
    {
        SqlConnectionStringBuilder scsb;
        public Form值日生端()
        {
            InitializeComponent();
        }

        private void Form值日生端_Load(object sender, EventArgs e)
        {            
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "MidReport";
            scsb.IntegratedSecurity = true;
        }

        private void btn最小化_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void 值btn上一家_Click(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            pictureBox2.Image = Image.FromFile(值tb輸入圖片位址.Text);
        }

        private void 值btn下一家_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Image.FromFile(值tb輸入圖片位址.Text);
        }

        private void 值btn隨機選擇_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Image.FromFile(值tb輸入圖片位址.Text);
        }

        private void 值btn選擇店家_Click(object sender, EventArgs e)
        {

        }

        private void 值btn新增店家_Click(object sender, EventArgs e)
        {

        }

        private void 值btn儲存_Click(object sender, EventArgs e)
        {

        }

        private void 值btn刪除店家_Click(object sender, EventArgs e)
        {

        }

        private void 值btn修改店家_Click(object sender, EventArgs e)
        {

        }

        private void 值btn已繳費_Click(object sender, EventArgs e)
        {

        }

        private void 值btn退費_Click(object sender, EventArgs e)
        {

        }

        private void 值btn送出訂單_Click(object sender, EventArgs e)
        {

        }
    }
}
