namespace WindowsFormsApp2
{
    partial class Form學生端
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form學生端));
            this.學lbl總價輸出 = new System.Windows.Forms.Label();
            this.學lbl便當總數輸出 = new System.Windows.Forms.Label();
            this.學lbl備註 = new System.Windows.Forms.Label();
            this.學btn訂購 = new System.Windows.Forms.Button();
            this.學btn取消 = new System.Windows.Forms.Button();
            this.學btn匯出資料庫 = new System.Windows.Forms.Button();
            this.學btn匯入資料庫 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.學tb電話 = new System.Windows.Forms.TextBox();
            this.學tb學生班級 = new System.Windows.Forms.TextBox();
            this.學tb姓名 = new System.Windows.Forms.TextBox();
            this.學tb訂購單 = new System.Windows.Forms.TextBox();
            this.學lbl訂購便當 = new System.Windows.Forms.Label();
            this.學lbl電話 = new System.Windows.Forms.Label();
            this.學lbl總價 = new System.Windows.Forms.Label();
            this.學lbl便當總數 = new System.Windows.Forms.Label();
            this.學btn送出訂單 = new System.Windows.Forms.Button();
            this.學lbl姓名 = new System.Windows.Forms.Label();
            this.學lbl學生 = new System.Windows.Forms.Label();
            this.學lbox = new System.Windows.Forms.ListBox();
            this.foodInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.midReportDataSet = new WindowsFormsApp2.MidReportDataSet();
            this.foodInfoTableAdapter = new WindowsFormsApp2.MidReportDataSetTableAdapters.FoodInfoTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp2.MidReportDataSetTableAdapters.TableAdapterManager();
            this.storeInfoTableAdapter = new WindowsFormsApp2.MidReportDataSetTableAdapters.StoreInfoTableAdapter();
            this.foodInfoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.foodInfoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.foodInfoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKStoreInfoFoodInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fKStoreInfoFoodInfoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fKStoreInfoFoodInfoBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.學lbl便當價格 = new System.Windows.Forms.Label();
            this.學lbl便當價格顯示 = new System.Windows.Forms.Label();
            this.學lbl訂購便當輸出 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.midReportDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodInfoBindingNavigator)).BeginInit();
            this.foodInfoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foodInfoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKStoreInfoFoodInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKStoreInfoFoodInfoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKStoreInfoFoodInfoBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // 學lbl總價輸出
            // 
            this.學lbl總價輸出.BackColor = System.Drawing.Color.White;
            this.學lbl總價輸出.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.學lbl總價輸出.Location = new System.Drawing.Point(821, 380);
            this.學lbl總價輸出.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.學lbl總價輸出.Name = "學lbl總價輸出";
            this.學lbl總價輸出.Size = new System.Drawing.Size(108, 31);
            this.學lbl總價輸出.TabIndex = 52;
            this.學lbl總價輸出.Click += new System.EventHandler(this.學lbl總價輸出_Click);
            // 
            // 學lbl便當總數輸出
            // 
            this.學lbl便當總數輸出.BackColor = System.Drawing.Color.White;
            this.學lbl便當總數輸出.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.學lbl便當總數輸出.Location = new System.Drawing.Point(821, 329);
            this.學lbl便當總數輸出.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.學lbl便當總數輸出.Name = "學lbl便當總數輸出";
            this.學lbl便當總數輸出.Size = new System.Drawing.Size(108, 31);
            this.學lbl便當總數輸出.TabIndex = 51;
            this.學lbl便當總數輸出.Click += new System.EventHandler(this.學lbl便當總數輸出_Click);
            // 
            // 學lbl備註
            // 
            this.學lbl備註.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.學lbl備註.Font = new System.Drawing.Font("新細明體", 12F);
            this.學lbl備註.ForeColor = System.Drawing.Color.White;
            this.學lbl備註.Location = new System.Drawing.Point(745, 207);
            this.學lbl備註.Name = "學lbl備註";
            this.學lbl備註.Size = new System.Drawing.Size(220, 83);
            this.學lbl備註.TabIndex = 50;
            this.學lbl備註.Text = "1.請在10:30以前訂購完成\r\n2.訂購完成後請繳錢給值日生\r\n3.今天的值日生是:";
            this.學lbl備註.Click += new System.EventHandler(this.學lbl備註_Click);
            // 
            // 學btn訂購
            // 
            this.學btn訂購.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.學btn訂購.Location = new System.Drawing.Point(6, 12);
            this.學btn訂購.Name = "學btn訂購";
            this.學btn訂購.Size = new System.Drawing.Size(160, 60);
            this.學btn訂購.TabIndex = 13;
            this.學btn訂購.Text = "訂購";
            this.學btn訂購.UseVisualStyleBackColor = true;
            this.學btn訂購.Click += new System.EventHandler(this.學btn訂購_Click);
            // 
            // 學btn取消
            // 
            this.學btn取消.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.學btn取消.Location = new System.Drawing.Point(172, 12);
            this.學btn取消.Name = "學btn取消";
            this.學btn取消.Size = new System.Drawing.Size(160, 60);
            this.學btn取消.TabIndex = 11;
            this.學btn取消.Text = "取消";
            this.學btn取消.UseVisualStyleBackColor = true;
            this.學btn取消.Click += new System.EventHandler(this.學btn取消_Click);
            // 
            // 學btn匯出資料庫
            // 
            this.學btn匯出資料庫.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.學btn匯出資料庫.Location = new System.Drawing.Point(562, 46);
            this.學btn匯出資料庫.Name = "學btn匯出資料庫";
            this.學btn匯出資料庫.Size = new System.Drawing.Size(161, 34);
            this.學btn匯出資料庫.TabIndex = 49;
            this.學btn匯出資料庫.Text = "匯出資料庫";
            this.學btn匯出資料庫.UseVisualStyleBackColor = true;
            this.學btn匯出資料庫.Click += new System.EventHandler(this.學btn匯出資料庫_Click);
            // 
            // 學btn匯入資料庫
            // 
            this.學btn匯入資料庫.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.學btn匯入資料庫.Location = new System.Drawing.Point(562, 12);
            this.學btn匯入資料庫.Name = "學btn匯入資料庫";
            this.學btn匯入資料庫.Size = new System.Drawing.Size(161, 34);
            this.學btn匯入資料庫.TabIndex = 48;
            this.學btn匯入資料庫.Text = "匯入資料庫";
            this.學btn匯入資料庫.UseVisualStyleBackColor = true;
            this.學btn匯入資料庫.Click += new System.EventHandler(this.學btn匯入資料庫_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.學btn訂購);
            this.groupBox1.Controls.Add(this.學btn取消);
            this.groupBox1.Location = new System.Drawing.Point(238, 442);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 78);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(562, 81);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(44, 22);
            this.numericUpDown1.TabIndex = 35;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // 學tb電話
            // 
            this.學tb電話.Location = new System.Drawing.Point(313, 58);
            this.學tb電話.Name = "學tb電話";
            this.學tb電話.Size = new System.Drawing.Size(243, 22);
            this.學tb電話.TabIndex = 38;
            this.學tb電話.TextChanged += new System.EventHandler(this.學tb電話_TextChanged);
            // 
            // 學tb學生班級
            // 
            this.學tb學生班級.Location = new System.Drawing.Point(313, 12);
            this.學tb學生班級.Name = "學tb學生班級";
            this.學tb學生班級.Size = new System.Drawing.Size(243, 22);
            this.學tb學生班級.TabIndex = 39;
            this.學tb學生班級.TextChanged += new System.EventHandler(this.學tb學生班級_TextChanged);
            // 
            // 學tb姓名
            // 
            this.學tb姓名.Location = new System.Drawing.Point(313, 35);
            this.學tb姓名.Name = "學tb姓名";
            this.學tb姓名.Size = new System.Drawing.Size(243, 22);
            this.學tb姓名.TabIndex = 42;
            this.學tb姓名.TextChanged += new System.EventHandler(this.學tb姓名_TextChanged);
            // 
            // 學tb訂購單
            // 
            this.學tb訂購單.Location = new System.Drawing.Point(238, 136);
            this.學tb訂購單.Multiline = true;
            this.學tb訂購單.Name = "學tb訂購單";
            this.學tb訂購單.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.學tb訂購單.Size = new System.Drawing.Size(497, 286);
            this.學tb訂購單.TabIndex = 43;
            this.學tb訂購單.TextChanged += new System.EventHandler(this.學tb訂購單_TextChanged);
            // 
            // 學lbl訂購便當
            // 
            this.學lbl訂購便當.AutoSize = true;
            this.學lbl訂購便當.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.學lbl訂購便當.Location = new System.Drawing.Point(240, 81);
            this.學lbl訂購便當.Name = "學lbl訂購便當";
            this.學lbl訂購便當.Size = new System.Drawing.Size(73, 20);
            this.學lbl訂購便當.TabIndex = 40;
            this.學lbl訂購便當.Text = "訂購便當";
            this.學lbl訂購便當.Click += new System.EventHandler(this.學lbl訂購便當_Click);
            // 
            // 學lbl電話
            // 
            this.學lbl電話.AutoSize = true;
            this.學lbl電話.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.學lbl電話.Location = new System.Drawing.Point(266, 60);
            this.學lbl電話.Name = "學lbl電話";
            this.學lbl電話.Size = new System.Drawing.Size(41, 20);
            this.學lbl電話.TabIndex = 41;
            this.學lbl電話.Text = "電話";
            this.學lbl電話.Click += new System.EventHandler(this.學lbl電話_Click);
            // 
            // 學lbl總價
            // 
            this.學lbl總價.AutoSize = true;
            this.學lbl總價.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.學lbl總價.Location = new System.Drawing.Point(773, 385);
            this.學lbl總價.Name = "學lbl總價";
            this.學lbl總價.Size = new System.Drawing.Size(41, 20);
            this.學lbl總價.TabIndex = 47;
            this.學lbl總價.Text = "總價";
            this.學lbl總價.Click += new System.EventHandler(this.學lbl總價_Click);
            // 
            // 學lbl便當總數
            // 
            this.學lbl便當總數.AutoSize = true;
            this.學lbl便當總數.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.學lbl便當總數.Location = new System.Drawing.Point(741, 334);
            this.學lbl便當總數.Name = "學lbl便當總數";
            this.學lbl便當總數.Size = new System.Drawing.Size(73, 20);
            this.學lbl便當總數.TabIndex = 46;
            this.學lbl便當總數.Text = "便當總數";
            this.學lbl便當總數.Click += new System.EventHandler(this.學lbl便當總數_Click);
            // 
            // 學btn送出訂單
            // 
            this.學btn送出訂單.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.學btn送出訂單.Location = new System.Drawing.Point(585, 454);
            this.學btn送出訂單.Name = "學btn送出訂單";
            this.學btn送出訂單.Size = new System.Drawing.Size(160, 60);
            this.學btn送出訂單.TabIndex = 44;
            this.學btn送出訂單.Text = "送出訂單";
            this.學btn送出訂單.UseVisualStyleBackColor = true;
            this.學btn送出訂單.Click += new System.EventHandler(this.學btn送出訂單_Click);
            // 
            // 學lbl姓名
            // 
            this.學lbl姓名.AutoSize = true;
            this.學lbl姓名.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.學lbl姓名.Location = new System.Drawing.Point(266, 37);
            this.學lbl姓名.Name = "學lbl姓名";
            this.學lbl姓名.Size = new System.Drawing.Size(41, 20);
            this.學lbl姓名.TabIndex = 37;
            this.學lbl姓名.Text = "姓名";
            this.學lbl姓名.Click += new System.EventHandler(this.學lbl姓名_Click);
            // 
            // 學lbl學生
            // 
            this.學lbl學生.AutoSize = true;
            this.學lbl學生.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.學lbl學生.Location = new System.Drawing.Point(234, 14);
            this.學lbl學生.Name = "學lbl學生";
            this.學lbl學生.Size = new System.Drawing.Size(73, 20);
            this.學lbl學生.TabIndex = 36;
            this.學lbl學生.Text = "學生班級";
            this.學lbl學生.Click += new System.EventHandler(this.學lbl學生_Click);
            // 
            // 學lbox
            // 
            this.學lbox.DataSource = this.foodInfoBindingSource;
            this.學lbox.DisplayMember = "FoodName";
            this.學lbox.Font = new System.Drawing.Font("新細明體", 16F);
            this.學lbox.FormattingEnabled = true;
            this.學lbox.ItemHeight = 21;
            this.學lbox.Location = new System.Drawing.Point(12, 12);
            this.學lbox.Name = "學lbox";
            this.學lbox.Size = new System.Drawing.Size(216, 508);
            this.學lbox.TabIndex = 33;
            this.學lbox.SelectedIndexChanged += new System.EventHandler(this.學lbox_SelectedIndexChanged);
            // 
            // foodInfoBindingSource
            // 
            this.foodInfoBindingSource.DataMember = "FoodInfo";
            this.foodInfoBindingSource.DataSource = this.midReportDataSet;
            // 
            // midReportDataSet
            // 
            this.midReportDataSet.DataSetName = "MidReportDataSet";
            this.midReportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // foodInfoTableAdapter
            // 
            this.foodInfoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.FoodInfoTableAdapter = this.foodInfoTableAdapter;
            this.tableAdapterManager.OrderListTableAdapter = null;
            this.tableAdapterManager.StoreInfoTableAdapter = this.storeInfoTableAdapter;
            this.tableAdapterManager.StudentInfoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp2.MidReportDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // storeInfoTableAdapter
            // 
            this.storeInfoTableAdapter.ClearBeforeFill = true;
            // 
            // foodInfoBindingNavigator
            // 
            this.foodInfoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.foodInfoBindingNavigator.BindingSource = this.foodInfoBindingSource;
            this.foodInfoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.foodInfoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.foodInfoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.foodInfoBindingNavigatorSaveItem});
            this.foodInfoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.foodInfoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.foodInfoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.foodInfoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.foodInfoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.foodInfoBindingNavigator.Name = "foodInfoBindingNavigator";
            this.foodInfoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.foodInfoBindingNavigator.Size = new System.Drawing.Size(976, 25);
            this.foodInfoBindingNavigator.TabIndex = 53;
            this.foodInfoBindingNavigator.Text = "bindingNavigator1";
            this.foodInfoBindingNavigator.Visible = false;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "加入新的";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(27, 22);
            this.bindingNavigatorCountItem.Text = "/{0}";
            this.bindingNavigatorCountItem.ToolTipText = "項目總數";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "刪除";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "移到最前面";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "移到上一個";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "目前的位置";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "移到下一個";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "移到最後面";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // foodInfoBindingNavigatorSaveItem
            // 
            this.foodInfoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.foodInfoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("foodInfoBindingNavigatorSaveItem.Image")));
            this.foodInfoBindingNavigatorSaveItem.Name = "foodInfoBindingNavigatorSaveItem";
            this.foodInfoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.foodInfoBindingNavigatorSaveItem.Text = "儲存資料";
            this.foodInfoBindingNavigatorSaveItem.Click += new System.EventHandler(this.foodInfoBindingNavigatorSaveItem_Click);
            // 
            // foodInfoDataGridView
            // 
            this.foodInfoDataGridView.AutoGenerateColumns = false;
            this.foodInfoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.foodInfoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.foodInfoDataGridView.DataSource = this.foodInfoBindingSource;
            this.foodInfoDataGridView.Location = new System.Drawing.Point(799, 42);
            this.foodInfoDataGridView.Name = "foodInfoDataGridView";
            this.foodInfoDataGridView.RowTemplate.Height = 24;
            this.foodInfoDataGridView.Size = new System.Drawing.Size(342, 134);
            this.foodInfoDataGridView.TabIndex = 53;
            this.foodInfoDataGridView.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "StoreName";
            this.dataGridViewTextBoxColumn1.HeaderText = "StoreName";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FoodName";
            this.dataGridViewTextBoxColumn2.HeaderText = "FoodName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn3.HeaderText = "Price";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // fKStoreInfoFoodInfoBindingSource
            // 
            this.fKStoreInfoFoodInfoBindingSource.DataMember = "FK_StoreInfo_FoodInfo";
            this.fKStoreInfoFoodInfoBindingSource.DataSource = this.foodInfoBindingSource;
            // 
            // fKStoreInfoFoodInfoBindingSource1
            // 
            this.fKStoreInfoFoodInfoBindingSource1.DataMember = "FK_StoreInfo_FoodInfo";
            this.fKStoreInfoFoodInfoBindingSource1.DataSource = this.foodInfoBindingSource;
            // 
            // fKStoreInfoFoodInfoBindingSource2
            // 
            this.fKStoreInfoFoodInfoBindingSource2.DataMember = "FK_StoreInfo_FoodInfo";
            this.fKStoreInfoFoodInfoBindingSource2.DataSource = this.foodInfoBindingSource;
            // 
            // 學lbl便當價格
            // 
            this.學lbl便當價格.AutoSize = true;
            this.學lbl便當價格.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.學lbl便當價格.Location = new System.Drawing.Point(240, 106);
            this.學lbl便當價格.Name = "學lbl便當價格";
            this.學lbl便當價格.Size = new System.Drawing.Size(73, 20);
            this.學lbl便當價格.TabIndex = 55;
            this.學lbl便當價格.Text = "便當價格";
            this.學lbl便當價格.Click += new System.EventHandler(this.學lbl便當價格_Click);
            // 
            // 學lbl便當價格顯示
            // 
            this.學lbl便當價格顯示.BackColor = System.Drawing.Color.White;
            this.學lbl便當價格顯示.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.foodInfoBindingSource, "Price", true));
            this.學lbl便當價格顯示.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.學lbl便當價格顯示.Location = new System.Drawing.Point(313, 106);
            this.學lbl便當價格顯示.Name = "學lbl便當價格顯示";
            this.學lbl便當價格顯示.Size = new System.Drawing.Size(73, 20);
            this.學lbl便當價格顯示.TabIndex = 56;
            this.學lbl便當價格顯示.Text = "0$";
            this.學lbl便當價格顯示.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.學lbl便當價格顯示.Click += new System.EventHandler(this.學lbl便當價格顯示_Click);
            // 
            // 學lbl訂購便當輸出
            // 
            this.學lbl訂購便當輸出.BackColor = System.Drawing.Color.White;
            this.學lbl訂購便當輸出.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.學lbl訂購便當輸出.Location = new System.Drawing.Point(313, 81);
            this.學lbl訂購便當輸出.Name = "學lbl訂購便當輸出";
            this.學lbl訂購便當輸出.Size = new System.Drawing.Size(243, 20);
            this.學lbl訂購便當輸出.TabIndex = 57;
            this.學lbl訂購便當輸出.Click += new System.EventHandler(this.學lbl訂購便當輸出_Click);
            // 
            // Form學生端
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 542);
            this.Controls.Add(this.學lbl訂購便當輸出);
            this.Controls.Add(this.學lbl便當價格顯示);
            this.Controls.Add(this.學lbl便當價格);
            this.Controls.Add(this.foodInfoDataGridView);
            this.Controls.Add(this.foodInfoBindingNavigator);
            this.Controls.Add(this.學lbl總價輸出);
            this.Controls.Add(this.學lbl便當總數輸出);
            this.Controls.Add(this.學lbl備註);
            this.Controls.Add(this.學btn匯出資料庫);
            this.Controls.Add(this.學btn匯入資料庫);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.學tb電話);
            this.Controls.Add(this.學tb學生班級);
            this.Controls.Add(this.學tb姓名);
            this.Controls.Add(this.學tb訂購單);
            this.Controls.Add(this.學lbl訂購便當);
            this.Controls.Add(this.學lbl電話);
            this.Controls.Add(this.學lbl總價);
            this.Controls.Add(this.學lbl便當總數);
            this.Controls.Add(this.學btn送出訂單);
            this.Controls.Add(this.學lbl姓名);
            this.Controls.Add(this.學lbl學生);
            this.Controls.Add(this.學lbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form學生端";
            this.Text = "Form學生端";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form學生端_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.midReportDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodInfoBindingNavigator)).EndInit();
            this.foodInfoBindingNavigator.ResumeLayout(false);
            this.foodInfoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foodInfoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKStoreInfoFoodInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKStoreInfoFoodInfoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKStoreInfoFoodInfoBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label 學lbl總價輸出;
        private System.Windows.Forms.Label 學lbl便當總數輸出;
        private System.Windows.Forms.Label 學lbl備註;
        private System.Windows.Forms.Button 學btn訂購;
        private System.Windows.Forms.Button 學btn取消;
        private System.Windows.Forms.Button 學btn匯出資料庫;
        private System.Windows.Forms.Button 學btn匯入資料庫;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox 學tb電話;
        private System.Windows.Forms.TextBox 學tb學生班級;
        private System.Windows.Forms.TextBox 學tb姓名;
        private System.Windows.Forms.TextBox 學tb訂購單;
        private System.Windows.Forms.Label 學lbl訂購便當;
        private System.Windows.Forms.Label 學lbl電話;
        private System.Windows.Forms.Label 學lbl總價;
        private System.Windows.Forms.Label 學lbl便當總數;
        private System.Windows.Forms.Button 學btn送出訂單;
        private System.Windows.Forms.Label 學lbl姓名;
        private System.Windows.Forms.Label 學lbl學生;
        private System.Windows.Forms.ListBox 學lbox;
        private MidReportDataSet midReportDataSet;
        private System.Windows.Forms.BindingSource foodInfoBindingSource;
        private MidReportDataSetTableAdapters.FoodInfoTableAdapter foodInfoTableAdapter;
        private MidReportDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator foodInfoBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton foodInfoBindingNavigatorSaveItem;
        private MidReportDataSetTableAdapters.StoreInfoTableAdapter storeInfoTableAdapter;
        private System.Windows.Forms.DataGridView foodInfoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.BindingSource fKStoreInfoFoodInfoBindingSource;
        private System.Windows.Forms.BindingSource fKStoreInfoFoodInfoBindingSource1;
        private System.Windows.Forms.BindingSource fKStoreInfoFoodInfoBindingSource2;
        private System.Windows.Forms.Label 學lbl便當價格;
        private System.Windows.Forms.Label 學lbl便當價格顯示;
        private System.Windows.Forms.Label 學lbl訂購便當輸出;
    }
}