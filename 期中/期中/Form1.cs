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
    public partial class Form1 : Form
    {
        SqlConnectionStringBuilder scsb;

        //Form櫃台端 myform櫃台端 = new Form櫃台端();
        Form值日生端 myform值日生端 = new Form值日生端();
        public Form1()
        {
            InitializeComponent();            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "MidReport";
            scsb.IntegratedSecurity = true;

            MessageBox.Show("*****歡迎光臨,鄒魯訂便當系統*****\n1.第一次登入請按下按鈕刪除暫存\n2.值日生請先選定店家");
        }

        private void F1btn值日生_Click(object sender, EventArgs e)
        {

            Form值日生輸入 myform值日生輸入 = new Form值日生輸入();
            

                //this.Hide();
                //myform值日生輸入資料.Visible = true;
                myform值日生輸入.Show();
            

        }

        private void F1btn櫃台_Click(object sender, EventArgs e)
        {
            //if (myform櫃台端.Visible == false)
            //{
            //    myform櫃台端.Visible = true;

            //}
            //myform櫃台端.WindowState = FormWindowState.Normal;
            try
            {
                Form櫃台端 myform櫃台端 = new Form櫃台端();
                //scsb = new SqlConnectionStringBuilder();
                //scsb.DataSource = @".";
                //scsb.InitialCatalog = "MidReport";
                //scsb.IntegratedSecurity = true;

                SqlConnection con = new SqlConnection(scsb.ToString());
                con.Open();
                string strSQLTotal = "select StoreFood, SUM(Price) AS TotalPrice,SUM(Amount) AS TotalAmount From FormStudentChoice Group By StoreFood";
                SqlCommand cmd1 = new SqlCommand(strSQLTotal, con);
                string StrTTTTT = "";
                string strStoreFoodMsg = "";
                string strtotalMsg = "";
                int strtotalMsgS = 0;
                string strtotalMsg1 = "";
                int strtotalMsg1S = 0;
                SqlDataReader reader = cmd1.ExecuteReader();
                while (reader.Read() == true)
                {
                    strStoreFoodMsg = string.Format("{0}", reader["StoreFood"]);
                    strtotalMsg = string.Format("{0}", reader["TotalPrice"]);
                    strtotalMsg1 = string.Format("{0}", reader["TotalAmount"]);
                    StrTTTTT = strStoreFoodMsg + " " + "總價:" + strtotalMsg + " " + "總數:" + strtotalMsg1;
                    myform櫃台端.list.Add(StrTTTTT);
                    //櫃lbox.Items.Add(StrTTTTT);/****************************************/
                     myform櫃台端.strtotalMsgS += Convert.ToInt32(strtotalMsg);
                    myform櫃台端.strtotalMsg1S += Convert.ToInt32(strtotalMsg1);
                }
                reader.Close();
                string strMsg = "  select top 1  * From DutyInfoS   order by DutyID desc";

                SqlCommand cmd = new SqlCommand(strMsg, con);
                SqlDataReader reader1 = cmd.ExecuteReader();
                reader1.Read();
                string strDutyClass = "";
                string strDutyName = "";
                //string strDutyPhoneNum = "";
                myform櫃台端.strDutyClass = string.Format("{0}", reader1["DutyClass"]);
                myform櫃台端.strDutyName = string.Format("{0}", reader1["DutyName"]);
                //strDutyPhoneNum = string.Format("{0}", reader1["DutyPhoneNum"]);

                //櫃lbl班級輸出.Text = strDutyClass;/*******************************************/
                //櫃lbl值日生輸出.Text = strDutyName;/*******************************************/

                //櫃lbl便當總數輸出.Text = strtotalMsg1S.ToString();/*********************************/
                //櫃lbl總價輸出.Text = strtotalMsgS.ToString();/***********************************/
                reader1.Close();

                string strMsg2 = "  select top 1  * From StoreInfoS   order by StoreID desc";

                SqlCommand cmd2 = new SqlCommand(strMsg2, con);
                SqlDataReader reader2 = cmd2.ExecuteReader();
                string strStoreName = "";
                string strStorePhoneNum = "";
                //string strDutyPhoneNum = "";
                reader2.Read();
                myform櫃台端.strStoreName = string.Format("{0}", reader2["StoreName"]);
                myform櫃台端.strStorePhoneNum = string.Format("{0}", reader2["StorePhoneNum"]);


                //櫃lbl店名輸出.Text = strStoreName;/**************************************/
                //櫃lbl電話輸出.Text = strStorePhoneNum;/*************************************/

                con.Close();
                myform櫃台端.Show();
            }
            catch
            {
                MessageBox.Show("尚未完成訂單");

            }
        }

        private void F1btn學生_Click(object sender, EventArgs e)
        {
            try
            {

                Form學生端 myform學生端 = new Form學生端();

                SqlConnection con = new SqlConnection(scsb.ToString());
                con.Open();
                string strSQL = "select top 1  * from StoreInfoS order by StoreID desc";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();

                myform學生端.strMsg1 = string.Format("{0}", reader["StoreName"]);


                myform學生端.Show();
            }
            catch
            {
                MessageBox.Show("值日生尚未選店");
            }
            //myform學生端.WindowState = FormWindowState.Normal;
        }

        private void btn刪除暫存_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            string strSQL = "delete from FormStudentChoice " +
                "delete from StoreInfoS " +
                "delete from DutyInfoS ";

            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.ExecuteNonQuery();
            //SqlDataReader reader = cmd.ExecuteReader();
            //reader.Close();
            con.Close();
        }
    }
}
