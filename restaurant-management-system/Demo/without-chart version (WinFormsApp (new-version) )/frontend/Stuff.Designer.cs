namespace WinFormsApp_OrderFood
{
    partial class Stuff
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
            listView_In = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            comboBox_Type = new ComboBox();
            button_Confirm_Now = new Button();
            button_Cancel_Now = new Button();
            button_Save = new Button();
            comboBox_Name = new ComboBox();
            label_Balance = new Label();
            comboBox_Place = new ComboBox();
            button_Increase = new Button();
            button_Reduce = new Button();
            radioButton_Infeed = new RadioButton();
            radioButton_Outfeed = new RadioButton();
            radioButton_Overflow = new RadioButton();
            radioButton_Shortage = new RadioButton();
            comboBox_Mode = new ComboBox();
            button_Remove = new Button();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            comboBox_AddType = new ComboBox();
            label2 = new Label();
            comboBox_AddName = new ComboBox();
            label4 = new Label();
            label11 = new Label();
            label12 = new Label();
            textBox_Number = new TextBox();
            label1 = new Label();
            label_Count = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            button_Confirm_New = new Button();
            textBox_AddPlace = new TextBox();
            textBox_AddUnit = new TextBox();
            textBox_AddName = new TextBox();
            textBox_AddType = new TextBox();
            button_Cancel_New = new Button();
            textBox_AddNum = new TextBox();
            textBox_AddCount = new TextBox();
            label19 = new Label();
            label20 = new Label();
            label21 = new Label();
            label23 = new Label();
            label24 = new Label();
            label25 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // listView_In
            // 
            listView_In.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader7, columnHeader9, columnHeader8 });
            listView_In.Font = new Font("Microsoft JhengHei UI", 12F);
            listView_In.FullRowSelect = true;
            listView_In.Location = new Point(12, 76);
            listView_In.Name = "listView_In";
            listView_In.Size = new Size(1135, 709);
            listView_In.TabIndex = 3;
            listView_In.UseCompatibleStateImageBehavior = false;
            listView_In.View = View.Details;
            listView_In.ColumnClick += listView_In_ColumnClick;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "類型";
            columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "產品編號";
            columnHeader2.Width = 0;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "產品名稱";
            columnHeader3.Width = 260;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "數量";
            columnHeader4.Width = 80;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "單位";
            columnHeader5.Width = 80;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "庫存地點";
            columnHeader7.Width = 120;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "庫存狀態";
            columnHeader9.Width = 120;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "庫存時間";
            columnHeader8.Width = 300;
            // 
            // comboBox_Type
            // 
            comboBox_Type.FormattingEnabled = true;
            comboBox_Type.Location = new Point(377, 35);
            comboBox_Type.Name = "comboBox_Type";
            comboBox_Type.Size = new Size(111, 31);
            comboBox_Type.TabIndex = 5;
            comboBox_Type.SelectedIndexChanged += comboBox_Type_SelectedIndexChanged;
            // 
            // button_Confirm_Now
            // 
            button_Confirm_Now.Font = new Font("Microsoft JhengHei UI", 14F);
            button_Confirm_Now.Location = new Point(6, 284);
            button_Confirm_Now.Name = "button_Confirm_Now";
            button_Confirm_Now.Size = new Size(202, 52);
            button_Confirm_Now.TabIndex = 4;
            button_Confirm_Now.Text = "加入現有食材";
            button_Confirm_Now.UseVisualStyleBackColor = true;
            button_Confirm_Now.Click += button_Confirm_Now_Click;
            button_Confirm_Now.MouseLeave += button_Confirm_Now_Mouse_Leave;
            button_Confirm_Now.MouseMove += button_Confirm_Now_Mouse_Move;
            // 
            // button_Cancel_Now
            // 
            button_Cancel_Now.Font = new Font("Microsoft JhengHei UI", 14F);
            button_Cancel_Now.Location = new Point(214, 284);
            button_Cancel_Now.Name = "button_Cancel_Now";
            button_Cancel_Now.Size = new Size(84, 52);
            button_Cancel_Now.TabIndex = 4;
            button_Cancel_Now.Text = "取消";
            button_Cancel_Now.UseVisualStyleBackColor = true;
            button_Cancel_Now.Click += button_Cancel_Now_Click;
            button_Cancel_Now.MouseLeave += button_Cancel_Now_Mouse_Leave;
            button_Cancel_Now.MouseMove += button_Cancel_Now_Mouse_Move;
            // 
            // button_Save
            // 
            button_Save.Font = new Font("Microsoft JhengHei UI", 14F);
            button_Save.Location = new Point(8, 342);
            button_Save.Name = "button_Save";
            button_Save.Size = new Size(84, 52);
            button_Save.TabIndex = 4;
            button_Save.Text = "儲存";
            button_Save.UseVisualStyleBackColor = true;
            button_Save.Click += button_Save_Click;
            button_Save.MouseLeave += button_Save_Mouse_Leave;
            button_Save.MouseMove += button_Save_Mouse_Move;
            // 
            // comboBox_Name
            // 
            comboBox_Name.FormattingEnabled = true;
            comboBox_Name.Location = new Point(673, 35);
            comboBox_Name.Name = "comboBox_Name";
            comboBox_Name.Size = new Size(167, 31);
            comboBox_Name.TabIndex = 5;
            comboBox_Name.SelectedIndexChanged += comboBox_Name_SelectedIndexChanged;
            // 
            // label_Balance
            // 
            label_Balance.AutoSize = true;
            label_Balance.Location = new Point(243, 172);
            label_Balance.Name = "label_Balance";
            label_Balance.Size = new Size(20, 23);
            label_Balance.TabIndex = 6;
            label_Balance.Text = "0";
            // 
            // comboBox_Place
            // 
            comboBox_Place.FormattingEnabled = true;
            comboBox_Place.Location = new Point(1036, 35);
            comboBox_Place.Name = "comboBox_Place";
            comboBox_Place.Size = new Size(111, 31);
            comboBox_Place.TabIndex = 5;
            comboBox_Place.SelectedIndexChanged += comboBox_Place_SelectedIndexChanged;
            // 
            // button_Increase
            // 
            button_Increase.Font = new Font("Microsoft JhengHei UI", 20F);
            button_Increase.Location = new Point(111, 209);
            button_Increase.Name = "button_Increase";
            button_Increase.Size = new Size(55, 55);
            button_Increase.TabIndex = 8;
            button_Increase.Text = "+";
            button_Increase.UseVisualStyleBackColor = true;
            button_Increase.Click += button_Increase_Click;
            button_Increase.MouseLeave += button_Increase_Mouse_Leave;
            button_Increase.MouseMove += button_Increase_Mouse_Move;
            // 
            // button_Reduce
            // 
            button_Reduce.Font = new Font("Microsoft JhengHei UI", 20F);
            button_Reduce.Location = new Point(172, 209);
            button_Reduce.Name = "button_Reduce";
            button_Reduce.Size = new Size(55, 55);
            button_Reduce.TabIndex = 8;
            button_Reduce.Text = "-";
            button_Reduce.UseVisualStyleBackColor = true;
            button_Reduce.Click += button_Reduce_Click;
            button_Reduce.MouseLeave += button_Reduce_Mouse_Leave;
            button_Reduce.MouseMove += button_Reduce_Mouse_Move;
            // 
            // radioButton_Infeed
            // 
            radioButton_Infeed.AutoSize = true;
            radioButton_Infeed.Location = new Point(114, 11);
            radioButton_Infeed.Name = "radioButton_Infeed";
            radioButton_Infeed.Size = new Size(71, 27);
            radioButton_Infeed.TabIndex = 9;
            radioButton_Infeed.TabStop = true;
            radioButton_Infeed.Text = "入料";
            radioButton_Infeed.UseVisualStyleBackColor = true;
            radioButton_Infeed.CheckedChanged += radioButton_Infeed_CheckedChanged;
            // 
            // radioButton_Outfeed
            // 
            radioButton_Outfeed.AutoSize = true;
            radioButton_Outfeed.Location = new Point(191, 11);
            radioButton_Outfeed.Name = "radioButton_Outfeed";
            radioButton_Outfeed.Size = new Size(71, 27);
            radioButton_Outfeed.TabIndex = 9;
            radioButton_Outfeed.TabStop = true;
            radioButton_Outfeed.Text = "出料";
            radioButton_Outfeed.UseVisualStyleBackColor = true;
            radioButton_Outfeed.CheckedChanged += radioButton_Outfeed_CheckedChanged;
            // 
            // radioButton_Overflow
            // 
            radioButton_Overflow.AutoSize = true;
            radioButton_Overflow.Location = new Point(114, 44);
            radioButton_Overflow.Name = "radioButton_Overflow";
            radioButton_Overflow.Size = new Size(71, 27);
            radioButton_Overflow.TabIndex = 9;
            radioButton_Overflow.TabStop = true;
            radioButton_Overflow.Text = "溢出";
            radioButton_Overflow.UseVisualStyleBackColor = true;
            radioButton_Overflow.CheckedChanged += radioButton_Overflow_CheckedChanged;
            // 
            // radioButton_Shortage
            // 
            radioButton_Shortage.AutoSize = true;
            radioButton_Shortage.Location = new Point(191, 44);
            radioButton_Shortage.Name = "radioButton_Shortage";
            radioButton_Shortage.Size = new Size(71, 27);
            radioButton_Shortage.TabIndex = 9;
            radioButton_Shortage.TabStop = true;
            radioButton_Shortage.Text = "短少";
            radioButton_Shortage.UseVisualStyleBackColor = true;
            radioButton_Shortage.CheckedChanged += radioButton_Shortage_CheckedChanged;
            // 
            // comboBox_Mode
            // 
            comboBox_Mode.FormattingEnabled = true;
            comboBox_Mode.Location = new Point(122, 35);
            comboBox_Mode.Name = "comboBox_Mode";
            comboBox_Mode.Size = new Size(111, 31);
            comboBox_Mode.TabIndex = 5;
            comboBox_Mode.SelectedIndexChanged += comboBox_Mode_SelectedIndexChanged;
            // 
            // button_Remove
            // 
            button_Remove.Font = new Font("Microsoft JhengHei UI", 14F);
            button_Remove.Location = new Point(98, 343);
            button_Remove.Name = "button_Remove";
            button_Remove.Size = new Size(110, 52);
            button_Remove.TabIndex = 4;
            button_Remove.Text = "移除列";
            button_Remove.UseVisualStyleBackColor = true;
            button_Remove.Click += button_Remove_Click;
            button_Remove.MouseLeave += button_Remove_Mouse_Leave;
            button_Remove.MouseMove += button_Remove_Mouse_Move;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 38);
            label6.Name = "label6";
            label6.Size = new Size(100, 23);
            label6.TabIndex = 6;
            label6.Text = "庫存狀態：";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(307, 38);
            label7.Name = "label7";
            label7.Size = new Size(64, 23);
            label7.TabIndex = 6;
            label7.Text = "類型：";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(567, 38);
            label8.Name = "label8";
            label8.Size = new Size(100, 23);
            label8.TabIndex = 6;
            label8.Text = "產品名稱：";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(930, 38);
            label9.Name = "label9";
            label9.Size = new Size(100, 23);
            label9.TabIndex = 6;
            label9.Text = "庫存地點：";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(173, 172);
            label10.Name = "label10";
            label10.Size = new Size(64, 23);
            label10.TabIndex = 6;
            label10.Text = "餘額：";
            // 
            // comboBox_AddType
            // 
            comboBox_AddType.FormattingEnabled = true;
            comboBox_AddType.Location = new Point(112, 87);
            comboBox_AddType.Name = "comboBox_AddType";
            comboBox_AddType.Size = new Size(167, 31);
            comboBox_AddType.TabIndex = 5;
            comboBox_AddType.SelectedIndexChanged += comboBox_AddType_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 90);
            label2.Name = "label2";
            label2.Size = new Size(64, 23);
            label2.TabIndex = 6;
            label2.Text = "類型：";
            // 
            // comboBox_AddName
            // 
            comboBox_AddName.FormattingEnabled = true;
            comboBox_AddName.Location = new Point(112, 124);
            comboBox_AddName.Name = "comboBox_AddName";
            comboBox_AddName.Size = new Size(167, 31);
            comboBox_AddName.TabIndex = 5;
            comboBox_AddName.SelectedIndexChanged += comboBox_AddName_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 127);
            label4.Name = "label4";
            label4.Size = new Size(100, 23);
            label4.TabIndex = 6;
            label4.Text = "產品名稱：";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(6, 26);
            label11.Name = "label11";
            label11.Size = new Size(100, 23);
            label11.TabIndex = 6;
            label11.Text = "庫存狀態：";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(41, 225);
            label12.Name = "label12";
            label12.Size = new Size(64, 23);
            label12.TabIndex = 6;
            label12.Text = "數量：";
            // 
            // textBox_Number
            // 
            textBox_Number.Location = new Point(233, 225);
            textBox_Number.Name = "textBox_Number";
            textBox_Number.Size = new Size(45, 30);
            textBox_Number.TabIndex = 10;
            textBox_Number.TextChanged += textBox_Number_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(4, 172);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 6;
            label1.Text = "增減數量：";
            // 
            // label_Count
            // 
            label_Count.AutoSize = true;
            label_Count.Location = new Point(115, 172);
            label_Count.Name = "label_Count";
            label_Count.Size = new Size(20, 23);
            label_Count.TabIndex = 6;
            label_Count.Text = "0";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button_Save);
            groupBox1.Controls.Add(button_Remove);
            groupBox1.Controls.Add(button_Confirm_Now);
            groupBox1.Controls.Add(textBox_Number);
            groupBox1.Controls.Add(radioButton_Shortage);
            groupBox1.Controls.Add(radioButton_Overflow);
            groupBox1.Controls.Add(button_Cancel_Now);
            groupBox1.Controls.Add(radioButton_Outfeed);
            groupBox1.Controls.Add(comboBox_AddType);
            groupBox1.Controls.Add(radioButton_Infeed);
            groupBox1.Controls.Add(button_Reduce);
            groupBox1.Controls.Add(comboBox_AddName);
            groupBox1.Controls.Add(button_Increase);
            groupBox1.Controls.Add(label_Balance);
            groupBox1.Controls.Add(label_Count);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label12);
            groupBox1.FlatStyle = FlatStyle.System;
            groupBox1.Font = new Font("Microsoft JhengHei UI", 9F);
            groupBox1.Location = new Point(1153, 76);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(304, 404);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Paint += groupBox1_Paint;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button_Confirm_New);
            groupBox2.Controls.Add(textBox_AddPlace);
            groupBox2.Controls.Add(textBox_AddUnit);
            groupBox2.Controls.Add(textBox_AddName);
            groupBox2.Controls.Add(textBox_AddType);
            groupBox2.Controls.Add(button_Cancel_New);
            groupBox2.Controls.Add(textBox_AddNum);
            groupBox2.Controls.Add(textBox_AddCount);
            groupBox2.Controls.Add(label19);
            groupBox2.Controls.Add(label20);
            groupBox2.Controls.Add(label21);
            groupBox2.Controls.Add(label23);
            groupBox2.Controls.Add(label24);
            groupBox2.Controls.Add(label25);
            groupBox2.FlatStyle = FlatStyle.System;
            groupBox2.Font = new Font("Microsoft JhengHei UI", 9F);
            groupBox2.Location = new Point(1153, 477);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(304, 308);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Paint += groupBox2_Paint;
            // 
            // button_Confirm_New
            // 
            button_Confirm_New.Font = new Font("Microsoft JhengHei UI", 14F);
            button_Confirm_New.Location = new Point(6, 252);
            button_Confirm_New.Name = "button_Confirm_New";
            button_Confirm_New.Size = new Size(202, 52);
            button_Confirm_New.TabIndex = 4;
            button_Confirm_New.Text = "加入新食材";
            button_Confirm_New.UseVisualStyleBackColor = true;
            button_Confirm_New.Click += button_Confirm_New_Click;
            button_Confirm_New.MouseLeave += button_Confirm_New_Mouse_Leave;
            button_Confirm_New.MouseMove += button_Confirm_New_Mouse_Move;
            // 
            // textBox_AddPlace
            // 
            textBox_AddPlace.Location = new Point(114, 209);
            textBox_AddPlace.Name = "textBox_AddPlace";
            textBox_AddPlace.Size = new Size(110, 30);
            textBox_AddPlace.TabIndex = 19;
            // 
            // textBox_AddUnit
            // 
            textBox_AddUnit.Location = new Point(114, 168);
            textBox_AddUnit.Name = "textBox_AddUnit";
            textBox_AddUnit.Size = new Size(110, 30);
            textBox_AddUnit.TabIndex = 20;
            // 
            // textBox_AddName
            // 
            textBox_AddName.Location = new Point(114, 49);
            textBox_AddName.Name = "textBox_AddName";
            textBox_AddName.Size = new Size(110, 30);
            textBox_AddName.TabIndex = 21;
            // 
            // textBox_AddType
            // 
            textBox_AddType.Location = new Point(114, 9);
            textBox_AddType.Name = "textBox_AddType";
            textBox_AddType.Size = new Size(110, 30);
            textBox_AddType.TabIndex = 22;
            // 
            // button_Cancel_New
            // 
            button_Cancel_New.Font = new Font("Microsoft JhengHei UI", 14F);
            button_Cancel_New.Location = new Point(214, 253);
            button_Cancel_New.Name = "button_Cancel_New";
            button_Cancel_New.Size = new Size(84, 52);
            button_Cancel_New.TabIndex = 4;
            button_Cancel_New.Text = "取消";
            button_Cancel_New.UseVisualStyleBackColor = true;
            button_Cancel_New.Click += button_Cancel_New_Click;
            button_Cancel_New.MouseLeave += button_Cancel_New_Mouse_Leave;
            button_Cancel_New.MouseMove += button_Cancel_New_Mouse_Move;
            // 
            // textBox_AddNum
            // 
            textBox_AddNum.Location = new Point(114, 87);
            textBox_AddNum.Name = "textBox_AddNum";
            textBox_AddNum.Size = new Size(110, 30);
            textBox_AddNum.TabIndex = 23;
            // 
            // textBox_AddCount
            // 
            textBox_AddCount.Location = new Point(114, 126);
            textBox_AddCount.Name = "textBox_AddCount";
            textBox_AddCount.Size = new Size(110, 30);
            textBox_AddCount.TabIndex = 24;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(8, 91);
            label19.Name = "label19";
            label19.Size = new Size(100, 23);
            label19.TabIndex = 11;
            label19.Text = "產品編號：";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(44, 172);
            label20.Name = "label20";
            label20.Size = new Size(64, 23);
            label20.TabIndex = 12;
            label20.Text = "單位：";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(8, 212);
            label21.Name = "label21";
            label21.Size = new Size(100, 23);
            label21.TabIndex = 13;
            label21.Text = "庫存地點：";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(8, 53);
            label23.Name = "label23";
            label23.Size = new Size(100, 23);
            label23.TabIndex = 15;
            label23.Text = "產品名稱：";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(44, 13);
            label24.Name = "label24";
            label24.Size = new Size(64, 23);
            label24.TabIndex = 16;
            label24.Text = "類型：";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(44, 130);
            label25.Name = "label25";
            label25.Size = new Size(64, 23);
            label25.TabIndex = 17;
            label25.Text = "數量：";
            // 
            // Stuff
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1459, 797);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(comboBox_Mode);
            Controls.Add(comboBox_Place);
            Controls.Add(comboBox_Name);
            Controls.Add(comboBox_Type);
            Controls.Add(listView_In);
            Name = "Stuff";
            Text = "Stuff";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListView listView_In;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader1;
        private ComboBox comboBox_Type;
        private ColumnHeader columnHeader8;
        private Button button_Confirm_Now;
        private Button button_Cancel_Now;
        private Button button_Save;
        private ComboBox comboBox_Name;
        private Label label_Balance;
        private ComboBox comboBox_Place;
        private Button button_Increase;
        private Button button_Reduce;
        private ColumnHeader columnHeader9;
        private RadioButton radioButton_Infeed;
        private RadioButton radioButton_Outfeed;
        private RadioButton radioButton_Overflow;
        private RadioButton radioButton_Shortage;
        private ComboBox comboBox_Mode;
        private Button button_Remove;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private ComboBox comboBox_AddType;
        private Label label2;
        private ComboBox comboBox_AddName;
        private Label label4;
        private Label label11;
        private Label label12;
        private TextBox textBox_Number;
        private Label label1;
        private Label label_Count;
        private GroupBox groupBox1;
        private ColumnHeader columnHeader5;
        private GroupBox groupBox2;
        private Button button_Confirm_New;
        private TextBox textBox_AddPlace;
        private TextBox textBox_AddUnit;
        private TextBox textBox_AddName;
        private TextBox textBox_AddType;
        private TextBox textBox_AddNum;
        private Button button_Cancel_New;
        private TextBox textBox_AddCount;
        private Label label19;
        private Label label20;
        private Label label21;
        private Label label23;
        private Label label24;
        private Label label25;
    }
}