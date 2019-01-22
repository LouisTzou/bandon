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
    public partial class Form1 : Form
    {
        Form櫃台端 myform櫃台端 = new Form櫃台端();
        Form值日生輸入 myform值日生輸入 = new Form值日生輸入();
        Form學生端 myform學生端 = new Form學生端();
        Form值日生端 myform值日生端 = new Form值日生端();
        public Form1()
        {
            InitializeComponent();            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DialogResult r;

            r= MessageBox.Show("肚子餓了吧!!!");
            myform櫃台端.Show();
            myform學生端.Show();
            if (r == DialogResult.OK)
            {
                myform櫃台端.WindowState = FormWindowState.Minimized;
                myform學生端.WindowState = FormWindowState.Minimized;
            }            
        }

        private void F1btn值日生_Click(object sender, EventArgs e)
        {
            this.Hide();
            //myform值日生輸入資料.Visible = true;
            myform值日生輸入.ShowDialog();
        }

        private void F1btn櫃台_Click(object sender, EventArgs e)
        {

            myform櫃台端.WindowState = FormWindowState.Normal;
        }

        private void F1btn學生_Click(object sender, EventArgs e)
        {

            myform櫃台端.WindowState = FormWindowState.Normal;
        }
    }
}
