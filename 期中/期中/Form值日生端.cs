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
        Form學生端 myform學生端 = new Form學生端();
        //Form便當菜 myform便當菜 = new Form便當菜();

        public string strList = "";
        public int strTotalP1 = 0;
        public int strTotalA1 = 0;


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

            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            string strSQL = "select * from StoreInfo";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            string strMsg = "";
            while (reader.Read() == true)
            {
                strMsg = string.Format("{0}", reader["StoreName"]);
                comboBox2.Items.Add(strMsg);
            }

            reader.Close();
            con.Close();
            值lBox未繳費.Items.Add(strList);
            值tb便當總數.Text = strTotalP1.ToString();
            值tb總價.Text = strTotalA1.ToString();
        }

        private void btn最小化_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }       

        private void 值btn隨機選擇_Click(object sender, EventArgs e)
        {
            
            Random random = new Random();
            int random隨機選擇 = 0;
            random隨機選擇 = random.Next(0, comboBox2.Items.Count);
            comboBox2.SelectedIndex = Convert.ToInt32(random隨機選擇);
            pictureBox2.Image = Image.FromFile(值tb輸入圖片位址.Text);
        }

        private void 值btn選擇店家_Click(object sender, EventArgs e)
        {
            myform學生端.strMsg1 = 值tb店名.Text;

            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            string strSQL = "insert into StoreInfoS values (@NewStoreName,@NewStorePhoneNum )";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@NewStoreName", 值tb店名.Text);
            cmd.Parameters.AddWithValue("@NewStorePhoneNum", 值tb電話.Text);
            cmd.ExecuteNonQuery();
            con.Close();



            myform學生端.Show();
            this.Visible = false;
            tabPage1.Parent = null;
        }

        private void 值btn新增店家_Click(object sender, EventArgs e)
        {
            值lbl序號號碼.Text = "0";
            值tb店名.Text = "";
            值tb評價.Text = "輸入0.0-5.0";
            值tb地址.Text = "";
            值tb電話.Text = "格式:(手機)0000-000-000,(住家)(07)-996-1111";
            值tb備註欄.Text = "備註欄";
            值tb輸入圖片位址.Text = @"輸入完整位址EX:C:\\資料夾名\\資料夾名\\檔案名.格式";

        }

        private void 值btn儲存_Click(object sender, EventArgs e)
        {
            try
            {
                if ((值tb店名.Text.Length > 0) && (值tb電話.Text.Length > 0))
                {

                    DialogResult R;
                    R = MessageBox.Show("確定資料正確?", "請再次確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (R == DialogResult.OK)
                    {
                        Form便當菜 myform便當菜 = new Form便當菜();
                        SqlConnection con = new SqlConnection(scsb.ToString());
                        con.Open();
                        string strSQL = "insert into [StoreInfo] values(@NewStoreName,@NewValuation,@NewStoreAddress,@NewStorePhoneNum,@NewStoreRemark,@NewStroePicture)";
                        SqlCommand cmd = new SqlCommand(strSQL, con);
                        cmd.Parameters.AddWithValue("@NewStoreName", 值tb店名.Text);
                        cmd.Parameters.AddWithValue("@NewValuation", 值tb評價.Text);
                        cmd.Parameters.AddWithValue("@NewStoreAddress", 值tb地址.Text);
                        cmd.Parameters.AddWithValue("@NewStorePhoneNum", 值tb電話.Text);
                        cmd.Parameters.AddWithValue("@NewStoreRemark", 值tb備註欄.Text);
                        cmd.Parameters.AddWithValue("@NewStroePicture", 值tb輸入圖片位址.Text);
                        cmd.ExecuteNonQuery();

                        con.Close();
                        myform便當菜.StoreName = 值tb店名.Text;
                        myform便當菜.Show();
                        comboBox2.Items.Add(值tb店名.Text);
                    }
                }
                else
                {
                    MessageBox.Show("請輸入完整資料!!!");
                }
        }
            catch
            {
                MessageBox.Show("評價請輸入0.0~5.0");
            }

}

        private void 值btn刪除店家_Click(object sender, EventArgs e)
        {
            DialogResult R;
            R = MessageBox.Show("確定刪除資料?", "請再次確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (R == DialogResult.OK)
            {
                int int序號 = 0;
                Int32.TryParse(值lbl序號號碼.Text, out int序號);

                SqlConnection con = new SqlConnection(scsb.ToString());
                con.Open();
                string strSQL = "delete StoreInfo Where StoreID = @SearchStoreID";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchStoreID", int序號);
                cmd.ExecuteNonQuery();
                con.Close();
                值lbl序號.Text = "";
                值tb店名.Text = "";
                值tb地址.Text = "";
                值tb電話.Text = "";
                值tb評價.Text = "";
                值tb備註欄.Text = "備註欄";
                值tb輸入圖片位址.Text = "";
                comboBox2.Items.Remove(comboBox2.SelectedItem);
            }
        }

        private void 值btn修改店家_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult R;
                R = MessageBox.Show("確定修改資料?", "請再次確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if ((R == DialogResult.OK) &&(值tb店名.Text.Length > 0))
                {
                    Form便當菜 myform便當菜 = new Form便當菜();
                    int int序號 = 0;
                    Int32.TryParse(值lbl序號號碼.Text, out int序號);
                    if ((值tb店名.Text.Length > 0) && (值tb電話.Text.Length > 0))
                    {
                        SqlConnection con = new SqlConnection(scsb.ToString());
                        con.Open();
                        string strSQL = "update StoreInfo set  StoreName=@NewStoreName,Valuation=@NewValuation,StoreAddress=@NewStoreAddress,StorePhoneNum=@NewStorePhoneNum,StoreRemark=@NewStoreRemark,StorePicture=@NewStorePicture where StoreID=@SearchSotreID";
                        SqlCommand cmd = new SqlCommand(strSQL, con);
                        cmd.Parameters.AddWithValue("@SearchSotreID", int序號);
                        cmd.Parameters.AddWithValue("@NewStoreName", 值tb店名.Text);
                        cmd.Parameters.AddWithValue("@NewValuation", 值tb評價.Text);
                        cmd.Parameters.AddWithValue("@NewStoreAddress", 值tb地址.Text);
                        cmd.Parameters.AddWithValue("@NewStorePhoneNum", 值tb電話.Text);
                        cmd.Parameters.AddWithValue("@NewStoreRemark", 值tb備註欄.Text);
                        cmd.Parameters.AddWithValue("@NewStorePicture", 值tb輸入圖片位址.Text);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        myform便當菜.StoreName = 值tb店名.Text;
                        myform便當菜.Show();
                    }
                }
                else
                {
                    MessageBox.Show("沒有可以修改的店家");
                }
            }
            catch
            {
                MessageBox.Show("評價請輸入0.0~5.0");
            }
        }

        private void 值btn已繳費_Click(object sender, EventArgs e)
        {
            try
            {
                值lBox已繳費.Items.Add(值lBox未繳費.SelectedItem);
                值lBox未繳費.Items.RemoveAt(值lBox未繳費.SelectedIndex);
            }
            catch (Exception)
            {
                MessageBox.Show("請按下要改變的項目");
            }


        }

        private void 值btn退費_Click(object sender, EventArgs e)
        {
            try
            {

                值lBox未繳費.Items.Add(值lBox已繳費.SelectedItem);
                值lBox已繳費.Items.RemoveAt(值lBox已繳費.SelectedIndex);
            }
            catch (Exception)
            {
                MessageBox.Show("請按下要改變的項目");
            }
        }

        

        private void 值btn送出訂單_Click(object sender, EventArgs e)
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
            
            //myform櫃台端.Show();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            值lbl序號號碼.Text = "";
            值tb店名.Text = "";
            值tb評價.Text = "";
            值tb地址.Text = "";
            值tb電話.Text = "";
            值tb備註欄.Text = "";
            值tb輸入圖片位址.Text = "";
            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            string strSQL = "select * from StoreInfo";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();
            

            
            for (int i = 0; i <= comboBox2.SelectedIndex; i++)
            {
                reader.Read();
                值lbl序號號碼.Text = string.Format("{0}", reader["StoreID"]);
                值tb店名.Text = string.Format("{0}", reader["StoreName"]);
                值tb評價.Text = string.Format("{0}", reader["Valuation"]);
                值tb地址.Text = string.Format("{0}", reader["StoreAddress"]);
                值tb電話.Text = string.Format("{0}", reader["StorePhoneNum"]);
                值tb備註欄.Text = string.Format("{0}", reader["StoreRemark"]);
                值tb輸入圖片位址.Text = string.Format("{0}", reader["StorePicture"]);
            }


            
            
            con.Close();
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.Image = Image.FromFile(值tb輸入圖片位址.Text);
        }
    }
}
