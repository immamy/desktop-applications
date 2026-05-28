namespace WindowsFormsApp_OrderFood
{
    partial class Order
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
            this.listView_Booking = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comboBox_Type = new System.Windows.Forms.ComboBox();
            this.comboBox_AddType = new System.Windows.Forms.ComboBox();
            this.comboBox_AddName = new System.Windows.Forms.ComboBox();
            this.button_Submit = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            this.button_Remove = new System.Windows.Forms.Button();
            this.button_Increase = new System.Windows.Forms.Button();
            this.button_Reduce = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_TotalPrice = new System.Windows.Forms.Label();
            this.textBox_TableNum = new System.Windows.Forms.TextBox();
            this.textBox_Count = new System.Windows.Forms.TextBox();
            this.listView_Menu = new System.Windows.Forms.ListView();
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label_UnitPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView_Booking
            // 
            this.listView_Booking.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.listView_Booking.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F);
            this.listView_Booking.FullRowSelect = true;
            this.listView_Booking.HideSelection = false;
            this.listView_Booking.Location = new System.Drawing.Point(746, 520);
            this.listView_Booking.Name = "listView_Booking";
            this.listView_Booking.Size = new System.Drawing.Size(701, 265);
            this.listView_Booking.TabIndex = 1;
            this.listView_Booking.UseCompatibleStateImageBehavior = false;
            this.listView_Booking.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "類別";
            this.columnHeader1.Width = 110;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "商品名稱";
            this.columnHeader2.Width = 260;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "商品編號";
            this.columnHeader3.Width = 0;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "商品售價";
            this.columnHeader4.Width = 0;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "數量";
            this.columnHeader5.Width = 80;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "桌號";
            this.columnHeader6.Width = 0;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "訂單編號";
            this.columnHeader7.Width = 0;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "已訂餐";
            this.columnHeader8.Width = 0;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "日期";
            this.columnHeader9.Width = 0;
            // 
            // comboBox_Type
            // 
            this.comboBox_Type.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F);
            this.comboBox_Type.FormattingEnabled = true;
            this.comboBox_Type.Location = new System.Drawing.Point(12, 65);
            this.comboBox_Type.Name = "comboBox_Type";
            this.comboBox_Type.Size = new System.Drawing.Size(182, 44);
            this.comboBox_Type.TabIndex = 2;
            this.comboBox_Type.SelectedIndexChanged += new System.EventHandler(this.comboBox_Type_SelectedIndexChanged);
            // 
            // comboBox_AddType
            // 
            this.comboBox_AddType.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F);
            this.comboBox_AddType.FormattingEnabled = true;
            this.comboBox_AddType.Location = new System.Drawing.Point(1062, 173);
            this.comboBox_AddType.Name = "comboBox_AddType";
            this.comboBox_AddType.Size = new System.Drawing.Size(182, 44);
            this.comboBox_AddType.TabIndex = 2;
            this.comboBox_AddType.SelectedIndexChanged += new System.EventHandler(this.comboBox_AddType_SelectedIndexChanged);
            // 
            // comboBox_AddName
            // 
            this.comboBox_AddName.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F);
            this.comboBox_AddName.FormattingEnabled = true;
            this.comboBox_AddName.Location = new System.Drawing.Point(1062, 231);
            this.comboBox_AddName.Name = "comboBox_AddName";
            this.comboBox_AddName.Size = new System.Drawing.Size(182, 44);
            this.comboBox_AddName.TabIndex = 2;
            this.comboBox_AddName.SelectedIndexChanged += new System.EventHandler(this.comboBox_AddName_SelectedIndexChanged);
            // 
            // button_Submit
            // 
            this.button_Submit.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20F);
            this.button_Submit.Location = new System.Drawing.Point(746, 411);
            this.button_Submit.Name = "button_Submit";
            this.button_Submit.Size = new System.Drawing.Size(200, 100);
            this.button_Submit.TabIndex = 3;
            this.button_Submit.Text = "送出訂單";
            this.button_Submit.UseVisualStyleBackColor = true;
            this.button_Submit.Click += new System.EventHandler(this.button_Submit_Click);
            this.button_Submit.MouseLeave += new System.EventHandler(this.button_Submit_Mouse_Leave);
            this.button_Submit.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button_Submit_Mouse_Move);
            // 
            // button_Add
            // 
            this.button_Add.Font = new System.Drawing.Font("Microsoft JhengHei UI", 16F);
            this.button_Add.Location = new System.Drawing.Point(1062, 352);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(124, 62);
            this.button_Add.TabIndex = 3;
            this.button_Add.Text = "加入";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            this.button_Add.MouseLeave += new System.EventHandler(this.button_Add_Mouse_Leave);
            this.button_Add.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button_Add_Mouse_Move);
            // 
            // button_Remove
            // 
            this.button_Remove.Font = new System.Drawing.Font("Microsoft JhengHei UI", 16F);
            this.button_Remove.Location = new System.Drawing.Point(1192, 352);
            this.button_Remove.Name = "button_Remove";
            this.button_Remove.Size = new System.Drawing.Size(129, 62);
            this.button_Remove.TabIndex = 3;
            this.button_Remove.Text = "移除列";
            this.button_Remove.UseVisualStyleBackColor = true;
            this.button_Remove.Click += new System.EventHandler(this.button_Remove_Click);
            this.button_Remove.MouseLeave += new System.EventHandler(this.button_Remove_Mouse_Leave);
            this.button_Remove.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button_Remove_Mouse_Move);
            // 
            // button_Increase
            // 
            this.button_Increase.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F);
            this.button_Increase.Location = new System.Drawing.Point(1168, 292);
            this.button_Increase.Name = "button_Increase";
            this.button_Increase.Size = new System.Drawing.Size(43, 43);
            this.button_Increase.TabIndex = 3;
            this.button_Increase.Text = "+";
            this.button_Increase.UseVisualStyleBackColor = true;
            this.button_Increase.Click += new System.EventHandler(this.button_Increase_Click);
            this.button_Increase.MouseLeave += new System.EventHandler(this.button_Increase_Mouse_Leave);
            this.button_Increase.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button_Increase_Mouse_Move);
            // 
            // button_Reduce
            // 
            this.button_Reduce.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F);
            this.button_Reduce.Location = new System.Drawing.Point(1217, 292);
            this.button_Reduce.Name = "button_Reduce";
            this.button_Reduce.Size = new System.Drawing.Size(48, 43);
            this.button_Reduce.TabIndex = 3;
            this.button_Reduce.Text = "-";
            this.button_Reduce.UseVisualStyleBackColor = true;
            this.button_Reduce.Click += new System.EventHandler(this.button_Reduce_Click);
            this.button_Reduce.MouseLeave += new System.EventHandler(this.button_Reduce_Mouse_Leave);
            this.button_Reduce.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button_Reduce_Mouse_Move);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 16F);
            this.label1.Location = new System.Drawing.Point(1192, 470);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 41);
            this.label1.TabIndex = 4;
            this.label1.Text = "總金額：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 16F);
            this.label2.Location = new System.Drawing.Point(877, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 41);
            this.label2.TabIndex = 4;
            this.label2.Text = "桌號 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 16F);
            this.label3.Location = new System.Drawing.Point(877, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 41);
            this.label3.TabIndex = 4;
            this.label3.Text = "類別：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei UI", 16F);
            this.label4.Location = new System.Drawing.Point(877, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 41);
            this.label4.TabIndex = 4;
            this.label4.Text = "商品名稱：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei UI", 16F);
            this.label5.Location = new System.Drawing.Point(877, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 41);
            this.label5.TabIndex = 4;
            this.label5.Text = "數量：";
            // 
            // label_TotalPrice
            // 
            this.label_TotalPrice.AutoSize = true;
            this.label_TotalPrice.Font = new System.Drawing.Font("Microsoft JhengHei UI", 16F);
            this.label_TotalPrice.Location = new System.Drawing.Point(1337, 470);
            this.label_TotalPrice.Name = "label_TotalPrice";
            this.label_TotalPrice.Size = new System.Drawing.Size(37, 41);
            this.label_TotalPrice.TabIndex = 4;
            this.label_TotalPrice.Text = "0";
            // 
            // textBox_TableNum
            // 
            this.textBox_TableNum.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F);
            this.textBox_TableNum.Location = new System.Drawing.Point(1062, 118);
            this.textBox_TableNum.Name = "textBox_TableNum";
            this.textBox_TableNum.Size = new System.Drawing.Size(89, 43);
            this.textBox_TableNum.TabIndex = 5;
            // 
            // textBox_Count
            // 
            this.textBox_Count.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F);
            this.textBox_Count.Location = new System.Drawing.Point(1062, 292);
            this.textBox_Count.Name = "textBox_Count";
            this.textBox_Count.Size = new System.Drawing.Size(89, 43);
            this.textBox_Count.TabIndex = 6;
            this.textBox_Count.TextChanged += new System.EventHandler(this.textBox_Count_TextChanged);
            // 
            // listView_Menu
            // 
            this.listView_Menu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13});
            this.listView_Menu.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F);
            this.listView_Menu.FullRowSelect = true;
            this.listView_Menu.HideSelection = false;
            this.listView_Menu.Location = new System.Drawing.Point(12, 115);
            this.listView_Menu.Name = "listView_Menu";
            this.listView_Menu.Size = new System.Drawing.Size(702, 670);
            this.listView_Menu.TabIndex = 0;
            this.listView_Menu.UseCompatibleStateImageBehavior = false;
            this.listView_Menu.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "類別";
            this.columnHeader10.Width = 110;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "商品名稱";
            this.columnHeader11.Width = 260;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "商品編號";
            this.columnHeader12.Width = 0;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "商品售價";
            this.columnHeader13.Width = 125;
            // 
            // label_UnitPrice
            // 
            this.label_UnitPrice.AutoSize = true;
            this.label_UnitPrice.Font = new System.Drawing.Font("Microsoft JhengHei UI", 16F);
            this.label_UnitPrice.Location = new System.Drawing.Point(1277, 248);
            this.label_UnitPrice.Name = "label_UnitPrice";
            this.label_UnitPrice.Size = new System.Drawing.Size(0, 41);
            this.label_UnitPrice.TabIndex = 4;
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1459, 797);
            this.Controls.Add(this.textBox_Count);
            this.Controls.Add(this.textBox_TableNum);
            this.Controls.Add(this.label_TotalPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_UnitPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Reduce);
            this.Controls.Add(this.button_Increase);
            this.Controls.Add(this.button_Remove);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.button_Submit);
            this.Controls.Add(this.comboBox_AddName);
            this.Controls.Add(this.comboBox_AddType);
            this.Controls.Add(this.comboBox_Type);
            this.Controls.Add(this.listView_Menu);
            this.Controls.Add(this.listView_Booking);
            this.Name = "Order";
            this.Text = "Order";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView listView_Booking;
        private System.Windows.Forms.ComboBox comboBox_Type;
        private System.Windows.Forms.ComboBox comboBox_AddType;
        private System.Windows.Forms.ComboBox comboBox_AddName;
        private System.Windows.Forms.Button button_Submit;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button_Remove;
        private System.Windows.Forms.Button button_Increase;
        private System.Windows.Forms.Button button_Reduce;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_TotalPrice;
        private System.Windows.Forms.TextBox textBox_TableNum;
        private System.Windows.Forms.TextBox textBox_Count;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ListView listView_Menu;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.Label label_UnitPrice;
    }
}