namespace WindowsFormsApp_OrderFood
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
            this.listView_In = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comboBox_Mode = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Increase = new System.Windows.Forms.Button();
            this.radioButton_Infeed = new System.Windows.Forms.RadioButton();
            this.textBox_Number = new System.Windows.Forms.TextBox();
            this.comboBox_Type = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_Name = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_Place = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButton_Outfeed = new System.Windows.Forms.RadioButton();
            this.radioButton_Overflow = new System.Windows.Forms.RadioButton();
            this.radioButton_Shortage = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_AddType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox_AddName = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label_Count = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label_Balance = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button_Reduce = new System.Windows.Forms.Button();
            this.button_Confirm_Now = new System.Windows.Forms.Button();
            this.button_Cancel_Now = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.button_Remove = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox_AddType = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox_AddName = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox_AddNum = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox_AddCount = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox_AddUnit = new System.Windows.Forms.TextBox();
            this.button_Confirm_New = new System.Windows.Forms.Button();
            this.button_Cancel_New = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_AddPlace = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView_In
            // 
            this.listView_In.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listView_In.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.listView_In.FullRowSelect = true;
            this.listView_In.HideSelection = false;
            this.listView_In.Location = new System.Drawing.Point(12, 76);
            this.listView_In.Name = "listView_In";
            this.listView_In.Size = new System.Drawing.Size(1135, 709);
            this.listView_In.TabIndex = 0;
            this.listView_In.UseCompatibleStateImageBehavior = false;
            this.listView_In.View = System.Windows.Forms.View.Details;
            this.listView_In.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView_In_ColumnClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "類型";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "產品編號";
            this.columnHeader2.Width = 0;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "產品名稱";
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "數量";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "單位";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "庫存地點";
            this.columnHeader6.Width = 80;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "庫存狀態";
            this.columnHeader7.Width = 100;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "庫存時間";
            this.columnHeader8.Width = 300;
            // 
            // comboBox_Mode
            // 
            this.comboBox_Mode.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.comboBox_Mode.FormattingEnabled = true;
            this.comboBox_Mode.Location = new System.Drawing.Point(122, 35);
            this.comboBox_Mode.Name = "comboBox_Mode";
            this.comboBox_Mode.Size = new System.Drawing.Size(111, 31);
            this.comboBox_Mode.TabIndex = 2;
            this.comboBox_Mode.SelectedIndexChanged += new System.EventHandler(this.comboBox_Mode_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.label1.Location = new System.Drawing.Point(16, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "庫存狀態";
            // 
            // button_Increase
            // 
            this.button_Increase.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F);
            this.button_Increase.Location = new System.Drawing.Point(111, 209);
            this.button_Increase.Name = "button_Increase";
            this.button_Increase.Size = new System.Drawing.Size(55, 55);
            this.button_Increase.TabIndex = 4;
            this.button_Increase.Text = "+";
            this.button_Increase.UseVisualStyleBackColor = true;
            this.button_Increase.Click += new System.EventHandler(this.button_Increase_Click);
            this.button_Increase.MouseLeave += new System.EventHandler(this.button_Increase_Mouse_Leave);
            this.button_Increase.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button_Increase_Mouse_Move);
            // 
            // radioButton_Infeed
            // 
            this.radioButton_Infeed.AutoSize = true;
            this.radioButton_Infeed.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.radioButton_Infeed.Location = new System.Drawing.Point(114, 11);
            this.radioButton_Infeed.Name = "radioButton_Infeed";
            this.radioButton_Infeed.Size = new System.Drawing.Size(71, 27);
            this.radioButton_Infeed.TabIndex = 5;
            this.radioButton_Infeed.TabStop = true;
            this.radioButton_Infeed.Text = "入料";
            this.radioButton_Infeed.UseVisualStyleBackColor = true;
            this.radioButton_Infeed.CheckedChanged += new System.EventHandler(this.radioButton_Infeed_CheckedChanged);
            // 
            // textBox_Number
            // 
            this.textBox_Number.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.textBox_Number.Location = new System.Drawing.Point(233, 225);
            this.textBox_Number.Name = "textBox_Number";
            this.textBox_Number.Size = new System.Drawing.Size(45, 30);
            this.textBox_Number.TabIndex = 6;
            this.textBox_Number.TextChanged += new System.EventHandler(this.textBox_Number_TextChanged);
            // 
            // comboBox_Type
            // 
            this.comboBox_Type.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.comboBox_Type.FormattingEnabled = true;
            this.comboBox_Type.Location = new System.Drawing.Point(377, 35);
            this.comboBox_Type.Name = "comboBox_Type";
            this.comboBox_Type.Size = new System.Drawing.Size(111, 31);
            this.comboBox_Type.TabIndex = 2;
            this.comboBox_Type.SelectedIndexChanged += new System.EventHandler(this.comboBox_Type_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.label2.Location = new System.Drawing.Point(307, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "類型：";
            // 
            // comboBox_Name
            // 
            this.comboBox_Name.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.comboBox_Name.FormattingEnabled = true;
            this.comboBox_Name.Location = new System.Drawing.Point(673, 35);
            this.comboBox_Name.Name = "comboBox_Name";
            this.comboBox_Name.Size = new System.Drawing.Size(167, 31);
            this.comboBox_Name.TabIndex = 2;
            this.comboBox_Name.SelectedIndexChanged += new System.EventHandler(this.comboBox_Name_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.label3.Location = new System.Drawing.Point(567, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "產品名稱：";
            // 
            // comboBox_Place
            // 
            this.comboBox_Place.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.comboBox_Place.FormattingEnabled = true;
            this.comboBox_Place.Location = new System.Drawing.Point(1036, 35);
            this.comboBox_Place.Name = "comboBox_Place";
            this.comboBox_Place.Size = new System.Drawing.Size(111, 31);
            this.comboBox_Place.TabIndex = 2;
            this.comboBox_Place.SelectedIndexChanged += new System.EventHandler(this.comboBox_Place_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.label4.Location = new System.Drawing.Point(930, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "庫存地點：";
            // 
            // radioButton_Outfeed
            // 
            this.radioButton_Outfeed.AutoSize = true;
            this.radioButton_Outfeed.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.radioButton_Outfeed.Location = new System.Drawing.Point(191, 11);
            this.radioButton_Outfeed.Name = "radioButton_Outfeed";
            this.radioButton_Outfeed.Size = new System.Drawing.Size(71, 27);
            this.radioButton_Outfeed.TabIndex = 5;
            this.radioButton_Outfeed.TabStop = true;
            this.radioButton_Outfeed.Text = "出料";
            this.radioButton_Outfeed.UseVisualStyleBackColor = true;
            this.radioButton_Outfeed.CheckedChanged += new System.EventHandler(this.radioButton_Outfeed_CheckedChanged);
            // 
            // radioButton_Overflow
            // 
            this.radioButton_Overflow.AutoSize = true;
            this.radioButton_Overflow.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.radioButton_Overflow.Location = new System.Drawing.Point(114, 44);
            this.radioButton_Overflow.Name = "radioButton_Overflow";
            this.radioButton_Overflow.Size = new System.Drawing.Size(71, 27);
            this.radioButton_Overflow.TabIndex = 5;
            this.radioButton_Overflow.TabStop = true;
            this.radioButton_Overflow.Text = "溢出";
            this.radioButton_Overflow.UseVisualStyleBackColor = true;
            this.radioButton_Overflow.CheckedChanged += new System.EventHandler(this.radioButton_Overflow_CheckedChanged);
            // 
            // radioButton_Shortage
            // 
            this.radioButton_Shortage.AutoSize = true;
            this.radioButton_Shortage.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.radioButton_Shortage.Location = new System.Drawing.Point(191, 44);
            this.radioButton_Shortage.Name = "radioButton_Shortage";
            this.radioButton_Shortage.Size = new System.Drawing.Size(71, 27);
            this.radioButton_Shortage.TabIndex = 5;
            this.radioButton_Shortage.TabStop = true;
            this.radioButton_Shortage.Text = "短少";
            this.radioButton_Shortage.UseVisualStyleBackColor = true;
            this.radioButton_Shortage.CheckedChanged += new System.EventHandler(this.radioButton_Shortage_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.label5.Location = new System.Drawing.Point(173, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 23);
            this.label5.TabIndex = 3;
            this.label5.Text = "餘額：";
            // 
            // comboBox_AddType
            // 
            this.comboBox_AddType.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.comboBox_AddType.FormattingEnabled = true;
            this.comboBox_AddType.Location = new System.Drawing.Point(112, 87);
            this.comboBox_AddType.Name = "comboBox_AddType";
            this.comboBox_AddType.Size = new System.Drawing.Size(167, 31);
            this.comboBox_AddType.TabIndex = 2;
            this.comboBox_AddType.SelectedIndexChanged += new System.EventHandler(this.comboBox_AddType_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.label6.Location = new System.Drawing.Point(42, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 23);
            this.label6.TabIndex = 3;
            this.label6.Text = "類型：";
            // 
            // comboBox_AddName
            // 
            this.comboBox_AddName.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.comboBox_AddName.FormattingEnabled = true;
            this.comboBox_AddName.Location = new System.Drawing.Point(112, 124);
            this.comboBox_AddName.Name = "comboBox_AddName";
            this.comboBox_AddName.Size = new System.Drawing.Size(167, 31);
            this.comboBox_AddName.TabIndex = 2;
            this.comboBox_AddName.SelectedIndexChanged += new System.EventHandler(this.comboBox_AddName_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.label7.Location = new System.Drawing.Point(6, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 3;
            this.label7.Text = "產品名稱：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.label8.Location = new System.Drawing.Point(6, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 23);
            this.label8.TabIndex = 3;
            this.label8.Text = "庫存狀態：";
            // 
            // label_Count
            // 
            this.label_Count.AutoSize = true;
            this.label_Count.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.label_Count.Location = new System.Drawing.Point(115, 172);
            this.label_Count.Name = "label_Count";
            this.label_Count.Size = new System.Drawing.Size(20, 23);
            this.label_Count.TabIndex = 3;
            this.label_Count.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.label10.Location = new System.Drawing.Point(41, 225);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 23);
            this.label10.TabIndex = 3;
            this.label10.Text = "數量：";
            // 
            // label_Balance
            // 
            this.label_Balance.AutoSize = true;
            this.label_Balance.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.label_Balance.Location = new System.Drawing.Point(243, 172);
            this.label_Balance.Name = "label_Balance";
            this.label_Balance.Size = new System.Drawing.Size(20, 23);
            this.label_Balance.TabIndex = 3;
            this.label_Balance.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.label12.Location = new System.Drawing.Point(4, 172);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 23);
            this.label12.TabIndex = 3;
            this.label12.Text = "增減數量：";
            // 
            // button_Reduce
            // 
            this.button_Reduce.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F);
            this.button_Reduce.Location = new System.Drawing.Point(172, 209);
            this.button_Reduce.Name = "button_Reduce";
            this.button_Reduce.Size = new System.Drawing.Size(55, 55);
            this.button_Reduce.TabIndex = 4;
            this.button_Reduce.Text = "-";
            this.button_Reduce.UseVisualStyleBackColor = true;
            this.button_Reduce.Click += new System.EventHandler(this.button_Reduce_Click);
            this.button_Reduce.MouseLeave += new System.EventHandler(this.button_Reduce_Mouse_Leave);
            this.button_Reduce.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button_Reduce_Mouse_Move);
            // 
            // button_Confirm_Now
            // 
            this.button_Confirm_Now.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F);
            this.button_Confirm_Now.Location = new System.Drawing.Point(6, 284);
            this.button_Confirm_Now.Name = "button_Confirm_Now";
            this.button_Confirm_Now.Size = new System.Drawing.Size(202, 52);
            this.button_Confirm_Now.TabIndex = 4;
            this.button_Confirm_Now.Text = "加入現有食材";
            this.button_Confirm_Now.UseVisualStyleBackColor = true;
            this.button_Confirm_Now.Click += new System.EventHandler(this.button_Confirm_Now_Click);
            this.button_Confirm_Now.MouseLeave += new System.EventHandler(this.button_Confirm_Now_Mouse_Leave);
            this.button_Confirm_Now.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button_Confirm_Now_Mouse_Move);
            // 
            // button_Cancel_Now
            // 
            this.button_Cancel_Now.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F);
            this.button_Cancel_Now.Location = new System.Drawing.Point(214, 284);
            this.button_Cancel_Now.Name = "button_Cancel_Now";
            this.button_Cancel_Now.Size = new System.Drawing.Size(84, 52);
            this.button_Cancel_Now.TabIndex = 4;
            this.button_Cancel_Now.Text = "取消";
            this.button_Cancel_Now.UseVisualStyleBackColor = true;
            this.button_Cancel_Now.Click += new System.EventHandler(this.button_Cancel_Now_Click);
            this.button_Cancel_Now.MouseLeave += new System.EventHandler(this.button_Cancel_Now_Mouse_Leave);
            this.button_Cancel_Now.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button_Cancel_Now_Mouse_Move);
            // 
            // button_Save
            // 
            this.button_Save.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F);
            this.button_Save.Location = new System.Drawing.Point(8, 342);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(84, 52);
            this.button_Save.TabIndex = 4;
            this.button_Save.Text = "儲存";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            this.button_Save.MouseLeave += new System.EventHandler(this.button_Save_Mouse_Leave);
            this.button_Save.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button_Save_Mouse_Move);
            // 
            // button_Remove
            // 
            this.button_Remove.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F);
            this.button_Remove.Location = new System.Drawing.Point(98, 343);
            this.button_Remove.Name = "button_Remove";
            this.button_Remove.Size = new System.Drawing.Size(110, 52);
            this.button_Remove.TabIndex = 4;
            this.button_Remove.Text = "移除列";
            this.button_Remove.UseVisualStyleBackColor = true;
            this.button_Remove.Click += new System.EventHandler(this.button_Remove_Click);
            this.button_Remove.MouseLeave += new System.EventHandler(this.button_Remove_Mouse_Leave);
            this.button_Remove.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button_Remove_Mouse_Move);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.label13.Location = new System.Drawing.Point(8, 91);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 23);
            this.label13.TabIndex = 3;
            this.label13.Text = "產品編號：";
            // 
            // textBox_AddType
            // 
            this.textBox_AddType.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.textBox_AddType.Location = new System.Drawing.Point(114, 9);
            this.textBox_AddType.Name = "textBox_AddType";
            this.textBox_AddType.Size = new System.Drawing.Size(110, 30);
            this.textBox_AddType.TabIndex = 6;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.label14.Location = new System.Drawing.Point(44, 172);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 23);
            this.label14.TabIndex = 3;
            this.label14.Text = "單位：";
            // 
            // textBox_AddName
            // 
            this.textBox_AddName.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.textBox_AddName.Location = new System.Drawing.Point(114, 49);
            this.textBox_AddName.Name = "textBox_AddName";
            this.textBox_AddName.Size = new System.Drawing.Size(110, 30);
            this.textBox_AddName.TabIndex = 6;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.label15.Location = new System.Drawing.Point(8, 212);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 23);
            this.label15.TabIndex = 3;
            this.label15.Text = "庫存地點：";
            // 
            // textBox_AddNum
            // 
            this.textBox_AddNum.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.textBox_AddNum.Location = new System.Drawing.Point(114, 87);
            this.textBox_AddNum.Name = "textBox_AddNum";
            this.textBox_AddNum.Size = new System.Drawing.Size(110, 30);
            this.textBox_AddNum.TabIndex = 6;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.label16.Location = new System.Drawing.Point(8, 53);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(100, 23);
            this.label16.TabIndex = 3;
            this.label16.Text = "產品名稱：";
            // 
            // textBox_AddCount
            // 
            this.textBox_AddCount.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.textBox_AddCount.Location = new System.Drawing.Point(114, 126);
            this.textBox_AddCount.Name = "textBox_AddCount";
            this.textBox_AddCount.Size = new System.Drawing.Size(110, 30);
            this.textBox_AddCount.TabIndex = 6;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.label17.Location = new System.Drawing.Point(44, 13);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(64, 23);
            this.label17.TabIndex = 3;
            this.label17.Text = "類型：";
            // 
            // textBox_AddUnit
            // 
            this.textBox_AddUnit.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.textBox_AddUnit.Location = new System.Drawing.Point(114, 168);
            this.textBox_AddUnit.Name = "textBox_AddUnit";
            this.textBox_AddUnit.Size = new System.Drawing.Size(110, 30);
            this.textBox_AddUnit.TabIndex = 6;
            // 
            // button_Confirm_New
            // 
            this.button_Confirm_New.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F);
            this.button_Confirm_New.Location = new System.Drawing.Point(6, 252);
            this.button_Confirm_New.Name = "button_Confirm_New";
            this.button_Confirm_New.Size = new System.Drawing.Size(202, 52);
            this.button_Confirm_New.TabIndex = 4;
            this.button_Confirm_New.Text = "加入新食材";
            this.button_Confirm_New.UseVisualStyleBackColor = true;
            this.button_Confirm_New.Click += new System.EventHandler(this.button_Confirm_New_Click);
            this.button_Confirm_New.MouseLeave += new System.EventHandler(this.button_Confirm_New_Mouse_Leave);
            this.button_Confirm_New.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button_Confirm_New_Mouse_Move);
            // 
            // button_Cancel_New
            // 
            this.button_Cancel_New.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F);
            this.button_Cancel_New.Location = new System.Drawing.Point(214, 253);
            this.button_Cancel_New.Name = "button_Cancel_New";
            this.button_Cancel_New.Size = new System.Drawing.Size(84, 52);
            this.button_Cancel_New.TabIndex = 4;
            this.button_Cancel_New.Text = "取消";
            this.button_Cancel_New.UseVisualStyleBackColor = true;
            this.button_Cancel_New.Click += new System.EventHandler(this.button_Cancel_New_Click);
            this.button_Cancel_New.MouseLeave += new System.EventHandler(this.button_Cancel_New_Mouse_Leave);
            this.button_Cancel_New.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button_Cancel_New_Mouse_Move);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.label9.Location = new System.Drawing.Point(44, 130);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 23);
            this.label9.TabIndex = 3;
            this.label9.Text = "數量：";
            // 
            // textBox_AddPlace
            // 
            this.textBox_AddPlace.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.textBox_AddPlace.Location = new System.Drawing.Point(114, 209);
            this.textBox_AddPlace.Name = "textBox_AddPlace";
            this.textBox_AddPlace.Size = new System.Drawing.Size(110, 30);
            this.textBox_AddPlace.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.comboBox_AddType);
            this.groupBox1.Controls.Add(this.comboBox_AddName);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label_Count);
            this.groupBox1.Controls.Add(this.textBox_Number);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.radioButton_Shortage);
            this.groupBox1.Controls.Add(this.label_Balance);
            this.groupBox1.Controls.Add(this.radioButton_Overflow);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.radioButton_Outfeed);
            this.groupBox1.Controls.Add(this.button_Increase);
            this.groupBox1.Controls.Add(this.radioButton_Infeed);
            this.groupBox1.Controls.Add(this.button_Reduce);
            this.groupBox1.Controls.Add(this.button_Confirm_Now);
            this.groupBox1.Controls.Add(this.button_Cancel_Now);
            this.groupBox1.Controls.Add(this.button_Remove);
            this.groupBox1.Controls.Add(this.button_Save);
            this.groupBox1.Location = new System.Drawing.Point(1156, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 403);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupBox1_Paint);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_AddNum);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.button_Cancel_New);
            this.groupBox2.Controls.Add(this.button_Confirm_New);
            this.groupBox2.Controls.Add(this.textBox_AddPlace);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.textBox_AddUnit);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.textBox_AddCount);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.textBox_AddName);
            this.groupBox2.Controls.Add(this.textBox_AddType);
            this.groupBox2.Location = new System.Drawing.Point(1156, 482);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(306, 312);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Paint += new System.Windows.Forms.PaintEventHandler(this.groupBox2_Paint);
            // 
            // Stuff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1459, 797);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_Place);
            this.Controls.Add(this.comboBox_Name);
            this.Controls.Add(this.comboBox_Type);
            this.Controls.Add(this.comboBox_Mode);
            this.Controls.Add(this.listView_In);
            this.Name = "Stuff";
            this.Text = "Stuff";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView_In;
        private System.Windows.Forms.ComboBox comboBox_Mode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Increase;
        private System.Windows.Forms.RadioButton radioButton_Infeed;
        private System.Windows.Forms.TextBox textBox_Number;
        private System.Windows.Forms.ComboBox comboBox_Type;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_Name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_Place;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButton_Outfeed;
        private System.Windows.Forms.RadioButton radioButton_Overflow;
        private System.Windows.Forms.RadioButton radioButton_Shortage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_AddType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox_AddName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label_Count;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label_Balance;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button_Reduce;
        private System.Windows.Forms.Button button_Confirm_Now;
        private System.Windows.Forms.Button button_Cancel_Now;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Button button_Remove;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox_AddType;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox_AddName;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox_AddNum;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox_AddCount;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBox_AddUnit;
        private System.Windows.Forms.Button button_Confirm_New;
        private System.Windows.Forms.Button button_Cancel_New;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_AddPlace;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}