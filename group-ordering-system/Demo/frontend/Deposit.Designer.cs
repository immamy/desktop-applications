namespace WinFormsApp_Meal_expense_accounting
{
    partial class Deposit
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
            label_Department = new Label();
            label_Name = new Label();
            label_Deposit = new Label();
            comboBox_Department = new ComboBox();
            textBox_Deposit = new TextBox();
            comboBox_Name = new ComboBox();
            label_Average = new Label();
            label_Total = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label_Num = new Label();
            label_Standard = new Label();
            label12 = new Label();
            label_Standard_Num = new Label();
            listView_Deposit = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            button_Write = new Button();
            button_Save = new Button();
            listView_Balance = new ListView();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            button_Remove_Deposit = new Button();
            button_Refresh = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // label_Department
            // 
            label_Department.AutoSize = true;
            label_Department.Location = new Point(150, 139);
            label_Department.Name = "label_Department";
            label_Department.Size = new Size(64, 23);
            label_Department.TabIndex = 4;
            label_Department.Text = "部門：";
            // 
            // label_Name
            // 
            label_Name.AutoSize = true;
            label_Name.Location = new Point(150, 177);
            label_Name.Name = "label_Name";
            label_Name.Size = new Size(64, 23);
            label_Name.TabIndex = 4;
            label_Name.Text = "姓名：";
            // 
            // label_Deposit
            // 
            label_Deposit.AutoSize = true;
            label_Deposit.Location = new Point(150, 214);
            label_Deposit.Name = "label_Deposit";
            label_Deposit.Size = new Size(64, 23);
            label_Deposit.TabIndex = 4;
            label_Deposit.Text = "儲值：";
            // 
            // comboBox_Department
            // 
            comboBox_Department.FormattingEnabled = true;
            comboBox_Department.Location = new Point(220, 136);
            comboBox_Department.Name = "comboBox_Department";
            comboBox_Department.Size = new Size(150, 31);
            comboBox_Department.TabIndex = 5;
            comboBox_Department.SelectedIndexChanged += comboBox_Department_SelectedIndexChanged;
            comboBox_Department.MouseMove += comboBox_Department_Mouse_Move;
            // 
            // textBox_Deposit
            // 
            textBox_Deposit.Location = new Point(220, 211);
            textBox_Deposit.Name = "textBox_Deposit";
            textBox_Deposit.Size = new Size(150, 30);
            textBox_Deposit.TabIndex = 6;
            // 
            // comboBox_Name
            // 
            comboBox_Name.FormattingEnabled = true;
            comboBox_Name.Location = new Point(220, 174);
            comboBox_Name.Name = "comboBox_Name";
            comboBox_Name.Size = new Size(150, 31);
            comboBox_Name.TabIndex = 5;
            comboBox_Name.SelectedIndexChanged += comboBox_Name_SelectedIndexChanged;
            comboBox_Name.MouseMove += comboBox_Name_Mouse_Move;
            // 
            // label_Average
            // 
            label_Average.AutoSize = true;
            label_Average.Location = new Point(868, 178);
            label_Average.Name = "label_Average";
            label_Average.Size = new Size(61, 23);
            label_Average.TabIndex = 27;
            label_Average.Text = "label7";
            // 
            // label_Total
            // 
            label_Total.AutoSize = true;
            label_Total.Location = new Point(868, 144);
            label_Total.Name = "label_Total";
            label_Total.Size = new Size(61, 23);
            label_Total.TabIndex = 28;
            label_Total.Text = "label7";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(711, 178);
            label6.Name = "label6";
            label6.Size = new Size(82, 23);
            label6.TabIndex = 25;
            label6.Text = "平均值：";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(711, 144);
            label7.Name = "label7";
            label7.Size = new Size(118, 23);
            label7.TabIndex = 26;
            label7.Text = "零用金總額：";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(711, 211);
            label8.Name = "label8";
            label8.Size = new Size(82, 23);
            label8.TabIndex = 26;
            label8.Text = "總人數：";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(711, 245);
            label9.Name = "label9";
            label9.Size = new Size(82, 23);
            label9.TabIndex = 25;
            label9.Text = "標準值：";
            // 
            // label_Num
            // 
            label_Num.AutoSize = true;
            label_Num.Location = new Point(868, 211);
            label_Num.Name = "label_Num";
            label_Num.Size = new Size(61, 23);
            label_Num.TabIndex = 28;
            label_Num.Text = "label7";
            // 
            // label_Standard
            // 
            label_Standard.AutoSize = true;
            label_Standard.Location = new Point(868, 245);
            label_Standard.Name = "label_Standard";
            label_Standard.Size = new Size(61, 23);
            label_Standard.TabIndex = 27;
            label_Standard.Text = "label7";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(711, 277);
            label12.Name = "label12";
            label12.Size = new Size(154, 23);
            label12.TabIndex = 25;
            label12.Text = "低於標準值人數：";
            // 
            // label_Standard_Num
            // 
            label_Standard_Num.AutoSize = true;
            label_Standard_Num.Location = new Point(868, 277);
            label_Standard_Num.Name = "label_Standard_Num";
            label_Standard_Num.Size = new Size(61, 23);
            label_Standard_Num.TabIndex = 27;
            label_Standard_Num.Text = "label7";
            // 
            // listView_Deposit
            // 
            listView_Deposit.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader7 });
            listView_Deposit.FullRowSelect = true;
            listView_Deposit.GridLines = true;
            listView_Deposit.Location = new Point(12, 393);
            listView_Deposit.Name = "listView_Deposit";
            listView_Deposit.Size = new Size(560, 515);
            listView_Deposit.TabIndex = 29;
            listView_Deposit.UseCompatibleStateImageBehavior = false;
            listView_Deposit.View = View.Details;
            listView_Deposit.ColumnClick += listView_Deposit_ColumnClick;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "部門";
            columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "姓名";
            columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "儲值";
            columnHeader3.TextAlign = HorizontalAlignment.Right;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "日期";
            columnHeader7.Width = 250;
            // 
            // button_Write
            // 
            button_Write.Location = new Point(220, 247);
            button_Write.Name = "button_Write";
            button_Write.Size = new Size(78, 34);
            button_Write.TabIndex = 30;
            button_Write.Text = "寫入";
            button_Write.UseVisualStyleBackColor = true;
            button_Write.Click += button_Write_Click;
            button_Write.MouseLeave += button_Write_Mouse_Leave;
            button_Write.MouseMove += button_Write_Mouse_Move;
            // 
            // button_Save
            // 
            button_Save.Location = new Point(326, 353);
            button_Save.Name = "button_Save";
            button_Save.Size = new Size(78, 34);
            button_Save.TabIndex = 30;
            button_Save.Text = "儲存";
            button_Save.UseVisualStyleBackColor = true;
            button_Save.Click += button_Save_Click;
            button_Save.MouseLeave += button_Save_Mouse_Leave;
            button_Save.MouseMove += button_Save_Mouse_Move;
            // 
            // listView_Balance
            // 
            listView_Balance.Columns.AddRange(new ColumnHeader[] { columnHeader4, columnHeader5, columnHeader6, columnHeader8 });
            listView_Balance.FullRowSelect = true;
            listView_Balance.GridLines = true;
            listView_Balance.Location = new Point(587, 393);
            listView_Balance.Name = "listView_Balance";
            listView_Balance.Size = new Size(560, 515);
            listView_Balance.TabIndex = 32;
            listView_Balance.UseCompatibleStateImageBehavior = false;
            listView_Balance.View = View.Details;
            listView_Balance.ColumnClick += listView_Balance_ColumnClick;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "部門";
            columnHeader4.Width = 200;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "姓名";
            columnHeader5.Width = 80;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "餘額";
            columnHeader6.TextAlign = HorizontalAlignment.Right;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "更新日期";
            columnHeader8.Width = 250;
            // 
            // button_Remove_Deposit
            // 
            button_Remove_Deposit.Location = new Point(494, 353);
            button_Remove_Deposit.Name = "button_Remove_Deposit";
            button_Remove_Deposit.Size = new Size(78, 34);
            button_Remove_Deposit.TabIndex = 34;
            button_Remove_Deposit.Text = "移除列";
            button_Remove_Deposit.UseVisualStyleBackColor = true;
            button_Remove_Deposit.Click += button_Remove_Deposit_Click;
            button_Remove_Deposit.MouseLeave += button_Remove_Deposit_Mouse_Leave;
            button_Remove_Deposit.MouseMove += button_Remove_Deposit_Mouse_Move;
            // 
            // button_Refresh
            // 
            button_Refresh.Location = new Point(410, 353);
            button_Refresh.Name = "button_Refresh";
            button_Refresh.Size = new Size(78, 34);
            button_Refresh.TabIndex = 35;
            button_Refresh.Text = "還原";
            button_Refresh.UseVisualStyleBackColor = true;
            button_Refresh.Click += button_Refresh_Click;
            button_Refresh.MouseLeave += button_Refresh_Mouse_Leave;
            button_Refresh.MouseMove += button_Refresh_Mouse_Move;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 359);
            label1.Name = "label1";
            label1.Size = new Size(76, 23);
            label1.TabIndex = 37;
            label1.Text = "Deposit";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(605, 359);
            label2.Name = "label2";
            label2.Size = new Size(76, 23);
            label2.TabIndex = 37;
            label2.Text = "Balance";
            // 
            // Deposit
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1159, 920);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button_Refresh);
            Controls.Add(button_Remove_Deposit);
            Controls.Add(listView_Balance);
            Controls.Add(button_Save);
            Controls.Add(button_Write);
            Controls.Add(listView_Deposit);
            Controls.Add(label_Standard_Num);
            Controls.Add(label_Standard);
            Controls.Add(label_Average);
            Controls.Add(label_Num);
            Controls.Add(label12);
            Controls.Add(label_Total);
            Controls.Add(label9);
            Controls.Add(label6);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(textBox_Deposit);
            Controls.Add(comboBox_Name);
            Controls.Add(comboBox_Department);
            Controls.Add(label_Deposit);
            Controls.Add(label_Name);
            Controls.Add(label_Department);
            Name = "Deposit";
            Text = "Deposit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_Department;
        private Label label_Name;
        private Label label_Deposit;
        private ComboBox comboBox_Department;
        private TextBox textBox_Deposit;
        private ComboBox comboBox_Name;
        private Label label_Average;
        private Label label_Total;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label_Num;
        private Label label_Standard;
        private Label label12;
        private Label label_Standard_Num;
        private ListView listView_Deposit;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Button button_Write;
        private Button button_Save;
        private ListView listView1;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ListView listView_Balance;
        private Button button_Remove_Deposit;
        private Button button_Refresh;
        private Label label1;
        private Label label2;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
    }
}