namespace WinFormsApp_Meal_expense_accounting
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
            button_Submit = new Button();
            button_Clear = new Button();
            button_Add = new Button();
            textBox_Count = new TextBox();
            comboBox_Name = new ComboBox();
            comboBox_Department = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            comboBox_Product = new ComboBox();
            button_Remove = new Button();
            label11 = new Label();
            label12 = new Label();
            label_Restaurant = new Label();
            button_Menu = new Button();
            listView_Menu = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            listView_Order = new ListView();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            comboBox_Restaurant = new ComboBox();
            pictureBox_Menu = new PictureBox();
            label5 = new Label();
            label_Unit_Price = new Label();
            label6 = new Label();
            label_Total_Price = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Menu).BeginInit();
            SuspendLayout();
            // 
            // button_Submit
            // 
            button_Submit.Location = new Point(856, 598);
            button_Submit.Name = "button_Submit";
            button_Submit.Size = new Size(101, 34);
            button_Submit.TabIndex = 0;
            button_Submit.Text = "送出訂單";
            button_Submit.UseVisualStyleBackColor = true;
            button_Submit.Click += button_Submit_Click;
            button_Submit.MouseLeave += button_Submit_Mouse_Leave;
            button_Submit.MouseMove += button_Submit_Mouse_Move;
            // 
            // button_Clear
            // 
            button_Clear.Location = new Point(666, 548);
            button_Clear.Name = "button_Clear";
            button_Clear.Size = new Size(78, 34);
            button_Clear.TabIndex = 4;
            button_Clear.Text = "清除";
            button_Clear.UseVisualStyleBackColor = true;
            button_Clear.Click += button_Clear_Click;
            button_Clear.MouseLeave += button_Clear_Mouse_Leave;
            button_Clear.MouseMove += button_Clear_Mouse_Move;
            // 
            // button_Add
            // 
            button_Add.Location = new Point(582, 548);
            button_Add.Name = "button_Add";
            button_Add.Size = new Size(78, 34);
            button_Add.TabIndex = 5;
            button_Add.Text = "加入";
            button_Add.UseVisualStyleBackColor = true;
            button_Add.Click += button_Add_Click;
            button_Add.MouseLeave += button_Add_Mouse_Leave;
            button_Add.MouseMove += button_Add_Mouse_Move;
            // 
            // textBox_Count
            // 
            textBox_Count.Location = new Point(582, 512);
            textBox_Count.Name = "textBox_Count";
            textBox_Count.Size = new Size(150, 30);
            textBox_Count.TabIndex = 13;
            textBox_Count.TextChanged += textBox_Count_TextChanged;
            // 
            // comboBox_Name
            // 
            comboBox_Name.FormattingEnabled = true;
            comboBox_Name.Location = new Point(582, 438);
            comboBox_Name.Name = "comboBox_Name";
            comboBox_Name.Size = new Size(150, 31);
            comboBox_Name.TabIndex = 11;
            comboBox_Name.SelectedIndexChanged += comboBox_Name_SelectedIndexChanged;
            comboBox_Name.MouseMove += comboBox_Name_Mouse_Move;
            // 
            // comboBox_Department
            // 
            comboBox_Department.FormattingEnabled = true;
            comboBox_Department.Location = new Point(582, 400);
            comboBox_Department.Name = "comboBox_Department";
            comboBox_Department.Size = new Size(150, 31);
            comboBox_Department.TabIndex = 12;
            comboBox_Department.SelectedIndexChanged += comboBox_Department_SelectedIndexChanged;
            comboBox_Department.MouseMove += comboBox_Department_Mouse_Move;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(512, 515);
            label3.Name = "label3";
            label3.Size = new Size(64, 23);
            label3.TabIndex = 8;
            label3.Text = "數量：";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(512, 441);
            label2.Name = "label2";
            label2.Size = new Size(64, 23);
            label2.TabIndex = 9;
            label2.Text = "姓名：";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(512, 403);
            label1.Name = "label1";
            label1.Size = new Size(64, 23);
            label1.TabIndex = 10;
            label1.Text = "部門：";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(512, 478);
            label4.Name = "label4";
            label4.Size = new Size(64, 23);
            label4.TabIndex = 9;
            label4.Text = "品名：";
            // 
            // comboBox_Product
            // 
            comboBox_Product.FormattingEnabled = true;
            comboBox_Product.Location = new Point(582, 475);
            comboBox_Product.Name = "comboBox_Product";
            comboBox_Product.Size = new Size(150, 31);
            comboBox_Product.TabIndex = 11;
            comboBox_Product.SelectedIndexChanged += comboBox_Product_SelectedIndexChanged;
            comboBox_Product.MouseMove += comboBox_Product_Mouse_Move;
            // 
            // button_Remove
            // 
            button_Remove.Location = new Point(963, 598);
            button_Remove.Name = "button_Remove";
            button_Remove.Size = new Size(78, 34);
            button_Remove.TabIndex = 0;
            button_Remove.Text = "移除列";
            button_Remove.UseVisualStyleBackColor = true;
            button_Remove.Click += button_Remove_Click;
            button_Remove.MouseLeave += button_Remove_Mouse_Leave;
            button_Remove.MouseMove += button_Remove_Mouse_Move;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(218, 362);
            label11.Name = "label11";
            label11.Size = new Size(46, 23);
            label11.TabIndex = 8;
            label11.Text = "菜單";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(90, 403);
            label12.Name = "label12";
            label12.Size = new Size(55, 23);
            label12.TabIndex = 17;
            label12.Text = "店家 :";
            // 
            // label_Restaurant
            // 
            label_Restaurant.AutoSize = true;
            label_Restaurant.Location = new Point(151, 403);
            label_Restaurant.Name = "label_Restaurant";
            label_Restaurant.Size = new Size(61, 23);
            label_Restaurant.TabIndex = 20;
            label_Restaurant.Text = "label7";
            // 
            // button_Menu
            // 
            button_Menu.Location = new Point(282, 397);
            button_Menu.Name = "button_Menu";
            button_Menu.Size = new Size(101, 34);
            button_Menu.TabIndex = 0;
            button_Menu.Text = "菜單圖片";
            button_Menu.UseVisualStyleBackColor = true;
            button_Menu.Click += button_Menu_Click;
            button_Menu.MouseLeave += button_Menu_Mouse_Leave;
            button_Menu.MouseMove += button_Menu_Mouse_Move;
            // 
            // listView_Menu
            // 
            listView_Menu.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            listView_Menu.FullRowSelect = true;
            listView_Menu.GridLines = true;
            listView_Menu.Location = new Point(90, 437);
            listView_Menu.Name = "listView_Menu";
            listView_Menu.Size = new Size(293, 426);
            listView_Menu.TabIndex = 21;
            listView_Menu.UseCompatibleStateImageBehavior = false;
            listView_Menu.View = View.Details;
            listView_Menu.ColumnClick += listView_Menu_ColumnClick;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "品名";
            columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "價格";
            columnHeader2.TextAlign = HorizontalAlignment.Right;
            // 
            // listView_Order
            // 
            listView_Order.Columns.AddRange(new ColumnHeader[] { columnHeader5, columnHeader6, columnHeader3, columnHeader7, columnHeader4, columnHeader8, columnHeader9 });
            listView_Order.FullRowSelect = true;
            listView_Order.GridLines = true;
            listView_Order.Location = new Point(508, 638);
            listView_Order.Name = "listView_Order";
            listView_Order.Size = new Size(533, 225);
            listView_Order.TabIndex = 22;
            listView_Order.UseCompatibleStateImageBehavior = false;
            listView_Order.View = View.Details;
            listView_Order.ColumnClick += listView_Order_ColumnClick;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "部門";
            columnHeader5.Width = 120;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "姓名";
            columnHeader6.Width = 80;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "品名";
            columnHeader3.Width = 120;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "數量";
            columnHeader7.Width = 50;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "價格";
            columnHeader4.TextAlign = HorizontalAlignment.Right;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "備註";
            columnHeader8.Width = 120;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "日期";
            columnHeader9.Width = 250;
            // 
            // comboBox_Restaurant
            // 
            comboBox_Restaurant.FormattingEnabled = true;
            comboBox_Restaurant.Location = new Point(90, 869);
            comboBox_Restaurant.Name = "comboBox_Restaurant";
            comboBox_Restaurant.Size = new Size(150, 31);
            comboBox_Restaurant.TabIndex = 23;
            comboBox_Restaurant.SelectedIndexChanged += comboBox_Restaurant_SelectedIndexChanged;
            comboBox_Restaurant.MouseMove += comboBox_Restaurant_Mouse_Move;
            // 
            // pictureBox_Menu
            // 
            pictureBox_Menu.Location = new Point(90, 78);
            pictureBox_Menu.Name = "pictureBox_Menu";
            pictureBox_Menu.Size = new Size(951, 261);
            pictureBox_Menu.TabIndex = 24;
            pictureBox_Menu.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(785, 478);
            label5.Name = "label5";
            label5.Size = new Size(64, 23);
            label5.TabIndex = 9;
            label5.Text = "單價：";
            // 
            // label_Unit_Price
            // 
            label_Unit_Price.AutoSize = true;
            label_Unit_Price.Location = new Point(855, 478);
            label_Unit_Price.Name = "label_Unit_Price";
            label_Unit_Price.Size = new Size(20, 23);
            label_Unit_Price.TabIndex = 9;
            label_Unit_Price.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(785, 515);
            label6.Name = "label6";
            label6.Size = new Size(64, 23);
            label6.TabIndex = 9;
            label6.Text = "總價：";
            // 
            // label_Total_Price
            // 
            label_Total_Price.AutoSize = true;
            label_Total_Price.Location = new Point(855, 515);
            label_Total_Price.Name = "label_Total_Price";
            label_Total_Price.Size = new Size(20, 23);
            label_Total_Price.TabIndex = 9;
            label_Total_Price.Text = "0";
            // 
            // Order
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1159, 920);
            Controls.Add(pictureBox_Menu);
            Controls.Add(comboBox_Restaurant);
            Controls.Add(listView_Order);
            Controls.Add(listView_Menu);
            Controls.Add(label_Restaurant);
            Controls.Add(label12);
            Controls.Add(textBox_Count);
            Controls.Add(comboBox_Product);
            Controls.Add(comboBox_Name);
            Controls.Add(comboBox_Department);
            Controls.Add(label_Total_Price);
            Controls.Add(label6);
            Controls.Add(label_Unit_Price);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label11);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button_Clear);
            Controls.Add(button_Add);
            Controls.Add(button_Remove);
            Controls.Add(button_Menu);
            Controls.Add(button_Submit);
            Name = "Order";
            Text = "Order";
            ((System.ComponentModel.ISupportInitialize)pictureBox_Menu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_Submit;
        private Button button_Clear;
        private Button button_Add;
        private TextBox textBox_Count;
        private ComboBox comboBox_Name;
        private ComboBox comboBox_Department;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private ComboBox comboBox_Product;
        private Button button_Remove;
        private Label label11;
        private Label label12;
        private Label label_Restaurant;
        private Button button_Menu;
        private ListView listView_Menu;
        private ListView listView_Order;
        private ComboBox comboBox_Restaurant;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader7;
        private PictureBox pictureBox_Menu;
        private Label label5;
        private Label label_Unit_Price;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private Label label6;
        private Label label_Total_Price;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
    }
}