using System.Windows.Forms;

namespace WinFormsApp_Meal_expense_accounting
{
    partial class Details
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
            comboBox_Name = new ComboBox();
            comboBox_Department = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            dateTimePicker_Start = new DateTimePicker();
            label5 = new Label();
            label6 = new Label();
            label_Department = new Label();
            label_Name = new Label();
            listView_Detail = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            label9 = new Label();
            label_Balance = new Label();
            label4 = new Label();
            button_Download_Person = new Button();
            button_Download_People = new Button();
            button_Download_allData = new Button();
            label7 = new Label();
            dateTimePicker_End = new DateTimePicker();
            label8 = new Label();
            label3 = new Label();
            label10 = new Label();
            dateTimePicker_Setting = new DateTimePicker();
            label_Hint = new Label();
            label11 = new Label();
            SuspendLayout();
            // 
            // comboBox_Name
            // 
            comboBox_Name.FormattingEnabled = true;
            comboBox_Name.Location = new Point(528, 86);
            comboBox_Name.Name = "comboBox_Name";
            comboBox_Name.Size = new Size(150, 31);
            comboBox_Name.TabIndex = 10;
            comboBox_Name.SelectedIndexChanged += comboBox_Name_SelectedIndexChanged;
            comboBox_Name.MouseMove += comboBox_Name_Mouse_Move;
            // 
            // comboBox_Department
            // 
            comboBox_Department.FormattingEnabled = true;
            comboBox_Department.Location = new Point(528, 50);
            comboBox_Department.Name = "comboBox_Department";
            comboBox_Department.Size = new Size(150, 31);
            comboBox_Department.TabIndex = 11;
            comboBox_Department.SelectedIndexChanged += comboBox_Department_SelectedIndexChanged;
            comboBox_Department.MouseMove += comboBox_Department_Mouse_Move;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(458, 89);
            label2.Name = "label2";
            label2.Size = new Size(64, 23);
            label2.TabIndex = 8;
            label2.Text = "姓名：";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(458, 53);
            label1.Name = "label1";
            label1.Size = new Size(55, 23);
            label1.TabIndex = 9;
            label1.Text = "部門 :";
            // 
            // dateTimePicker_Start
            // 
            dateTimePicker_Start.Location = new Point(85, 56);
            dateTimePicker_Start.Name = "dateTimePicker_Start";
            dateTimePicker_Start.Size = new Size(210, 30);
            dateTimePicker_Start.TabIndex = 12;
            dateTimePicker_Start.ValueChanged += dateTimePicker_Start_ValueChanged;
            dateTimePicker_Start.MouseMove += dateTimePicker_Start_Mouse_Move;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 230);
            label5.Name = "label5";
            label5.Size = new Size(55, 23);
            label5.TabIndex = 9;
            label5.Text = "部門 :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(286, 230);
            label6.Name = "label6";
            label6.Size = new Size(64, 23);
            label6.TabIndex = 8;
            label6.Text = "姓名：";
            // 
            // label_Department
            // 
            label_Department.AutoSize = true;
            label_Department.Location = new Point(85, 230);
            label_Department.Name = "label_Department";
            label_Department.Size = new Size(61, 23);
            label_Department.TabIndex = 14;
            label_Department.Text = "label7";
            // 
            // label_Name
            // 
            label_Name.AutoSize = true;
            label_Name.Location = new Point(344, 230);
            label_Name.Name = "label_Name";
            label_Name.Size = new Size(61, 23);
            label_Name.TabIndex = 14;
            label_Name.Text = "label7";
            // 
            // listView_Detail
            // 
            listView_Detail.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader6, columnHeader8 });
            listView_Detail.FullRowSelect = true;
            listView_Detail.GridLines = true;
            listView_Detail.Location = new Point(12, 266);
            listView_Detail.Name = "listView_Detail";
            listView_Detail.Size = new Size(1135, 642);
            listView_Detail.TabIndex = 15;
            listView_Detail.UseCompatibleStateImageBehavior = false;
            listView_Detail.View = View.Details;
            listView_Detail.ColumnClick += listView_Detail_ColumnClick;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "部門";
            columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "姓名";
            columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "儲值";
            columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "消費";
            columnHeader4.Width = 80;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "備註";
            columnHeader6.Width = 220;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "日期";
            columnHeader8.Width = 250;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(519, 230);
            label9.Name = "label9";
            label9.Size = new Size(64, 23);
            label9.TabIndex = 8;
            label9.Text = "餘額：";
            // 
            // label_Balance
            // 
            label_Balance.AutoSize = true;
            label_Balance.Location = new Point(577, 230);
            label_Balance.Name = "label_Balance";
            label_Balance.Size = new Size(61, 23);
            label_Balance.TabIndex = 14;
            label_Balance.Text = "label7";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(301, 61);
            label4.Name = "label4";
            label4.Size = new Size(28, 23);
            label4.TabIndex = 9;
            label4.Text = "～";
            // 
            // button_Download_Person
            // 
            button_Download_Person.Location = new Point(528, 123);
            button_Download_Person.Name = "button_Download_Person";
            button_Download_Person.Size = new Size(78, 34);
            button_Download_Person.TabIndex = 16;
            button_Download_Person.Text = "個人";
            button_Download_Person.UseVisualStyleBackColor = true;
            button_Download_Person.Click += button_Download_Person_Click;
            button_Download_Person.MouseLeave += button_Download_Person_Mouse_Leave;
            button_Download_Person.MouseMove += button_Download_Person_Mouse_Move;
            // 
            // button_Download_People
            // 
            button_Download_People.Location = new Point(914, 93);
            button_Download_People.Name = "button_Download_People";
            button_Download_People.Size = new Size(78, 34);
            button_Download_People.TabIndex = 16;
            button_Download_People.Text = "所有人";
            button_Download_People.UseVisualStyleBackColor = true;
            button_Download_People.Click += button_Download_People_Click;
            button_Download_People.MouseLeave += button_Download_People_Mouse_Leave;
            button_Download_People.MouseMove += button_Download_People_Mouse_Move;
            // 
            // button_Download_allData
            // 
            button_Download_allData.Location = new Point(914, 224);
            button_Download_allData.Name = "button_Download_allData";
            button_Download_allData.Size = new Size(78, 34);
            button_Download_allData.TabIndex = 16;
            button_Download_allData.Text = "總表";
            button_Download_allData.UseVisualStyleBackColor = true;
            button_Download_allData.Click += button_Download_allData_Click;
            button_Download_allData.MouseLeave += button_Download_allData_Mouse_Leave;
            button_Download_allData.MouseMove += button_Download_allData_Mouse_Move;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(404, 129);
            label7.Name = "label7";
            label7.Size = new Size(118, 23);
            label7.TabIndex = 9;
            label7.Text = "下載資料表：";
            // 
            // dateTimePicker_End
            // 
            dateTimePicker_End.Location = new Point(85, 92);
            dateTimePicker_End.Name = "dateTimePicker_End";
            dateTimePicker_End.Size = new Size(210, 30);
            dateTimePicker_End.TabIndex = 12;
            dateTimePicker_End.ValueChanged += dateTimePicker_End_ValueChanged;
            dateTimePicker_End.MouseMove += dateTimePicker_End_Mouse_Move;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(15, 63);
            label8.Name = "label8";
            label8.Size = new Size(64, 23);
            label8.TabIndex = 9;
            label8.Text = "日期：";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(790, 96);
            label3.Name = "label3";
            label3.Size = new Size(118, 23);
            label3.TabIndex = 9;
            label3.Text = "下載資料表：";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(808, 61);
            label10.Name = "label10";
            label10.Size = new Size(100, 23);
            label10.TabIndex = 9;
            label10.Text = "起始日期：";
            // 
            // dateTimePicker_Setting
            // 
            dateTimePicker_Setting.Location = new Point(914, 57);
            dateTimePicker_Setting.Name = "dateTimePicker_Setting";
            dateTimePicker_Setting.Size = new Size(210, 30);
            dateTimePicker_Setting.TabIndex = 12;
            dateTimePicker_Setting.MouseMove += dateTimePicker_Setting_Mouse_Move;
            // 
            // label_Hint
            // 
            label_Hint.AutoSize = true;
            label_Hint.Location = new Point(1005, 99);
            label_Hint.Name = "label_Hint";
            label_Hint.Size = new Size(71, 23);
            label_Hint.TabIndex = 8;
            label_Hint.Text = "label11";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(790, 230);
            label11.Name = "label11";
            label11.Size = new Size(118, 23);
            label11.TabIndex = 9;
            label11.Text = "下載資料表：";
            // 
            // Details
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1159, 920);
            Controls.Add(button_Download_allData);
            Controls.Add(button_Download_People);
            Controls.Add(button_Download_Person);
            Controls.Add(listView_Detail);
            Controls.Add(label_Balance);
            Controls.Add(label_Name);
            Controls.Add(label_Department);
            Controls.Add(dateTimePicker_End);
            Controls.Add(dateTimePicker_Setting);
            Controls.Add(dateTimePicker_Start);
            Controls.Add(comboBox_Name);
            Controls.Add(label9);
            Controls.Add(comboBox_Department);
            Controls.Add(label6);
            Controls.Add(label_Hint);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label11);
            Controls.Add(label7);
            Controls.Add(label10);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(label1);
            Name = "Details";
            Text = "Details";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox comboBox_Name;
        private ComboBox comboBox_Department;
        private Label label2;
        private Label label1;
        private DateTimePicker dateTimePicker_Start;
        private Label label5;
        private Label label6;
        private Label label_Department;
        private Label label_Name;
        private ListView listView_Detail;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private Label label9;
        private Label label_Balance;
        private Label label4;
        private Button button_Download_Person;
        private Button button_Download_People;
        private Button button_Download_allData;
        private Label label7;
        private DateTimePicker dateTimePicker_End;
        private ListView listView_Date;
        private Button button_Add;
        private Label label8;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader7;
        private Button button_Save;
        private DateTimePicker dateTimePicker_Today;
        private ColumnHeader columnHeader8;
        private Label label3;
        private Label label10;
        private DateTimePicker dateTimePicker_Setting;
        private Label label_Hint;
        private Label label11;
    }
}