namespace WinFormsApp_OrderFood
{
    partial class Sale
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
            listView_Sale = new ListView();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader12 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            columnHeader13 = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            comboBox_Type = new ComboBox();
            dateTimePicker_Start = new DateTimePicker();
            dateTimePicker_End = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            comboBox_TableNum = new ComboBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // listView_Sale
            // 
            listView_Sale.Columns.AddRange(new ColumnHeader[] { columnHeader8, columnHeader9, columnHeader2, columnHeader3, columnHeader12, columnHeader11, columnHeader13, columnHeader1, columnHeader7 });
            listView_Sale.Font = new Font("Microsoft JhengHei UI", 14F);
            listView_Sale.FullRowSelect = true;
            listView_Sale.Location = new Point(12, 143);
            listView_Sale.Name = "listView_Sale";
            listView_Sale.Size = new Size(1435, 642);
            listView_Sale.TabIndex = 3;
            listView_Sale.UseCompatibleStateImageBehavior = false;
            listView_Sale.View = View.Details;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "類別";
            columnHeader8.Width = 170;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "商品名稱";
            columnHeader9.Width = 330;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "商品編號";
            columnHeader2.Width = 140;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "售價";
            columnHeader3.Width = 100;
            // 
            // columnHeader12
            // 
            columnHeader12.Text = "數量";
            columnHeader12.TextAlign = HorizontalAlignment.Center;
            columnHeader12.Width = 80;
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "桌號";
            columnHeader11.Width = 100;
            // 
            // columnHeader13
            // 
            columnHeader13.Text = "訂單編號";
            columnHeader13.Width = 140;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "狀態";
            columnHeader1.Width = 0;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "訂餐日期";
            columnHeader7.Width = 350;
            // 
            // comboBox_Type
            // 
            comboBox_Type.Font = new Font("Microsoft JhengHei UI", 14F);
            comboBox_Type.FormattingEnabled = true;
            comboBox_Type.Location = new Point(247, 53);
            comboBox_Type.Name = "comboBox_Type";
            comboBox_Type.Size = new Size(166, 44);
            comboBox_Type.TabIndex = 4;
            comboBox_Type.SelectedIndexChanged += comboBox_Type_SelectedIndexChanged;
            // 
            // dateTimePicker_Start
            // 
            dateTimePicker_Start.Location = new Point(998, 53);
            dateTimePicker_Start.Name = "dateTimePicker_Start";
            dateTimePicker_Start.Size = new Size(191, 30);
            dateTimePicker_Start.TabIndex = 5;
            dateTimePicker_Start.ValueChanged += dateTimePicker_Start_ValueChanged;
            // 
            // dateTimePicker_End
            // 
            dateTimePicker_End.Location = new Point(998, 89);
            dateTimePicker_End.Name = "dateTimePicker_End";
            dateTimePicker_End.Size = new Size(191, 30);
            dateTimePicker_End.TabIndex = 6;
            dateTimePicker_End.ValueChanged += dateTimePicker_End_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 14F);
            label1.Location = new Point(142, 57);
            label1.Name = "label1";
            label1.Size = new Size(99, 36);
            label1.TabIndex = 7;
            label1.Text = "類別：";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 14F);
            label2.Location = new Point(893, 56);
            label2.Name = "label2";
            label2.Size = new Size(99, 36);
            label2.TabIndex = 7;
            label2.Text = "日期：";
            // 
            // comboBox_TableNum
            // 
            comboBox_TableNum.Font = new Font("Microsoft JhengHei UI", 14F);
            comboBox_TableNum.FormattingEnabled = true;
            comboBox_TableNum.Location = new Point(628, 53);
            comboBox_TableNum.Name = "comboBox_TableNum";
            comboBox_TableNum.Size = new Size(166, 44);
            comboBox_TableNum.TabIndex = 4;
            comboBox_TableNum.SelectedIndexChanged += comboBox_TableNum_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 14F);
            label3.Location = new Point(523, 57);
            label3.Name = "label3";
            label3.Size = new Size(99, 36);
            label3.TabIndex = 7;
            label3.Text = "桌號：";
            // 
            // Sale
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1459, 797);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(dateTimePicker_End);
            Controls.Add(dateTimePicker_Start);
            Controls.Add(comboBox_TableNum);
            Controls.Add(comboBox_Type);
            Controls.Add(listView_Sale);
            Name = "Sale";
            Text = "Sale";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ListView listView_Sale;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader12;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader13;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ComboBox comboBox_Type;
        private DateTimePicker dateTimePicker_Start;
        private DateTimePicker dateTimePicker_End;
        private Label label1;
        private Label label2;
        private ComboBox comboBox_TableNum;
        private Label label3;
    }
}