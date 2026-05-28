namespace WinFormsApp_OrderFood
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
            listView_Menu = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            listView_Booking = new ListView();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            columnHeader12 = new ColumnHeader();
            columnHeader14 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader15 = new ColumnHeader();
            columnHeader13 = new ColumnHeader();
            comboBox_Type = new ComboBox();
            label1 = new Label();
            label_TotalPrice = new Label();
            button_Submit = new Button();
            label2 = new Label();
            textBox_TableNum = new TextBox();
            comboBox_AddType = new ComboBox();
            comboBox_AddName = new ComboBox();
            button_Increase = new Button();
            button_Reduce = new Button();
            button_Add = new Button();
            button_Remove = new Button();
            textBox_Count = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label_UnitPrice = new Label();
            SuspendLayout();
            // 
            // listView_Menu
            // 
            listView_Menu.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listView_Menu.Font = new Font("Microsoft JhengHei UI", 14F);
            listView_Menu.FullRowSelect = true;
            listView_Menu.Location = new Point(12, 115);
            listView_Menu.Name = "listView_Menu";
            listView_Menu.Size = new Size(702, 670);
            listView_Menu.TabIndex = 0;
            listView_Menu.UseCompatibleStateImageBehavior = false;
            listView_Menu.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "類別";
            columnHeader1.Width = 170;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "商品名稱";
            columnHeader2.Width = 360;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "商品編號";
            columnHeader3.Width = 0;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "商品售價";
            columnHeader4.Width = 130;
            // 
            // listView_Booking
            // 
            listView_Booking.Columns.AddRange(new ColumnHeader[] { columnHeader8, columnHeader9, columnHeader10, columnHeader11, columnHeader12, columnHeader14, columnHeader5, columnHeader15, columnHeader13 });
            listView_Booking.Font = new Font("Microsoft JhengHei UI", 14F);
            listView_Booking.FullRowSelect = true;
            listView_Booking.Location = new Point(746, 520);
            listView_Booking.Name = "listView_Booking";
            listView_Booking.Size = new Size(701, 265);
            listView_Booking.TabIndex = 1;
            listView_Booking.UseCompatibleStateImageBehavior = false;
            listView_Booking.View = View.Details;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "類別";
            columnHeader8.Width = 170;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "商品名稱";
            columnHeader9.Width = 360;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "商品編號";
            columnHeader10.Width = 0;
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "商品售價";
            columnHeader11.Width = 0;
            // 
            // columnHeader12
            // 
            columnHeader12.Text = "數量";
            columnHeader12.Width = 80;
            // 
            // columnHeader14
            // 
            columnHeader14.Text = "桌號";
            columnHeader14.Width = 0;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "訂單編號";
            columnHeader5.Width = 0;
            // 
            // columnHeader15
            // 
            columnHeader15.Text = "已訂餐";
            columnHeader15.Width = 0;
            // 
            // columnHeader13
            // 
            columnHeader13.Text = "日期";
            columnHeader13.Width = 0;
            // 
            // comboBox_Type
            // 
            comboBox_Type.Font = new Font("Microsoft JhengHei UI", 14F);
            comboBox_Type.FormattingEnabled = true;
            comboBox_Type.Location = new Point(12, 65);
            comboBox_Type.Name = "comboBox_Type";
            comboBox_Type.Size = new Size(182, 44);
            comboBox_Type.TabIndex = 2;
            comboBox_Type.SelectedIndexChanged += comboBox_Type_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 16F);
            label1.Location = new Point(1192, 470);
            label1.Name = "label1";
            label1.Size = new Size(146, 41);
            label1.TabIndex = 3;
            label1.Text = "總金額：";
            // 
            // label_TotalPrice
            // 
            label_TotalPrice.AutoSize = true;
            label_TotalPrice.Font = new Font("Microsoft JhengHei UI", 16F);
            label_TotalPrice.Location = new Point(1331, 470);
            label_TotalPrice.Name = "label_TotalPrice";
            label_TotalPrice.Size = new Size(37, 41);
            label_TotalPrice.TabIndex = 3;
            label_TotalPrice.Text = "0";
            // 
            // button_Submit
            // 
            button_Submit.Font = new Font("Microsoft JhengHei UI", 20F);
            button_Submit.Location = new Point(746, 411);
            button_Submit.Name = "button_Submit";
            button_Submit.Size = new Size(200, 100);
            button_Submit.TabIndex = 4;
            button_Submit.Text = "送出訂單";
            button_Submit.UseVisualStyleBackColor = true;
            button_Submit.Click += button_Submit_Click;
            button_Submit.MouseLeave += button_Submit_Mouse_Leave;
            button_Submit.MouseMove += button_Submit_Mouse_Move;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 16F);
            label2.Location = new Point(877, 120);
            label2.Name = "label2";
            label2.Size = new Size(114, 41);
            label2.TabIndex = 3;
            label2.Text = "桌號：";
            // 
            // textBox_TableNum
            // 
            textBox_TableNum.Font = new Font("Microsoft JhengHei UI", 14F);
            textBox_TableNum.Location = new Point(1062, 118);
            textBox_TableNum.Name = "textBox_TableNum";
            textBox_TableNum.Size = new Size(89, 43);
            textBox_TableNum.TabIndex = 5;
            // 
            // comboBox_AddType
            // 
            comboBox_AddType.Font = new Font("Microsoft JhengHei UI", 14F);
            comboBox_AddType.FormattingEnabled = true;
            comboBox_AddType.Location = new Point(1062, 173);
            comboBox_AddType.Name = "comboBox_AddType";
            comboBox_AddType.Size = new Size(182, 44);
            comboBox_AddType.TabIndex = 2;
            comboBox_AddType.SelectedIndexChanged += comboBox_AddType_SelectedIndexChanged;
            // 
            // comboBox_AddName
            // 
            comboBox_AddName.Font = new Font("Microsoft JhengHei UI", 14F);
            comboBox_AddName.FormattingEnabled = true;
            comboBox_AddName.Location = new Point(1062, 231);
            comboBox_AddName.Name = "comboBox_AddName";
            comboBox_AddName.Size = new Size(182, 44);
            comboBox_AddName.TabIndex = 2;
            comboBox_AddName.SelectedIndexChanged += comboBox_AddName_SelectedIndexChanged;
            // 
            // button_Increase
            // 
            button_Increase.Font = new Font("Microsoft JhengHei UI", 14F);
            button_Increase.Location = new Point(1168, 292);
            button_Increase.Name = "button_Increase";
            button_Increase.Size = new Size(43, 43);
            button_Increase.TabIndex = 6;
            button_Increase.Text = "+";
            button_Increase.UseVisualStyleBackColor = true;
            button_Increase.Click += button_Increase_Click;
            button_Increase.MouseLeave += button_Increase_Mouse_Leave;
            button_Increase.MouseMove += button_Increase_Mouse_Move;
            // 
            // button_Reduce
            // 
            button_Reduce.Font = new Font("Microsoft JhengHei UI", 14F);
            button_Reduce.Location = new Point(1217, 292);
            button_Reduce.Name = "button_Reduce";
            button_Reduce.Size = new Size(48, 43);
            button_Reduce.TabIndex = 6;
            button_Reduce.Text = "-";
            button_Reduce.UseVisualStyleBackColor = true;
            button_Reduce.Click += button_Reduce_Click;
            button_Reduce.MouseLeave += button_Reduce_Mouse_Leave;
            button_Reduce.MouseMove += button_Reduce_Mouse_Move;
            // 
            // button_Add
            // 
            button_Add.Font = new Font("Microsoft JhengHei UI", 16F);
            button_Add.Location = new Point(1062, 352);
            button_Add.Name = "button_Add";
            button_Add.Size = new Size(124, 62);
            button_Add.TabIndex = 6;
            button_Add.Text = "加入";
            button_Add.UseVisualStyleBackColor = true;
            button_Add.Click += button_Add_Click;
            button_Add.MouseLeave += button_Add_Mouse_Leave;
            button_Add.MouseMove += button_Add_Mouse_Move;
            // 
            // button_Remove
            // 
            button_Remove.Font = new Font("Microsoft JhengHei UI", 16F);
            button_Remove.Location = new Point(1192, 352);
            button_Remove.Name = "button_Remove";
            button_Remove.Size = new Size(129, 62);
            button_Remove.TabIndex = 6;
            button_Remove.Text = "移除列";
            button_Remove.UseVisualStyleBackColor = true;
            button_Remove.Click += button_Remove_Click;
            button_Remove.MouseLeave += button_Remove_Mouse_Leave;
            button_Remove.MouseMove += button_Remove_Mouse_Move;
            // 
            // textBox_Count
            // 
            textBox_Count.Font = new Font("Microsoft JhengHei UI", 14F);
            textBox_Count.Location = new Point(1062, 292);
            textBox_Count.Name = "textBox_Count";
            textBox_Count.Size = new Size(89, 43);
            textBox_Count.TabIndex = 5;
            textBox_Count.TextChanged += textBox_Count_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 16F);
            label3.Location = new Point(877, 176);
            label3.Name = "label3";
            label3.Size = new Size(114, 41);
            label3.TabIndex = 3;
            label3.Text = "類別：";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft JhengHei UI", 16F);
            label4.Location = new Point(877, 234);
            label4.Name = "label4";
            label4.Size = new Size(178, 41);
            label4.TabIndex = 3;
            label4.Text = "商品名稱：";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft JhengHei UI", 16F);
            label5.Location = new Point(877, 294);
            label5.Name = "label5";
            label5.Size = new Size(114, 41);
            label5.TabIndex = 3;
            label5.Text = "數量：";
            // 
            // label_UnitPrice
            // 
            label_UnitPrice.AutoSize = true;
            label_UnitPrice.Location = new Point(1277, 248);
            label_UnitPrice.Name = "label_UnitPrice";
            label_UnitPrice.Size = new Size(0, 23);
            label_UnitPrice.TabIndex = 7;
            // 
            // Order
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1459, 797);
            Controls.Add(label_UnitPrice);
            Controls.Add(button_Remove);
            Controls.Add(button_Add);
            Controls.Add(button_Reduce);
            Controls.Add(button_Increase);
            Controls.Add(textBox_Count);
            Controls.Add(textBox_TableNum);
            Controls.Add(button_Submit);
            Controls.Add(label_TotalPrice);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox_AddName);
            Controls.Add(comboBox_AddType);
            Controls.Add(comboBox_Type);
            Controls.Add(listView_Booking);
            Controls.Add(listView_Menu);
            Name = "Order";
            Text = "Order";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView_Menu;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ListView listView_Booking;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader12;
        private ComboBox comboBox_Type;
        private Label label1;
        private Label label_TotalPrice;
        private ColumnHeader columnHeader10;
        private Button button_Submit;
        private ColumnHeader columnHeader13;
        private Label label2;
        private TextBox textBox_TableNum;
        private ColumnHeader columnHeader14;
        private ColumnHeader columnHeader15;
        private ComboBox comboBox_AddType;
        private ComboBox comboBox_AddName;
        private Button button_Increase;
        private Button button_Reduce;
        private Button button_Add;
        private Button button_Remove;
        private TextBox textBox_Count;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label_UnitPrice;
        private ColumnHeader columnHeader5;
    }
}