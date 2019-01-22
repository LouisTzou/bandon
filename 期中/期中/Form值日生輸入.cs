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
    public partial class Form值日生輸入 : Form
    {
        Form值日生端 myform值日生端 = new Form值日生端();
        //Form值日生輸入資料 myform值日生輸入資料
        SqlConnectionStringBuilder scsb;

        public Form值日生輸入()
        {
            InitializeComponent();
        }

        private void Form值日生輸入_Load(object sender, EventArgs e)
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
                SqlConnection con1 = new SqlConnection(scsb.ToString());
                con1.Open();
                string strSQL1 = "insert into [DutyInfo] values(@newDutyClass, @newDutyName, @newDutyPhoneNum)";
                SqlCommand cmd1 = new SqlCommand(strSQL1, con1);
                cmd1.Parameters.AddWithValue("@newDutyClass", tb值日生班級.Text);
                cmd1.Parameters.AddWithValue("@newDutyName", tb值日生姓名.Text);
                cmd1.Parameters.AddWithValue("@newDutyPhoneNum", tb值日生電話.Text);
                cmd1.ExecuteNonQuery();

                

                //Form值日生輸入 myform值日生輸入資料 = new Form值日生輸入();
                //Form櫃台端 myform櫃台端 = new Form櫃台端();
                //myform值日生端.ShowDialog();
                //myform值日生輸入資料.ShowInTaskbar = false;
                //myform學生端.Show();
                //myform學生端.ControlBox = false;
                //myform學生端.WindowState = FormWindowState.Minimized;
                //myform學生端.Dispose();
                //con.Close();
                //myform櫃台端.Show();
                //myform櫃台端.WindowState = FormWindowState.Minimized;
                con1.Close();
            }
            else
            {
                MessageBox.Show("請輸入完整資料");
            }

        }

        private void btn登入值日生系統_Click(object sender, EventArgs e)
        {

            Form學生端 myform學生端 = new Form學生端();
            myform學生端.strMsg2 = tb值日生姓名.Text;
            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            string strSQL = "select * from DutyInfo";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();
            //select top 1[欄位清單] from[資料表] order by[排序欄位] desc

            
            string strMsg = "";
            //myform值日生端.Show();
            while (reader.Read() == true)
            {
                strMsg = string.Format("{0}", reader["DutyName"]);
                listBox1.Items.Add(strMsg);
            }
            reader.Close();

            for(int i = 0; i < listBox1.Items.Count; i++)
            {
                if (tb值日生姓名.Text == listBox1.Items[i].ToString())
                {
                    string strinsert = "insert into [DutyInfoS] values(@NewDutyClass,@NewDutyName,@NewDutyPhoneNum) ";
                    SqlCommand cmd1 = new SqlCommand(strinsert,con);
                    cmd1.Parameters.AddWithValue("@NewDutyClass", tb值日生班級.Text);
                    cmd1.Parameters.AddWithValue("@NewDutyName", tb值日生姓名.Text);
                    cmd1.Parameters.AddWithValue("@NewDutyPhoneNum", tb值日生電話.Text);
                    cmd1.ExecuteNonQuery();

                    myform值日生端.Show();
                    break;
                }
            }

            

            con.Close();
            this.Dispose();
        }
    }
}
