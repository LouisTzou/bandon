using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form學生端 : Form
    {
        public string str接收的字串 = "";

        public Form學生端()
        {
            InitializeComponent();
        }

        public void 備註text(string 值日生)
        {
            
        }

        private void Form學生端_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'midReportDataSet.StoreInfo' 資料表。您可以視需要進行移動或移除。
            this.storeInfoTableAdapter.Fill(this.midReportDataSet.StoreInfo);
            // TODO: 這行程式碼會將資料載入 'midReportDataSet.FoodInfo' 資料表。您可以視需要進行移動或移除。
            //this.foodInfoTableAdapter.Fill(this.midReportDataSet.FoodInfo);
            學lbl備註.Text = "1.請在10:30以前訂購完成\n2.訂購完成後請繳錢給值日生\n3.今天的值日生是:" + str接收的字串.ToString();
        }

        public void 學lbl備註_Click(object sender, EventArgs e)
        {
            


        }

        private void 學btn匯入資料庫_Click(object sender, EventArgs e)
        {

        }

        private void 學btn匯出資料庫_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void 學btn訂購_Click(object sender, EventArgs e)
        {

        }

        private void 學btn取消_Click(object sender, EventArgs e)
        {

        }

        private void 學btn送出訂單_Click(object sender, EventArgs e)
        {

        }

        private void foodInfoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.foodInfoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.midReportDataSet);

        }

        private void 學lbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void 學lbl學生_Click(object sender, EventArgs e)
        {

        }

        private void 學lbl姓名_Click(object sender, EventArgs e)
        {

        }

        private void 學lbl電話_Click(object sender, EventArgs e)
        {

        }

        private void 學lbl訂購便當_Click(object sender, EventArgs e)
        {

        }

        private void 學lbl便當價格_Click(object sender, EventArgs e)
        {

        }

        private void 學lbl便當價格顯示_Click(object sender, EventArgs e)
        {

        }

        private void 學lbl訂購便當輸出_Click(object sender, EventArgs e)
        {

        }

        private void 學tb電話_TextChanged(object sender, EventArgs e)
        {

        }

        private void 學tb姓名_TextChanged(object sender, EventArgs e)
        {

        }

        private void 學tb學生班級_TextChanged(object sender, EventArgs e)
        {

        }

        private void 學tb訂購單_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void 學lbl總價_Click(object sender, EventArgs e)
        {

        }

        private void 學lbl總價輸出_Click(object sender, EventArgs e)
        {

        }

        private void 學lbl便當總數輸出_Click(object sender, EventArgs e)
        {

        }

        private void 學lbl便當總數_Click(object sender, EventArgs e)
        {

        }
    }
}
