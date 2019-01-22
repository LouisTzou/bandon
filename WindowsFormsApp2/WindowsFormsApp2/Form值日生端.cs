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
    public partial class Form值日生端 : Form
    {
        public Form值日生端()
        {
            InitializeComponent();
        }

        private void storeInfoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.storeInfoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.midReportDataSet);

        }

        


        private void Form值日生端_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'midReportDataSet.OrderList' 資料表。您可以視需要進行移動或移除。
            this.orderListTableAdapter.Fill(this.midReportDataSet.OrderList);
            // TODO: 這行程式碼會將資料載入 'midReportDataSet.StoreInfo' 資料表。您可以視需要進行移動或移除。
            this.storeInfoTableAdapter.Fill(this.midReportDataSet.StoreInfo);
            pictureBox2.Image = Image.FromFile(值tb輸入圖片位址.Text);
        }

        private void 值btn上一家_Click(object sender, EventArgs e)
        {
            storeInfoBindingSource.MovePrevious();
            pictureBox2.Image = Image.FromFile(值tb輸入圖片位址.Text);
        }

        

        private void 值btn下一家_Click(object sender, EventArgs e)
        {
            storeInfoBindingSource.MoveNext();
            pictureBox2.Image = Image.FromFile(值tb輸入圖片位址.Text);
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
            Form學生端 myform學生端 = new Form學生端();
            //myform學生端
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
