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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void F1btn值日生_Click(object sender, EventArgs e)
        {
            Form值日生輸入資料 myform值日生輸入資料 = new Form值日生輸入資料();
            //myform值日生輸入資料.Visible = true;
            myform值日生輸入資料.ShowDialog();
        }

        private void F1btn櫃台_Click(object sender, EventArgs e)
        {
            Form櫃台端 myform櫃台端 = new Form櫃台端();
            myform櫃台端.ShowDialog();
        }

        private void F1btn學生_Click(object sender, EventArgs e)
        {
            Form學生端 myform學生端 = new Form學生端();
            myform學生端.ShowDialog();
        }
    }
}
