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
    public partial class Form值日生輸入資料 : Form
    {
        SqlConnectionStringBuilder scsb;

        public Form值日生輸入資料()
        {
            InitializeComponent();
        }
        private void Form值日生輸入資料_Load(object sender, EventArgs e)
        {
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "MidReport";
            scsb.IntegratedSecurity = true;
        }        

        private void 值輸btn登入值日生系統_Click(object sender, EventArgs e)
        {
            
            if ((tb值日生姓名.Text.Length > 0) && (tb值日生班級.Text.Length > 0) && (tb值日生電話.Text.Length > 0))
            {
                SqlConnection con = new SqlConnection(scsb.ToString());
                con.Open();
                string strSQL = "Insert Into 值日生Info(@new值日生班級,@new值日生姓名,@new值日生電話)";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@New值日生班級", tb值日生班級.Text);
                cmd.Parameters.AddWithValue("@New值日生姓名", tb值日生姓名.Text);
                cmd.Parameters.AddWithValue("@New值日生電話", tb值日生電話.Text);
                Form值日生端 myform值日生端 = new Form值日生端();
                Form學生端 myform學生端 = new Form學生端();
                Form值日生輸入資料 myform值日生輸入資料 = new Form值日生輸入資料();
                Form櫃台端 myform櫃台端 = new Form櫃台端(tb值日生姓名.Text);
                myform值日生端.Show();
                //myform值日生端.ShowDialog();
                myform值日生輸入資料.ShowInTaskbar = false;
                myform學生端.str接收的字串 = tb值日生姓名.Text.ToString();
                myform學生端.Show();
                //myform學生端.ControlBox = false;
                //myform學生端.WindowState = FormWindowState.Minimized;
                myform學生端.Dispose();
                con.Close();
            }
            else
            {
                MessageBox.Show("請輸入完整資料");
            }
        }
    }
}
