namespace WinFormsApp_Meal_expense_accounting
{
    partial class Restaurant
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
            button_Remove = new Button();
            button_Save = new Button();
            textBox_Phone = new TextBox();
            textBox_Shop = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            textBox_Address = new TextBox();
            label4 = new Label();
            button_Upload_Pic = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBox_Product_1 = new TextBox();
            textBox_Price_1 = new TextBox();
            textBox_Price_2 = new TextBox();
            textBox_Product_2 = new TextBox();
            textBox_Price_3 = new TextBox();
            textBox_Product_3 = new TextBox();
            textBox_Price_4 = new TextBox();
            textBox_Product_4 = new TextBox();
            textBox_Price_5 = new TextBox();
            textBox_Product_5 = new TextBox();
            textBox_Price_6 = new TextBox();
            textBox_Product_6 = new TextBox();
            textBox_Price_7 = new TextBox();
            textBox_Product_7 = new TextBox();
            textBox_Price_8 = new TextBox();
            textBox_Product_8 = new TextBox();
            textBox_Price_9 = new TextBox();
            textBox_Product_9 = new TextBox();
            textBox_Price_10 = new TextBox();
            textBox_Product_10 = new TextBox();
            button_Add_All = new Button();
            button_Clear_All = new Button();
            listView_Menu = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            button_Refresh = new Button();
            pictureBox_Menu = new PictureBox();
            button_Download_Pic = new Button();
            button_Clear_Pic = new Button();
            label_link = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Menu).BeginInit();
            SuspendLayout();
            // 
            // button_Remove
            // 
            button_Remove.Location = new Point(1007, 220);
            button_Remove.Name = "button_Remove";
            button_Remove.Size = new Size(78, 34);
            button_Remove.TabIndex = 2;
            button_Remove.Text = "移除列";
            button_Remove.UseVisualStyleBackColor = true;
            button_Remove.Click += button_Remove_Click;
            button_Remove.MouseLeave += button_Remove_Mouse_Leave;
            button_Remove.MouseMove += button_Remove_Mouse_Move;
            // 
            // button_Save
            // 
            button_Save.Location = new Point(839, 220);
            button_Save.Name = "button_Save";
            button_Save.Size = new Size(78, 34);
            button_Save.TabIndex = 3;
            button_Save.Text = "儲存";
            button_Save.UseVisualStyleBackColor = true;
            button_Save.Click += button_Save_Click;
            button_Save.MouseLeave += button_Save_Mouse_Leave;
            button_Save.MouseMove += button_Save_Mouse_Move;
            // 
            // textBox_Phone
            // 
            textBox_Phone.Location = new Point(104, 257);
            textBox_Phone.Name = "textBox_Phone";
            textBox_Phone.Size = new Size(153, 30);
            textBox_Phone.TabIndex = 7;
            // 
            // textBox_Shop
            // 
            textBox_Shop.Location = new Point(104, 221);
            textBox_Shop.Name = "textBox_Shop";
            textBox_Shop.Size = new Size(153, 30);
            textBox_Shop.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 260);
            label2.Name = "label2";
            label2.Size = new Size(64, 23);
            label2.TabIndex = 6;
            label2.Text = "電話：";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 224);
            label1.Name = "label1";
            label1.Size = new Size(64, 23);
            label1.TabIndex = 5;
            label1.Text = "店家：";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 296);
            label3.Name = "label3";
            label3.Size = new Size(64, 23);
            label3.TabIndex = 6;
            label3.Text = "地址：";
            // 
            // textBox_Address
            // 
            textBox_Address.Location = new Point(104, 293);
            textBox_Address.Name = "textBox_Address";
            textBox_Address.Size = new Size(153, 30);
            textBox_Address.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 335);
            label4.Name = "label4";
            label4.Size = new Size(64, 23);
            label4.TabIndex = 6;
            label4.Text = "菜單：";
            // 
            // button_Upload_Pic
            // 
            button_Upload_Pic.Location = new Point(104, 329);
            button_Upload_Pic.Name = "button_Upload_Pic";
            button_Upload_Pic.Size = new Size(101, 34);
            button_Upload_Pic.TabIndex = 3;
            button_Upload_Pic.Text = "上傳圖片";
            button_Upload_Pic.UseVisualStyleBackColor = true;
            button_Upload_Pic.Click += button_Upload_Pic_Click;
            button_Upload_Pic.MouseLeave += button_Upload_Pic_Mouse_Leave;
            button_Upload_Pic.MouseMove += button_Upload_Pic_Mouse_Move;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(451, 220);
            label5.Name = "label5";
            label5.Size = new Size(59, 23);
            label5.TabIndex = 6;
            label5.Text = "Menu";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(88, 511);
            label6.Name = "label6";
            label6.Size = new Size(46, 23);
            label6.TabIndex = 6;
            label6.Text = "品名";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(199, 511);
            label7.Name = "label7";
            label7.Size = new Size(46, 23);
            label7.TabIndex = 6;
            label7.Text = "價格";
            // 
            // textBox_Product_1
            // 
            textBox_Product_1.Location = new Point(34, 541);
            textBox_Product_1.Name = "textBox_Product_1";
            textBox_Product_1.Size = new Size(153, 30);
            textBox_Product_1.TabIndex = 8;
            // 
            // textBox_Price_1
            // 
            textBox_Price_1.Location = new Point(193, 541);
            textBox_Price_1.Name = "textBox_Price_1";
            textBox_Price_1.Size = new Size(74, 30);
            textBox_Price_1.TabIndex = 8;
            // 
            // textBox_Price_2
            // 
            textBox_Price_2.Location = new Point(193, 577);
            textBox_Price_2.Name = "textBox_Price_2";
            textBox_Price_2.Size = new Size(74, 30);
            textBox_Price_2.TabIndex = 8;
            // 
            // textBox_Product_2
            // 
            textBox_Product_2.Location = new Point(34, 577);
            textBox_Product_2.Name = "textBox_Product_2";
            textBox_Product_2.Size = new Size(153, 30);
            textBox_Product_2.TabIndex = 8;
            // 
            // textBox_Price_3
            // 
            textBox_Price_3.Location = new Point(193, 613);
            textBox_Price_3.Name = "textBox_Price_3";
            textBox_Price_3.Size = new Size(74, 30);
            textBox_Price_3.TabIndex = 8;
            // 
            // textBox_Product_3
            // 
            textBox_Product_3.Location = new Point(34, 613);
            textBox_Product_3.Name = "textBox_Product_3";
            textBox_Product_3.Size = new Size(153, 30);
            textBox_Product_3.TabIndex = 8;
            // 
            // textBox_Price_4
            // 
            textBox_Price_4.Location = new Point(193, 649);
            textBox_Price_4.Name = "textBox_Price_4";
            textBox_Price_4.Size = new Size(74, 30);
            textBox_Price_4.TabIndex = 8;
            // 
            // textBox_Product_4
            // 
            textBox_Product_4.Location = new Point(34, 649);
            textBox_Product_4.Name = "textBox_Product_4";
            textBox_Product_4.Size = new Size(153, 30);
            textBox_Product_4.TabIndex = 8;
            // 
            // textBox_Price_5
            // 
            textBox_Price_5.Location = new Point(193, 685);
            textBox_Price_5.Name = "textBox_Price_5";
            textBox_Price_5.Size = new Size(74, 30);
            textBox_Price_5.TabIndex = 8;
            // 
            // textBox_Product_5
            // 
            textBox_Product_5.Location = new Point(34, 685);
            textBox_Product_5.Name = "textBox_Product_5";
            textBox_Product_5.Size = new Size(153, 30);
            textBox_Product_5.TabIndex = 8;
            // 
            // textBox_Price_6
            // 
            textBox_Price_6.Location = new Point(193, 721);
            textBox_Price_6.Name = "textBox_Price_6";
            textBox_Price_6.Size = new Size(74, 30);
            textBox_Price_6.TabIndex = 8;
            // 
            // textBox_Product_6
            // 
            textBox_Product_6.Location = new Point(34, 721);
            textBox_Product_6.Name = "textBox_Product_6";
            textBox_Product_6.Size = new Size(153, 30);
            textBox_Product_6.TabIndex = 8;
            // 
            // textBox_Price_7
            // 
            textBox_Price_7.Location = new Point(193, 757);
            textBox_Price_7.Name = "textBox_Price_7";
            textBox_Price_7.Size = new Size(74, 30);
            textBox_Price_7.TabIndex = 8;
            // 
            // textBox_Product_7
            // 
            textBox_Product_7.Location = new Point(34, 757);
            textBox_Product_7.Name = "textBox_Product_7";
            textBox_Product_7.Size = new Size(153, 30);
            textBox_Product_7.TabIndex = 8;
            // 
            // textBox_Price_8
            // 
            textBox_Price_8.Location = new Point(193, 793);
            textBox_Price_8.Name = "textBox_Price_8";
            textBox_Price_8.Size = new Size(74, 30);
            textBox_Price_8.TabIndex = 8;
            // 
            // textBox_Product_8
            // 
            textBox_Product_8.Location = new Point(34, 793);
            textBox_Product_8.Name = "textBox_Product_8";
            textBox_Product_8.Size = new Size(153, 30);
            textBox_Product_8.TabIndex = 8;
            // 
            // textBox_Price_9
            // 
            textBox_Price_9.Location = new Point(193, 829);
            textBox_Price_9.Name = "textBox_Price_9";
            textBox_Price_9.Size = new Size(74, 30);
            textBox_Price_9.TabIndex = 8;
            // 
            // textBox_Product_9
            // 
            textBox_Product_9.Location = new Point(34, 829);
            textBox_Product_9.Name = "textBox_Product_9";
            textBox_Product_9.Size = new Size(153, 30);
            textBox_Product_9.TabIndex = 8;
            // 
            // textBox_Price_10
            // 
            textBox_Price_10.Location = new Point(193, 865);
            textBox_Price_10.Name = "textBox_Price_10";
            textBox_Price_10.Size = new Size(74, 30);
            textBox_Price_10.TabIndex = 8;
            // 
            // textBox_Product_10
            // 
            textBox_Product_10.Location = new Point(34, 865);
            textBox_Product_10.Name = "textBox_Product_10";
            textBox_Product_10.Size = new Size(153, 30);
            textBox_Product_10.TabIndex = 8;
            // 
            // button_Add_All
            // 
            button_Add_All.Location = new Point(286, 541);
            button_Add_All.Name = "button_Add_All";
            button_Add_All.Size = new Size(101, 34);
            button_Add_All.TabIndex = 3;
            button_Add_All.Text = "全部加入";
            button_Add_All.UseVisualStyleBackColor = true;
            button_Add_All.Click += button_Add_All_Click;
            button_Add_All.MouseLeave += button_Add_All_Mouse_Leave;
            button_Add_All.MouseMove += button_Add_All_Mouse_Move;
            // 
            // button_Clear_All
            // 
            button_Clear_All.Location = new Point(286, 581);
            button_Clear_All.Name = "button_Clear_All";
            button_Clear_All.Size = new Size(101, 34);
            button_Clear_All.TabIndex = 2;
            button_Clear_All.Text = "全部清除";
            button_Clear_All.UseVisualStyleBackColor = true;
            button_Clear_All.Click += button_Clear_All_Click;
            button_Clear_All.MouseLeave += button_Clear_All_Mouse_Leave;
            button_Clear_All.MouseMove += button_Clear_All_Mouse_Move;
            // 
            // listView_Menu
            // 
            listView_Menu.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6 });
            listView_Menu.FullRowSelect = true;
            listView_Menu.GridLines = true;
            listView_Menu.Location = new Point(440, 260);
            listView_Menu.Name = "listView_Menu";
            listView_Menu.Size = new Size(645, 635);
            listView_Menu.TabIndex = 10;
            listView_Menu.UseCompatibleStateImageBehavior = false;
            listView_Menu.View = View.Details;
            listView_Menu.ColumnClick += listView_Menu_ColumnClick;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "店家";
            columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "電話";
            columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "地址";
            columnHeader3.Width = 130;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "品名";
            columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "價格";
            columnHeader5.TextAlign = HorizontalAlignment.Right;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "圖片路徑";
            columnHeader6.Width = 360;
            // 
            // button_Refresh
            // 
            button_Refresh.Location = new Point(923, 220);
            button_Refresh.Name = "button_Refresh";
            button_Refresh.Size = new Size(78, 34);
            button_Refresh.TabIndex = 11;
            button_Refresh.Text = "還原";
            button_Refresh.UseVisualStyleBackColor = true;
            button_Refresh.Click += button_Refresh_Click;
            button_Refresh.MouseLeave += button_Refresh_Mouse_Leave;
            button_Refresh.MouseMove += button_Refresh_Mouse_Move;
            // 
            // pictureBox_Menu
            // 
            pictureBox_Menu.Location = new Point(34, 12);
            pictureBox_Menu.Name = "pictureBox_Menu";
            pictureBox_Menu.Size = new Size(1051, 187);
            pictureBox_Menu.TabIndex = 12;
            pictureBox_Menu.TabStop = false;
            // 
            // button_Download_Pic
            // 
            button_Download_Pic.Location = new Point(211, 329);
            button_Download_Pic.Name = "button_Download_Pic";
            button_Download_Pic.Size = new Size(101, 34);
            button_Download_Pic.TabIndex = 3;
            button_Download_Pic.Text = "下載圖片";
            button_Download_Pic.UseVisualStyleBackColor = true;
            button_Download_Pic.Click += button_Download_Pic_Click;
            button_Download_Pic.MouseLeave += button_Download_Pic_Mouse_Leave;
            button_Download_Pic.MouseMove += button_Download_Pic_Mouse_Move;
            // 
            // button_Clear_Pic
            // 
            button_Clear_Pic.Location = new Point(104, 369);
            button_Clear_Pic.Name = "button_Clear_Pic";
            button_Clear_Pic.Size = new Size(101, 34);
            button_Clear_Pic.TabIndex = 3;
            button_Clear_Pic.Text = "清除圖片";
            button_Clear_Pic.UseVisualStyleBackColor = true;
            button_Clear_Pic.Click += button_Clear_Pic_Click;
            button_Clear_Pic.MouseLeave += button_Clear_Pic_Mouse_Leave;
            button_Clear_Pic.MouseMove += button_Clear_Pic_Mouse_Move;
            // 
            // label_link
            // 
            label_link.AutoSize = true;
            label_link.Location = new Point(104, 416);
            label_link.Name = "label_link";
            label_link.Size = new Size(41, 23);
            label_link.TabIndex = 13;
            label_link.Text = "link";
            // 
            // Restaurant
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1159, 920);
            Controls.Add(label_link);
            Controls.Add(pictureBox_Menu);
            Controls.Add(button_Refresh);
            Controls.Add(listView_Menu);
            Controls.Add(textBox_Address);
            Controls.Add(textBox_Phone);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label7);
            Controls.Add(label3);
            Controls.Add(textBox_Product_10);
            Controls.Add(textBox_Product_9);
            Controls.Add(textBox_Product_8);
            Controls.Add(textBox_Product_7);
            Controls.Add(textBox_Product_6);
            Controls.Add(textBox_Product_5);
            Controls.Add(textBox_Product_4);
            Controls.Add(textBox_Product_3);
            Controls.Add(textBox_Product_2);
            Controls.Add(textBox_Product_1);
            Controls.Add(textBox_Price_10);
            Controls.Add(textBox_Price_9);
            Controls.Add(textBox_Price_8);
            Controls.Add(textBox_Price_7);
            Controls.Add(textBox_Price_6);
            Controls.Add(textBox_Price_5);
            Controls.Add(textBox_Price_4);
            Controls.Add(textBox_Price_3);
            Controls.Add(textBox_Price_2);
            Controls.Add(textBox_Price_1);
            Controls.Add(textBox_Shop);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button_Clear_All);
            Controls.Add(button_Remove);
            Controls.Add(button_Clear_Pic);
            Controls.Add(button_Download_Pic);
            Controls.Add(button_Upload_Pic);
            Controls.Add(button_Add_All);
            Controls.Add(button_Save);
            Name = "Restaurant";
            Text = "Restaurant";
            ((System.ComponentModel.ISupportInitialize)pictureBox_Menu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button_Remove;
        private Button button_Save;
        private TextBox textBox_Phone;
        private TextBox textBox_Shop;
        private Label label2;
        private Label label1;
        private Label label3;
        private TextBox textBox_Address;
        private Label label4;
        private Button button_Upload_Pic;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBox_Product_1;
        private TextBox textBox_Price_1;
        private TextBox textBox_Price_2;
        private TextBox textBox_Product_2;
        private TextBox textBox_Price_3;
        private TextBox textBox_Product_3;
        private TextBox textBox_Price_4;
        private TextBox textBox_Product_4;
        private TextBox textBox_Price_5;
        private TextBox textBox_Product_5;
        private TextBox textBox_Price_6;
        private TextBox textBox_Product_6;
        private TextBox textBox_Price_7;
        private TextBox textBox_Product_7;
        private TextBox textBox_Price_8;
        private TextBox textBox_Product_8;
        private TextBox textBox_Price_9;
        private TextBox textBox_Product_9;
        private TextBox textBox_Price_10;
        private TextBox textBox_Product_10;
        private Button button_Add_All;
        private Button button_Clear_All;
        private ListView listView_Menu;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private Button button_Refresh;
        private Button button_Clear;
        private PictureBox pictureBox_Menu;
        private Button button_Download_Pic;
        private Button button_Clear_Pic;
        private Label label_link;
        private ColumnHeader columnHeader6;
    }
}