namespace WinFormsApp_Meal_expense_accounting
{
    partial class Booking
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
            label_Address = new Label();
            label_Phone = new Label();
            label_Restaurant = new Label();
            label9 = new Label();
            label6 = new Label();
            label5 = new Label();
            label1 = new Label();
            label_Price_Total = new Label();
            label3 = new Label();
            label_Count_Total = new Label();
            comboBox_Department = new ComboBox();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            comboBox_Restaurant = new ComboBox();
            label15 = new Label();
            label_Count = new Label();
            listView_Booking = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            listView_Order = new ListView();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            label18 = new Label();
            label19 = new Label();
            dateTimePicker = new DateTimePicker();
            SuspendLayout();
            // 
            // label_Address
            // 
            label_Address.AutoSize = true;
            label_Address.Location = new Point(929, 85);
            label_Address.Name = "label_Address";
            label_Address.Size = new Size(61, 23);
            label_Address.TabIndex = 24;
            label_Address.Text = "label7";
            // 
            // label_Phone
            // 
            label_Phone.AutoSize = true;
            label_Phone.Location = new Point(721, 85);
            label_Phone.Name = "label_Phone";
            label_Phone.Size = new Size(61, 23);
            label_Phone.TabIndex = 25;
            label_Phone.Text = "label7";
            // 
            // label_Restaurant
            // 
            label_Restaurant.AutoSize = true;
            label_Restaurant.Location = new Point(543, 85);
            label_Restaurant.Name = "label_Restaurant";
            label_Restaurant.Size = new Size(61, 23);
            label_Restaurant.TabIndex = 26;
            label_Restaurant.Text = "label7";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(867, 85);
            label9.Name = "label9";
            label9.Size = new Size(64, 23);
            label9.TabIndex = 21;
            label9.Text = "地址：";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(663, 85);
            label6.Name = "label6";
            label6.Size = new Size(64, 23);
            label6.TabIndex = 22;
            label6.Text = "電話：";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(482, 85);
            label5.Name = "label5";
            label5.Size = new Size(55, 23);
            label5.TabIndex = 23;
            label5.Text = "店家 :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(483, 127);
            label1.Name = "label1";
            label1.Size = new Size(82, 23);
            label1.TabIndex = 21;
            label1.Text = "總金額：";
            // 
            // label_Price_Total
            // 
            label_Price_Total.AutoSize = true;
            label_Price_Total.Location = new Point(569, 127);
            label_Price_Total.Name = "label_Price_Total";
            label_Price_Total.Size = new Size(61, 23);
            label_Price_Total.TabIndex = 24;
            label_Price_Total.Text = "label7";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(663, 127);
            label3.Name = "label3";
            label3.Size = new Size(82, 23);
            label3.TabIndex = 21;
            label3.Text = "總數量：";
            // 
            // label_Count_Total
            // 
            label_Count_Total.AutoSize = true;
            label_Count_Total.Location = new Point(737, 127);
            label_Count_Total.Name = "label_Count_Total";
            label_Count_Total.Size = new Size(61, 23);
            label_Count_Total.TabIndex = 24;
            label_Count_Total.Text = "label7";
            // 
            // comboBox_Department
            // 
            comboBox_Department.FormattingEnabled = true;
            comboBox_Department.Location = new Point(781, 236);
            comboBox_Department.Name = "comboBox_Department";
            comboBox_Department.Size = new Size(150, 31);
            comboBox_Department.TabIndex = 29;
            comboBox_Department.SelectedIndexChanged += comboBox_Department_SelectedIndexChanged;
            comboBox_Department.MouseMove += comboBox_Department_Mouse_Move;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(711, 239);
            label11.Name = "label11";
            label11.Size = new Size(64, 23);
            label11.TabIndex = 28;
            label11.Text = "部門：";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(72, 85);
            label12.Name = "label12";
            label12.Size = new Size(64, 23);
            label12.TabIndex = 28;
            label12.Text = "日期：";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(73, 130);
            label13.Name = "label13";
            label13.Size = new Size(64, 23);
            label13.TabIndex = 28;
            label13.Text = "店家：";
            // 
            // comboBox_Restaurant
            // 
            comboBox_Restaurant.FormattingEnabled = true;
            comboBox_Restaurant.Location = new Point(142, 127);
            comboBox_Restaurant.Name = "comboBox_Restaurant";
            comboBox_Restaurant.Size = new Size(150, 31);
            comboBox_Restaurant.TabIndex = 29;
            comboBox_Restaurant.SelectedIndexChanged += comboBox_Restaurant_SelectedIndexChanged;
            comboBox_Restaurant.MouseMove += comboBox_Restaurant_Mouse_Move;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(973, 240);
            label15.Name = "label15";
            label15.Size = new Size(64, 23);
            label15.TabIndex = 21;
            label15.Text = "數量：";
            // 
            // label_Count
            // 
            label_Count.AutoSize = true;
            label_Count.Location = new Point(1039, 240);
            label_Count.Name = "label_Count";
            label_Count.Size = new Size(61, 23);
            label_Count.TabIndex = 24;
            label_Count.Text = "label7";
            // 
            // listView_Booking
            // 
            listView_Booking.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader8, columnHeader10 });
            listView_Booking.FullRowSelect = true;
            listView_Booking.GridLines = true;
            listView_Booking.Location = new Point(12, 275);
            listView_Booking.Name = "listView_Booking";
            listView_Booking.Size = new Size(560, 633);
            listView_Booking.TabIndex = 30;
            listView_Booking.UseCompatibleStateImageBehavior = false;
            listView_Booking.View = View.Details;
            listView_Booking.ColumnClick += listView_Booking_ColumnClick;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "品名";
            columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "數量";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "價格";
            columnHeader3.TextAlign = HorizontalAlignment.Right;
            columnHeader3.Width = 80;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "備註";
            columnHeader8.Width = 120;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "日期";
            columnHeader10.Width = 250;
            // 
            // listView_Order
            // 
            listView_Order.Columns.AddRange(new ColumnHeader[] { columnHeader4, columnHeader5, columnHeader6, columnHeader7, columnHeader9, columnHeader11 });
            listView_Order.FullRowSelect = true;
            listView_Order.GridLines = true;
            listView_Order.Location = new Point(587, 275);
            listView_Order.Name = "listView_Order";
            listView_Order.Size = new Size(560, 633);
            listView_Order.TabIndex = 30;
            listView_Order.UseCompatibleStateImageBehavior = false;
            listView_Order.View = View.Details;
            listView_Order.ColumnClick += listView_Order_ColumnClick;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "部門";
            columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "姓名";
            columnHeader5.Width = 120;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "品名";
            columnHeader6.Width = 120;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "數量";
            columnHeader7.TextAlign = HorizontalAlignment.Center;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "備註";
            columnHeader9.Width = 120;
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "日期";
            columnHeader11.Width = 250;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(24, 240);
            label18.Name = "label18";
            label18.Size = new Size(80, 23);
            label18.TabIndex = 23;
            label18.Text = "Booking";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(602, 240);
            label19.Name = "label19";
            label19.Size = new Size(60, 23);
            label19.TabIndex = 23;
            label19.Text = "Order";
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(142, 85);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(210, 30);
            dateTimePicker.TabIndex = 12;
            dateTimePicker.ValueChanged += dateTimePicker_ValueChanged;
            dateTimePicker.MouseMove += dateTimePicker_Mouse_Move;
            // 
            // Booking
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1159, 920);
            Controls.Add(listView_Order);
            Controls.Add(listView_Booking);
            Controls.Add(comboBox_Restaurant);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(comboBox_Department);
            Controls.Add(label11);
            Controls.Add(label_Count);
            Controls.Add(label_Count_Total);
            Controls.Add(label_Price_Total);
            Controls.Add(label15);
            Controls.Add(label_Address);
            Controls.Add(dateTimePicker);
            Controls.Add(label3);
            Controls.Add(label_Phone);
            Controls.Add(label1);
            Controls.Add(label_Restaurant);
            Controls.Add(label9);
            Controls.Add(label6);
            Controls.Add(label19);
            Controls.Add(label18);
            Controls.Add(label5);
            Name = "Booking";
            Text = "Booking";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label_Address;
        private Label label_Phone;
        private Label label_Restaurant;
        private Label label9;
        private Label label6;
        private Label label5;
        private Label label1;
        private Label label_Price_Total;
        private Label label3;
        private Label label_Count_Total;
        private ComboBox comboBox_Department;
        private Label label11;
        private Label label12;
        private Label label13;
        private ComboBox comboBox_Restaurant;
        private Label label15;
        private Label label_Count;
        private ListView listView_Booking;
        private ListView listView_Order;
        private Label label18;
        private Label label19;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private DateTimePicker dateTimePicker;
    }
}