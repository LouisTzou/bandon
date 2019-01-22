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
    public partial class Form便當菜 : Form
    {
        SqlConnectionStringBuilder scsb;

        public string StoreName = "";

        public Form便當菜()
        {
            InitializeComponent();
        }

        private void Form便當菜_Load(object sender, EventArgs e)
        {
            Form值日生端 myform值日生端 = new Form值日生端();
            lbl店家名.Text = StoreName;

            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "MidReport";
            scsb.IntegratedSecurity = true;

            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            string strSQL = "select *From StoreFoodInfo where StoreName =@SearchStoreName";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@SearchStoreName", lbl店家名.Text);

            SqlDataReader reader = cmd.ExecuteReader();
            
            string strMsg = "";
            string strPrice = "";
            while (reader.Read() == true)
            {
                strMsg = string.Format("{0}", reader["StoreFood"]);
                strPrice = string.Format("{0}", reader["StoreFoodPrice"]);

                listBox1.Items.Add(strMsg);
                listBox2.Items.Add(strPrice);
            }
            reader.Close();
        }

        private void btn新增_Click(object sender, EventArgs e)
        {
            if ((tb便當名.Text.Length > 0) && (tb價錢.Text.Length > 0))
            {

                DialogResult R;
                R = MessageBox.Show("確定資料正確?", "請再次確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (R == DialogResult.OK)
                {
                    SqlConnection con = new SqlConnection(scsb.ToString());
                    con.Open();
                    string strSQL = "insert into [StoreFoodInfo] values(@NewStoreName,@NewStoreFood,@NewFoodPrice )";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@NewStoreName", lbl店家名.Text);
                    cmd.Parameters.AddWithValue("@NewStoreFood", tb便當名.Text);
                    cmd.Parameters.AddWithValue("@NewFoodPrice", tb價錢.Text);
                    cmd.ExecuteNonQuery();

                    con.Close();
                    listBox1.Items.Add(tb便當名.Text);
                    listBox2.Items.Add(tb價錢.Text);
                    tb便當名.Text = "";
                    tb價錢.Text = "";
                }
            }
            else
            {
                MessageBox.Show("請輸入完整資料!!!");
            }
        }

        private void btn修改_Click(object sender, EventArgs e)
        {
            DialogResult R;
            R = MessageBox.Show("確定修改資料?", "請再次確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (R == DialogResult.OK)
            {
                if ((tb便當名.Text.Length > 0) && (tb價錢.Text.Length > 0))
                {
                    SqlConnection con = new SqlConnection(scsb.ToString());
                    con.Open();
                    string strSQL = "update StoreFoodInfo set StoreName=@NewStoreName,StoreFood=@NewStoreFood,StoreFoodPrice=@NewStoreFoodPrice where StoreName=@SearchStoreName and StoreFood = @searchStoreFood";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@NewStoreName", lbl店家名.Text);
                    cmd.Parameters.AddWithValue("@NewStoreFood", tb便當名.Text);
                    cmd.Parameters.AddWithValue("@NewStoreFoodPrice", tb價錢.Text);
                    cmd.Parameters.AddWithValue("@SearchStoreName", lbl店家名.Text);
                    cmd.Parameters.AddWithValue("@searchStoreFood", tb便當名.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();


                    int index = listBox1.SelectedIndex;
                    if (index >= 0)
                    {
                        listBox1.Items[index] = tb便當名.Text;
                    }

                    int index1 = listBox1.SelectedIndex;
                    if (index1 >= 0)
                    {
                        listBox2.Items[index1] = tb價錢.Text;
                    }

                    //listBox2.SelectedItem = tb價錢.Text;
                }
            }
        }

        private void btn刪除_Click(object sender, EventArgs e)
        {
            DialogResult R;
            R = MessageBox.Show("確定刪除?", "請再次確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if ((R == DialogResult.OK) && (listBox1.SelectedIndex >= 0))
            {
                SqlConnection con = new SqlConnection(scsb.ToString());
                con.Open();
                string strSQL = "delete from StoreFoodInfo where storeFood = @searchStoreFood and StoreName = @searchStoreName";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                Console.WriteLine(listBox1.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@searchStoreFood", listBox1.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@searchStoreName", lbl店家名.Text);
                cmd.ExecuteNonQuery();

                
                con.Close();

                listBox2.Items.Remove(listBox2.SelectedItem.ToString());
                listBox1.Items.Remove(listBox1.SelectedItem.ToString());

                //listBox2.Items.RemoveAt(listBox1.SelectedIndex);
                //listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.SelectedIndex = listBox1.SelectedIndex;
            

                tb便當名.Text = listBox1.SelectedItem.ToString();
                tb價錢.Text = listBox2.SelectedItem.ToString();
            
            
        }
    }
}
