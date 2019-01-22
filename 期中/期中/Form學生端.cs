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
    public partial class Form學生端 : Form
    {
        SqlConnectionStringBuilder scsb;
        public string strMsg1 = "";
        public string strMsg2 = "";

        public Form學生端()
        {
            InitializeComponent();
        }

        private void Form學生端_Load(object sender, EventArgs e)
        {
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "MidReport";
            scsb.IntegratedSecurity = true;

            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            string strSQL = "select *From StoreFoodInfo where StoreName =@SearchStoreName";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@SearchStoreName", strMsg1.ToString());
            
            SqlDataReader reader = cmd.ExecuteReader();

            label2.Text = "今日便當: " + strMsg1.ToString();
            Console.WriteLine(strMsg1.ToString());
            string strMsg = "";
            while (reader.Read() == true)
            {
                strMsg = string.Format("{0}", reader["StoreFood"]);
                學lbox.Items.Add(strMsg);
            }
            reader.Close();
            
            //label2.Text = this.strMsg2.ToString();




        }

        private void foodInfoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

        }

        private void 學lbl備註_Click(object sender, EventArgs e)
        {

        }

        private void 學btn匯出資料庫_Click_1(object sender, EventArgs e)
        {
            if(學tb姓名.Text.Length > 0)
            {

                SqlConnection con = new SqlConnection(scsb.ToString());
                con.Open();
                string strSQL = "select *From StudentInfo where StudentName  like @SearchStudentName";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchStudentName", "%" + 學tb姓名.Text + "%");
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read() == true)
                {
                    學tb學生班級.Text = string.Format("{0}", (string)reader["StudentClass"]);
                    學tb姓名.Text = string.Format("{0}", (string)reader["StudentName"]);
                    學tb電話.Text = string.Format("{0}", (string)reader["StudentPhoneNum"]);
                }
                else
                {
                    MessageBox.Show("查無此人");
                    學tb學生班級.Text = "";
                    學tb姓名.Text = "";
                    學tb電話.Text = "";
                }

                reader.Close();
                con.Close();
            }
            else
            {
                MessageBox.Show("請輸入搜尋字串");
            }

        }

        private void 學btn匯入資料庫_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            string strSQL = "select * from StudentInfo where StudentName  like @SearchStudentName";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@SearchStudentName", "%" + 學tb姓名.Text + "%");
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read() == true)
            {
                學tb學生班級.Text = string.Format("{0}", (string)reader["StudentClass"]);
                學tb姓名.Text = string.Format("{0}", (string)reader["StudentName"]);
                學tb電話.Text = string.Format("{0}", (string)reader["StudentPhoneNum"]);
            }
            else
            {
                MessageBox.Show("查無此人");
                學tb學生班級.Text = "";
                學tb姓名.Text = "";
                學tb電話.Text = "";
            }
            reader.Close();
            con.Close();
        }

        private void 學btn修改資料_Click(object sender, EventArgs e)
        {
            DialogResult R;
            R = MessageBox.Show("確定修改資料?", "請再次確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (R == DialogResult.OK)
            {
                if ((學tb姓名.Text.Length > 0) && (學tb學生班級.Text.Length > 0))
                {
                    SqlConnection con = new SqlConnection(scsb.ToString());
                    con.Open();
                    string strSQL = "update StudentInfo set StudentName = @NewStudentName,StudentPhoneNum = @NewStudentPhoneNum where  StudentName=@SearchStudentName";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@SearchStudentName", 學tb姓名.Text);
                    cmd.Parameters.AddWithValue("@NewStudentName", 學tb姓名.Text);
                    cmd.Parameters.AddWithValue("@NewStudentPhoneNum", 學tb電話.Text);
                    cmd.Parameters.AddWithValue("@NewStudentClass", 學tb學生班級.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn最小化_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void 學btn訂購_Click_1(object sender, EventArgs e)
        {
            if ((學tb姓名.Text.Length >0) && (numericUpDown1.Value > 0))
            {
                DialogResult R;
                R = MessageBox.Show("確定資料正確?", "請再次確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (R == DialogResult.OK)
                {
                    SqlConnection con = new SqlConnection(scsb.ToString());
                    con.Open();
                    string strSQL = "insert into [FormStudentChoice] values (@NewDate, @NewStudentClass,@NewStudentName,@NewStudentPhoneNum,@NewStoreFood,@NewPrice,@NewAmount)";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    string dt = DateTime.Now.ToShortDateString();
                    cmd.Parameters.AddWithValue("@NewDate", (string)dt);
                    cmd.Parameters.AddWithValue("@NewStudentClass", 學tb學生班級.Text);
                    cmd.Parameters.AddWithValue("@NewStudentName", 學tb姓名.Text);
                    cmd.Parameters.AddWithValue("@NewStudentPhoneNum", 學tb電話.Text);
                    cmd.Parameters.AddWithValue("@NewStoreFood", 學lbl訂購便當輸出.Text);
                    cmd.Parameters.AddWithValue("@NewPrice", Convert.ToInt32(學lbl便當價格顯示.Text));
                    cmd.Parameters.AddWithValue("@NewAmount", Convert.ToInt32(numericUpDown1.Value));
                    cmd.ExecuteNonQuery();

                    string strSQLTotal = "   select Sum(Price) As TotalPrice ,SUM(Amount) As TotalAmount from FormStudentChoice where StudentName = @searchStudentName";
                    SqlCommand cmd1 = new SqlCommand(strSQLTotal, con);
                    cmd1.Parameters.AddWithValue("@searchStudentName", 學tb姓名.Text);
                    string strtotalMsg = "";
                    string strtotalMsg1 = "";
                    SqlDataReader reader = cmd1.ExecuteReader();
                    reader.Read();
                    strtotalMsg = string.Format("{0}", reader["TotalPrice"]);
                    strtotalMsg1 = string.Format("{0}", reader["TotalAmount"]);
                    學lbl總價輸出.Text = strtotalMsg.ToString();
                    學lbl便當總數輸出.Text = strtotalMsg1.ToString();
                    reader.Close();
                    //con.Close();
                    con.Close();


                    string stringPrice = "價格: " + 學lbl便當價格顯示.Text; string stringAmount = "數量: " + numericUpDown1.Value;
                    listBox1.Items.Add(學lbl訂購便當輸出.Text);
                    listBox2.Items.Add(stringPrice);
                    listBox3.Items.Add(stringAmount);
                }


                //SqlConnection con1 = new SqlConnection(scsb.ToString());
                //con.Open();

            }
            else
            {
                MessageBox.Show("請選好再按喔~~~~");
            }

        }

        private void 學btn取消_Click_1(object sender, EventArgs e)
        {
            DialogResult R;
            R = MessageBox.Show("確定取消?", "請再次確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if ((R == DialogResult.OK) && (listBox1.SelectedIndex >= 0))
            {
                SqlConnection con = new SqlConnection(scsb.ToString());
                con.Open();
                string strSQL = "delete from FormStudentChoice where storeFood = @searchStoreFood and StudentName = @searchStudentName";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                Console.WriteLine(listBox1.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@searchStoreFood", listBox1.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@searchStudentName", 學tb姓名.Text);
                cmd.ExecuteNonQuery();

                string strSQLTotal = "select Sum(Price) As TotalPrice ,SUM(Amount) As TotalAmount from FormStudentChoice";
                SqlCommand cmd1 = new SqlCommand(strSQLTotal, con);
                string strtotalMsg = "";
                string strtotalMsg1 = "";
                SqlDataReader reader = cmd1.ExecuteReader();
                reader.Read();
                strtotalMsg = string.Format("{0}", reader["TotalPrice"]);
                strtotalMsg1 = string.Format("{0}", reader["TotalAmount"]);
                學lbl總價輸出.Text = strtotalMsg.ToString();
                學lbl便當總數輸出.Text = strtotalMsg1.ToString();
                reader.Close();
                con.Close();

                
                listBox3.Items.RemoveAt(listBox1.SelectedIndex);
                listBox2.Items.RemoveAt(listBox1.SelectedIndex);
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }

            
        }

        private void 學lbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            string strSQL = "select *From StoreFoodInfo where StoreName =@SearchStoreName";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@SearchStoreName", strMsg1.ToString());
            SqlDataReader reader = cmd.ExecuteReader();


            for (int i = 0; i <= 學lbox.SelectedIndex; i++)
            {
                reader.Read();
                學lbl訂購便當輸出.Text = string.Format("{0}", reader["StoreFood"]);
                學lbl便當價格顯示.Text = string.Format("{0}", reader["StoreFoodPrice"]);
            }

            con.Close();
        }

        private void numericUpDown1_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
             
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.SelectedIndex = listBox1.SelectedIndex;
            listBox3.SelectedIndex = listBox1.SelectedIndex;

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void 學btn送出訂單_Click(object sender, EventArgs e)
        {
            Form值日生端 myform值日生端 = new Form值日生端();
            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            string strSQL1 = "select StudentClass, StudentName, StudentPhoneNum,StoreFood,   SUM(Price) AS TotalPrice,SUM(Amount) AS TotalAmount From FormStudentChoice Group By StudentClass, StudentName, StudentPhoneNum,StoreFood";
            SqlCommand cmd1 = new SqlCommand(strSQL1, con);
            SqlDataReader reader1 = cmd1.ExecuteReader();
            
            string strStoreFood = "";
            int strTotalA = 0;
            int strTotalP = 0;
            string strClass = "";

            //string strTotalStoreFood = "";
            string strStudentName = "";
            string strStudentPhoneNum = "";


            while (reader1.Read() == true)
            {                
                strClass = string.Format("{0}", reader1["StudentClass"]);
                strStudentName = string.Format("{0}", reader1["StudentName"]);
                strStudentPhoneNum = string.Format("{0}", reader1["StudentPhoneNum"]);
                strStoreFood += string.Format("{0}", reader1["StoreFood"]) +" ";
                strTotalP += Convert.ToInt32(string.Format("{0}", reader1["TotalPrice"]));
                strTotalA += Convert.ToInt32(string.Format("{0}", reader1["TotalAmount"]));

                //strTotalStoreFood += strStoreFood;
            }


            myform值日生端.strTotalP1 = strTotalP;
            myform值日生端.strTotalA1 = strTotalA;

            myform值日生端.strList = "班級:" +strClass + "," +strStudentName + ",電話:" + strStudentPhoneNum + strStoreFood + ",價錢:"+ Convert.ToString(myform值日生端.strTotalP1) + ",數量:"+ Convert.ToString(myform值日生端.strTotalA1);


            
            myform值日生端.Show();
            this.Close();

        }

        private void label2_Click(object sender, EventArgs e)
        {
        }
    }
}
