namespace 期中
{
    partial class Form便當菜
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb價錢 = new System.Windows.Forms.TextBox();
            this.tb便當名 = new System.Windows.Forms.TextBox();
            this.lbl價錢 = new System.Windows.Forms.Label();
            this.lbl便當名 = new System.Windows.Forms.Label();
            this.lbl店家名 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btn新增 = new System.Windows.Forms.Button();
            this.btn修改 = new System.Windows.Forms.Button();
            this.btn刪除 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb價錢
            // 
            this.tb價錢.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb價錢.Location = new System.Drawing.Point(229, 32);
            this.tb價錢.Name = "tb價錢";
            this.tb價錢.Size = new System.Drawing.Size(75, 29);
            this.tb價錢.TabIndex = 11;
            // 
            // tb便當名
            // 
            this.tb便當名.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb便當名.Location = new System.Drawing.Point(12, 32);
            this.tb便當名.Name = "tb便當名";
            this.tb便當名.Size = new System.Drawing.Size(199, 29);
            this.tb便當名.TabIndex = 10;
            // 
            // lbl價錢
            // 
            this.lbl價錢.AutoSize = true;
            this.lbl價錢.BackColor = System.Drawing.Color.White;
            this.lbl價錢.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl價錢.Location = new System.Drawing.Point(228, 9);
            this.lbl價錢.Name = "lbl價錢";
            this.lbl價錢.Size = new System.Drawing.Size(45, 20);
            this.lbl價錢.TabIndex = 9;
            this.lbl價錢.Text = "價錢:";
            // 
            // lbl便當名
            // 
            this.lbl便當名.AutoSize = true;
            this.lbl便當名.BackColor = System.Drawing.Color.White;
            this.lbl便當名.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl便當名.Location = new System.Drawing.Point(12, 9);
            this.lbl便當名.Name = "lbl便當名";
            this.lbl便當名.Size = new System.Drawing.Size(61, 20);
            this.lbl便當名.TabIndex = 8;
            this.lbl便當名.Text = "便當名:";
            // 
            // lbl店家名
            // 
            this.lbl店家名.AutoSize = true;
            this.lbl店家名.BackColor = System.Drawing.Color.White;
            this.lbl店家名.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl店家名.Location = new System.Drawing.Point(310, 20);
            this.lbl店家名.Name = "lbl店家名";
            this.lbl店家名.Size = new System.Drawing.Size(57, 20);
            this.lbl店家名.TabIndex = 7;
            this.lbl店家名.Text = "店家名";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(12, 67);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(213, 264);
            this.listBox1.TabIndex = 6;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBox2
            // 
            this.listBox2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.HorizontalScrollbar = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Location = new System.Drawing.Point(225, 67);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(96, 264);
            this.listBox2.TabIndex = 12;
            // 
            // btn新增
            // 
            this.btn新增.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn新增.Location = new System.Drawing.Point(345, 78);
            this.btn新增.Name = "btn新增";
            this.btn新增.Size = new System.Drawing.Size(94, 45);
            this.btn新增.TabIndex = 13;
            this.btn新增.Text = "新增";
            this.btn新增.UseVisualStyleBackColor = true;
            this.btn新增.Click += new System.EventHandler(this.btn新增_Click);
            // 
            // btn修改
            // 
            this.btn修改.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn修改.Location = new System.Drawing.Point(345, 164);
            this.btn修改.Name = "btn修改";
            this.btn修改.Size = new System.Drawing.Size(94, 45);
            this.btn修改.TabIndex = 14;
            this.btn修改.Text = "修改";
            this.btn修改.UseVisualStyleBackColor = true;
            this.btn修改.Click += new System.EventHandler(this.btn修改_Click);
            // 
            // btn刪除
            // 
            this.btn刪除.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn刪除.Location = new System.Drawing.Point(345, 259);
            this.btn刪除.Name = "btn刪除";
            this.btn刪除.Size = new System.Drawing.Size(94, 45);
            this.btn刪除.TabIndex = 15;
            this.btn刪除.Text = "刪除";
            this.btn刪除.UseVisualStyleBackColor = true;
            this.btn刪除.Click += new System.EventHandler(this.btn刪除_Click);
            // 
            // Form便當菜
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 347);
            this.Controls.Add(this.btn刪除);
            this.Controls.Add(this.btn修改);
            this.Controls.Add(this.btn新增);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.tb價錢);
            this.Controls.Add(this.tb便當名);
            this.Controls.Add(this.lbl價錢);
            this.Controls.Add(this.lbl便當名);
            this.Controls.Add(this.lbl店家名);
            this.Controls.Add(this.listBox1);
            this.Name = "Form便當菜";
            this.Text = "Form便當菜";
            this.Load += new System.EventHandler(this.Form便當菜_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb價錢;
        private System.Windows.Forms.TextBox tb便當名;
        private System.Windows.Forms.Label lbl價錢;
        private System.Windows.Forms.Label lbl便當名;
        private System.Windows.Forms.Label lbl店家名;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btn新增;
        private System.Windows.Forms.Button btn修改;
        private System.Windows.Forms.Button btn刪除;
    }
}