namespace WinFormsApp_Meal_expense_accounting
{
    partial class Setting
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
            listView_Setting = new ListView();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            comboBox_Permissions = new ComboBox();
            label5 = new Label();
            button_Remove = new Button();
            button_Refresh = new Button();
            button_Save = new Button();
            textBox_Password_3 = new TextBox();
            textBox_Password_4 = new TextBox();
            textBox_Access_3 = new TextBox();
            textBox_Access_4 = new TextBox();
            textBox_Password_2 = new TextBox();
            textBox_Access_2 = new TextBox();
            label3 = new Label();
            textBox_Password_1 = new TextBox();
            textBox_Access_1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            label6 = new Label();
            button_Clear = new Button();
            button_Add = new Button();
            comboBox_Permissions_1 = new ComboBox();
            comboBox_Permissions_2 = new ComboBox();
            comboBox_Permissions_3 = new ComboBox();
            comboBox_Permissions_4 = new ComboBox();
            comboBox_Department_1 = new ComboBox();
            comboBox_Department_2 = new ComboBox();
            comboBox_Department_3 = new ComboBox();
            comboBox_Department_4 = new ComboBox();
            comboBox_Name_1 = new ComboBox();
            comboBox_Name_2 = new ComboBox();
            comboBox_Name_3 = new ComboBox();
            comboBox_Name_4 = new ComboBox();
            SuspendLayout();
            // 
            // listView_Setting
            // 
            listView_Setting.Columns.AddRange(new ColumnHeader[] { columnHeader6, columnHeader7, columnHeader8, columnHeader1, columnHeader2 });
            listView_Setting.FullRowSelect = true;
            listView_Setting.GridLines = true;
            listView_Setting.Location = new Point(148, 304);
            listView_Setting.Name = "listView_Setting";
            listView_Setting.Size = new Size(796, 570);
            listView_Setting.TabIndex = 60;
            listView_Setting.UseCompatibleStateImageBehavior = false;
            listView_Setting.View = View.Details;
            listView_Setting.ColumnClick += listView_Setting_ColumnClick;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "權限";
            columnHeader6.Width = 120;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "帳號";
            columnHeader7.Width = 200;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "密碼";
            columnHeader8.Width = 120;
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
            // comboBox_Permissions
            // 
            comboBox_Permissions.FormattingEnabled = true;
            comboBox_Permissions.Location = new Point(219, 267);
            comboBox_Permissions.Name = "comboBox_Permissions";
            comboBox_Permissions.Size = new Size(150, 31);
            comboBox_Permissions.TabIndex = 59;
            comboBox_Permissions.SelectedIndexChanged += comboBox_Permissions_SelectedIndexChanged;
            comboBox_Permissions.MouseMove += comboBox_Permissions_Mouse_Move;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(157, 270);
            label5.Name = "label5";
            label5.Size = new Size(64, 23);
            label5.TabIndex = 58;
            label5.Text = "權限：";
            // 
            // button_Remove
            // 
            button_Remove.Location = new Point(866, 264);
            button_Remove.Name = "button_Remove";
            button_Remove.Size = new Size(78, 34);
            button_Remove.TabIndex = 55;
            button_Remove.Text = "移除列";
            button_Remove.UseVisualStyleBackColor = true;
            button_Remove.Click += button_Remove_Click;
            button_Remove.MouseLeave += button_Remove_Mouse_Leave;
            button_Remove.MouseMove += button_Remove_Mouse_Move;
            // 
            // button_Refresh
            // 
            button_Refresh.Location = new Point(782, 264);
            button_Refresh.Name = "button_Refresh";
            button_Refresh.Size = new Size(78, 34);
            button_Refresh.TabIndex = 57;
            button_Refresh.Text = "還原";
            button_Refresh.UseVisualStyleBackColor = true;
            button_Refresh.Click += button_Refresh_Click;
            button_Refresh.MouseLeave += button_Refresh_Mouse_Leave;
            button_Refresh.MouseMove += button_Refresh_Mouse_Move;
            // 
            // button_Save
            // 
            button_Save.Location = new Point(698, 264);
            button_Save.Name = "button_Save";
            button_Save.Size = new Size(78, 34);
            button_Save.TabIndex = 56;
            button_Save.Text = "儲存";
            button_Save.UseVisualStyleBackColor = true;
            button_Save.Click += button_Save_Click;
            button_Save.MouseLeave += button_Save_Mouse_Leave;
            button_Save.MouseMove += button_Save_Mouse_Move;
            // 
            // textBox_Password_3
            // 
            textBox_Password_3.Location = new Point(469, 169);
            textBox_Password_3.Name = "textBox_Password_3";
            textBox_Password_3.Size = new Size(153, 30);
            textBox_Password_3.TabIndex = 41;
            // 
            // textBox_Password_4
            // 
            textBox_Password_4.Location = new Point(469, 205);
            textBox_Password_4.Name = "textBox_Password_4";
            textBox_Password_4.Size = new Size(153, 30);
            textBox_Password_4.TabIndex = 39;
            // 
            // textBox_Access_3
            // 
            textBox_Access_3.Location = new Point(309, 169);
            textBox_Access_3.Name = "textBox_Access_3";
            textBox_Access_3.Size = new Size(153, 30);
            textBox_Access_3.TabIndex = 40;
            // 
            // textBox_Access_4
            // 
            textBox_Access_4.Location = new Point(309, 205);
            textBox_Access_4.Name = "textBox_Access_4";
            textBox_Access_4.Size = new Size(153, 30);
            textBox_Access_4.TabIndex = 44;
            // 
            // textBox_Password_2
            // 
            textBox_Password_2.Location = new Point(469, 133);
            textBox_Password_2.Name = "textBox_Password_2";
            textBox_Password_2.Size = new Size(153, 30);
            textBox_Password_2.TabIndex = 48;
            // 
            // textBox_Access_2
            // 
            textBox_Access_2.Location = new Point(309, 133);
            textBox_Access_2.Name = "textBox_Access_2";
            textBox_Access_2.Size = new Size(153, 30);
            textBox_Access_2.TabIndex = 49;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(683, 67);
            label3.Name = "label3";
            label3.Size = new Size(46, 23);
            label3.TabIndex = 34;
            label3.Text = "部門";
            // 
            // textBox_Password_1
            // 
            textBox_Password_1.Location = new Point(469, 97);
            textBox_Password_1.Name = "textBox_Password_1";
            textBox_Password_1.Size = new Size(153, 30);
            textBox_Password_1.TabIndex = 51;
            // 
            // textBox_Access_1
            // 
            textBox_Access_1.Location = new Point(309, 97);
            textBox_Access_1.Name = "textBox_Access_1";
            textBox_Access_1.Size = new Size(153, 30);
            textBox_Access_1.TabIndex = 52;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(523, 67);
            label2.Name = "label2";
            label2.Size = new Size(46, 23);
            label2.TabIndex = 33;
            label2.Text = "密碼";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(363, 67);
            label1.Name = "label1";
            label1.Size = new Size(46, 23);
            label1.TabIndex = 32;
            label1.Text = "帳號";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(845, 67);
            label4.Name = "label4";
            label4.Size = new Size(46, 23);
            label4.TabIndex = 31;
            label4.Text = "姓名";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(202, 67);
            label6.Name = "label6";
            label6.Size = new Size(46, 23);
            label6.TabIndex = 30;
            label6.Text = "權限";
            // 
            // button_Clear
            // 
            button_Clear.Location = new Point(968, 137);
            button_Clear.Name = "button_Clear";
            button_Clear.Size = new Size(101, 34);
            button_Clear.TabIndex = 28;
            button_Clear.Text = "全部清除";
            button_Clear.UseVisualStyleBackColor = true;
            button_Clear.Click += button_Clear_Click;
            button_Clear.MouseLeave += button_Clear_Mouse_Leave;
            button_Clear.MouseMove += button_Clear_Mouse_Move;
            // 
            // button_Add
            // 
            button_Add.Location = new Point(968, 97);
            button_Add.Name = "button_Add";
            button_Add.Size = new Size(101, 34);
            button_Add.TabIndex = 29;
            button_Add.Text = "全部加入";
            button_Add.UseVisualStyleBackColor = true;
            button_Add.Click += button_Add_Click;
            button_Add.MouseLeave += button_Add_Mouse_Leave;
            button_Add.MouseMove += button_Add_Mouse_Move;
            // 
            // comboBox_Permissions_1
            // 
            comboBox_Permissions_1.FormattingEnabled = true;
            comboBox_Permissions_1.Location = new Point(148, 95);
            comboBox_Permissions_1.Name = "comboBox_Permissions_1";
            comboBox_Permissions_1.Size = new Size(153, 31);
            comboBox_Permissions_1.TabIndex = 61;
            comboBox_Permissions_1.MouseMove += comboBox_Permissions_1_Mouse_Move;
            // 
            // comboBox_Permissions_2
            // 
            comboBox_Permissions_2.FormattingEnabled = true;
            comboBox_Permissions_2.Location = new Point(148, 132);
            comboBox_Permissions_2.Name = "comboBox_Permissions_2";
            comboBox_Permissions_2.Size = new Size(153, 31);
            comboBox_Permissions_2.TabIndex = 61;
            comboBox_Permissions_2.MouseMove += comboBox_Permissions_2_Mouse_Move;
            // 
            // comboBox_Permissions_3
            // 
            comboBox_Permissions_3.FormattingEnabled = true;
            comboBox_Permissions_3.Location = new Point(148, 168);
            comboBox_Permissions_3.Name = "comboBox_Permissions_3";
            comboBox_Permissions_3.Size = new Size(153, 31);
            comboBox_Permissions_3.TabIndex = 61;
            comboBox_Permissions_3.MouseMove += comboBox_Permissions_3_Mouse_Move;
            // 
            // comboBox_Permissions_4
            // 
            comboBox_Permissions_4.FormattingEnabled = true;
            comboBox_Permissions_4.Location = new Point(148, 204);
            comboBox_Permissions_4.Name = "comboBox_Permissions_4";
            comboBox_Permissions_4.Size = new Size(153, 31);
            comboBox_Permissions_4.TabIndex = 61;
            comboBox_Permissions_4.MouseMove += comboBox_Permissions_4_Mouse_Move;
            // 
            // comboBox_Department_1
            // 
            comboBox_Department_1.FormattingEnabled = true;
            comboBox_Department_1.Location = new Point(628, 97);
            comboBox_Department_1.Name = "comboBox_Department_1";
            comboBox_Department_1.Size = new Size(153, 31);
            comboBox_Department_1.TabIndex = 61;
            comboBox_Department_1.MouseMove += comboBox_Department_1_Mouse_Move;
            // 
            // comboBox_Department_2
            // 
            comboBox_Department_2.FormattingEnabled = true;
            comboBox_Department_2.Location = new Point(626, 132);
            comboBox_Department_2.Name = "comboBox_Department_2";
            comboBox_Department_2.Size = new Size(153, 31);
            comboBox_Department_2.TabIndex = 61;
            comboBox_Department_2.MouseMove += comboBox_Department_2_Mouse_Move;
            // 
            // comboBox_Department_3
            // 
            comboBox_Department_3.FormattingEnabled = true;
            comboBox_Department_3.Location = new Point(626, 168);
            comboBox_Department_3.Name = "comboBox_Department_3";
            comboBox_Department_3.Size = new Size(153, 31);
            comboBox_Department_3.TabIndex = 61;
            comboBox_Department_3.MouseMove += comboBox_Department_3_Mouse_Move;
            // 
            // comboBox_Department_4
            // 
            comboBox_Department_4.FormattingEnabled = true;
            comboBox_Department_4.Location = new Point(626, 204);
            comboBox_Department_4.Name = "comboBox_Department_4";
            comboBox_Department_4.Size = new Size(153, 31);
            comboBox_Department_4.TabIndex = 61;
            comboBox_Department_4.MouseMove += comboBox_Department_4_Mouse_Move;
            // 
            // comboBox_Name_1
            // 
            comboBox_Name_1.FormattingEnabled = true;
            comboBox_Name_1.Location = new Point(787, 97);
            comboBox_Name_1.Name = "comboBox_Name_1";
            comboBox_Name_1.Size = new Size(153, 31);
            comboBox_Name_1.TabIndex = 61;
            comboBox_Name_1.MouseMove += comboBox_Name_1_Mouse_Move;
            // 
            // comboBox_Name_2
            // 
            comboBox_Name_2.FormattingEnabled = true;
            comboBox_Name_2.Location = new Point(785, 132);
            comboBox_Name_2.Name = "comboBox_Name_2";
            comboBox_Name_2.Size = new Size(153, 31);
            comboBox_Name_2.TabIndex = 61;
            comboBox_Name_2.MouseMove += comboBox_Name_2_Mouse_Move;
            // 
            // comboBox_Name_3
            // 
            comboBox_Name_3.FormattingEnabled = true;
            comboBox_Name_3.Location = new Point(785, 168);
            comboBox_Name_3.Name = "comboBox_Name_3";
            comboBox_Name_3.Size = new Size(153, 31);
            comboBox_Name_3.TabIndex = 61;
            comboBox_Name_3.MouseMove += comboBox_Name_3_Mouse_Move;
            // 
            // comboBox_Name_4
            // 
            comboBox_Name_4.FormattingEnabled = true;
            comboBox_Name_4.Location = new Point(785, 204);
            comboBox_Name_4.Name = "comboBox_Name_4";
            comboBox_Name_4.Size = new Size(153, 31);
            comboBox_Name_4.TabIndex = 61;
            comboBox_Name_4.MouseMove += comboBox_Name_4_Mouse_Move;
            // 
            // Setting
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1159, 920);
            Controls.Add(comboBox_Name_4);
            Controls.Add(comboBox_Department_4);
            Controls.Add(comboBox_Permissions_4);
            Controls.Add(comboBox_Name_3);
            Controls.Add(comboBox_Department_3);
            Controls.Add(comboBox_Permissions_3);
            Controls.Add(comboBox_Name_2);
            Controls.Add(comboBox_Department_2);
            Controls.Add(comboBox_Permissions_2);
            Controls.Add(comboBox_Name_1);
            Controls.Add(comboBox_Department_1);
            Controls.Add(comboBox_Permissions_1);
            Controls.Add(listView_Setting);
            Controls.Add(comboBox_Permissions);
            Controls.Add(label5);
            Controls.Add(button_Remove);
            Controls.Add(button_Refresh);
            Controls.Add(button_Save);
            Controls.Add(textBox_Password_3);
            Controls.Add(textBox_Password_4);
            Controls.Add(textBox_Access_3);
            Controls.Add(textBox_Access_4);
            Controls.Add(textBox_Password_2);
            Controls.Add(textBox_Access_2);
            Controls.Add(label3);
            Controls.Add(textBox_Password_1);
            Controls.Add(textBox_Access_1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(button_Clear);
            Controls.Add(button_Add);
            Name = "Setting";
            Text = "Setting";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView_Setting;
        private ComboBox comboBox_Permissions;
        private Label label5;
        private Button button_Remove;
        private Button button_Refresh;
        private Button button_Save;
        private TextBox textBox_Job_Title_3;
        private TextBox textBox_Job_Title_4;
        private TextBox textBox_Password_3;
        private TextBox textBox_Password_4;
        private TextBox textBox_Access_3;
        private TextBox textBox_Access_4;
        private TextBox textBox_Position_3;
        private TextBox textBox_Position_4;
        private TextBox textBox_Job_Title_2;
        private TextBox textBox_Password_2;
        private TextBox textBox_Access_2;
        private TextBox textBox_Position_2;
        private Label label3;
        private TextBox textBox_Job_Title_1;
        private TextBox textBox_Password_1;
        private TextBox textBox_Access_1;
        private TextBox textBox_Position_1;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label6;
        private Button button_Clear;
        private Button button_Add;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ComboBox comboBox_Permissions_1;
        private ComboBox comboBox_Permissions_2;
        private ComboBox comboBox_Permissions_3;
        private ComboBox comboBox_Permissions_4;
        private ComboBox comboBox_Department_1;
        private ComboBox comboBox_Department_2;
        private ComboBox comboBox_Department_3;
        private ComboBox comboBox_Department_4;
        private ComboBox comboBox_Name_1;
        private ComboBox comboBox_Name_2;
        private ComboBox comboBox_Name_3;
        private ComboBox comboBox_Name_4;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
    }
}