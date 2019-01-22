namespace 期中
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.F1btn學生 = new System.Windows.Forms.Button();
            this.F1btn櫃台 = new System.Windows.Forms.Button();
            this.F1btn值日生 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // F1btn學生
            // 
            this.F1btn學生.Font = new System.Drawing.Font("微軟正黑體", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.F1btn學生.Location = new System.Drawing.Point(12, 246);
            this.F1btn學生.Name = "F1btn學生";
            this.F1btn學生.Size = new System.Drawing.Size(276, 111);
            this.F1btn學生.TabIndex = 15;
            this.F1btn學生.Text = "學生";
            this.F1btn學生.UseVisualStyleBackColor = true;
            this.F1btn學生.Click += new System.EventHandler(this.F1btn學生_Click);
            // 
            // F1btn櫃台
            // 
            this.F1btn櫃台.Font = new System.Drawing.Font("微軟正黑體", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.F1btn櫃台.Location = new System.Drawing.Point(12, 129);
            this.F1btn櫃台.Name = "F1btn櫃台";
            this.F1btn櫃台.Size = new System.Drawing.Size(276, 111);
            this.F1btn櫃台.TabIndex = 14;
            this.F1btn櫃台.Text = "櫃台";
            this.F1btn櫃台.UseVisualStyleBackColor = true;
            this.F1btn櫃台.Click += new System.EventHandler(this.F1btn櫃台_Click);
            // 
            // F1btn值日生
            // 
            this.F1btn值日生.Font = new System.Drawing.Font("微軟正黑體", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.F1btn值日生.Location = new System.Drawing.Point(12, 12);
            this.F1btn值日生.Name = "F1btn值日生";
            this.F1btn值日生.Size = new System.Drawing.Size(276, 111);
            this.F1btn值日生.TabIndex = 13;
            this.F1btn值日生.Text = "值日生";
            this.F1btn值日生.UseVisualStyleBackColor = true;
            this.F1btn值日生.Click += new System.EventHandler(this.F1btn值日生_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 368);
            this.Controls.Add(this.F1btn學生);
            this.Controls.Add(this.F1btn櫃台);
            this.Controls.Add(this.F1btn值日生);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button F1btn學生;
        private System.Windows.Forms.Button F1btn櫃台;
        private System.Windows.Forms.Button F1btn值日生;
    }
}

