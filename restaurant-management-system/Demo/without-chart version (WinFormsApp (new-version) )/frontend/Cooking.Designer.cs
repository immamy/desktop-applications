namespace WinFormsApp_OrderFood
{
    partial class Cooking
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
            listView_Cooking = new ListView();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader12 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            columnHeader13 = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            listView_Delivery = new ListView();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader14 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            label1 = new Label();
            label2 = new Label();
            button_Cooking = new Button();
            button_Delivery = new Button();
            SuspendLayout();
            // 
            // listView_Cooking
            // 
            listView_Cooking.Columns.AddRange(new ColumnHeader[] { columnHeader8, columnHeader9, columnHeader12, columnHeader11, columnHeader13, columnHeader1, columnHeader7 });
            listView_Cooking.Font = new Font("Microsoft JhengHei UI", 14F);
            listView_Cooking.FullRowSelect = true;
            listView_Cooking.Location = new Point(12, 106);
            listView_Cooking.Name = "listView_Cooking";
            listView_Cooking.Size = new Size(1435, 263);
            listView_Cooking.TabIndex = 2;
            listView_Cooking.UseCompatibleStateImageBehavior = false;
            listView_Cooking.View = View.Details;
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
            // columnHeader12
            // 
            columnHeader12.Text = "數量";
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
            columnHeader1.Width = 120;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "訂餐日期";
            columnHeader7.Width = 350;
            // 
            // listView_Delivery
            // 
            listView_Delivery.Columns.AddRange(new ColumnHeader[] { columnHeader2, columnHeader3, columnHeader4, columnHeader6, columnHeader14, columnHeader5, columnHeader10 });
            listView_Delivery.Font = new Font("Microsoft JhengHei UI", 14F);
            listView_Delivery.FullRowSelect = true;
            listView_Delivery.Location = new Point(12, 474);
            listView_Delivery.Name = "listView_Delivery";
            listView_Delivery.Size = new Size(1435, 311);
            listView_Delivery.TabIndex = 3;
            listView_Delivery.UseCompatibleStateImageBehavior = false;
            listView_Delivery.View = View.Details;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "類別";
            columnHeader2.Width = 170;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "商品名稱";
            columnHeader3.Width = 330;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "數量";
            columnHeader4.Width = 80;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "桌號";
            columnHeader6.Width = 120;
            // 
            // columnHeader14
            // 
            columnHeader14.Text = "訂單編號";
            columnHeader14.Width = 140;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "狀態";
            columnHeader5.Width = 100;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "製作日期";
            columnHeader10.Width = 350;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 18F);
            label1.Location = new Point(35, 45);
            label1.Name = "label1";
            label1.Size = new Size(92, 46);
            label1.TabIndex = 4;
            label1.Text = "廚房";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 18F);
            label2.Location = new Point(35, 416);
            label2.Name = "label2";
            label2.Size = new Size(92, 46);
            label2.TabIndex = 4;
            label2.Text = "送餐";
            // 
            // button_Cooking
            // 
            button_Cooking.Font = new Font("Microsoft JhengHei UI", 16F);
            button_Cooking.Location = new Point(597, 31);
            button_Cooking.Name = "button_Cooking";
            button_Cooking.Size = new Size(142, 60);
            button_Cooking.TabIndex = 5;
            button_Cooking.Text = "已製作";
            button_Cooking.UseVisualStyleBackColor = true;
            button_Cooking.Click += button_Cooking_Click;
            button_Cooking.MouseLeave += button_Cooking_Mouse_Leave;
            button_Cooking.MouseMove += button_Cooking_Mouse_Move;
            // 
            // button_Delivery
            // 
            button_Delivery.Font = new Font("Microsoft JhengHei UI", 16F);
            button_Delivery.Location = new Point(597, 402);
            button_Delivery.Name = "button_Delivery";
            button_Delivery.Size = new Size(142, 60);
            button_Delivery.TabIndex = 5;
            button_Delivery.Text = "已送達";
            button_Delivery.UseVisualStyleBackColor = true;
            button_Delivery.Click += button_Delivery_Click;
            button_Delivery.MouseLeave += button_Delivery_Mouse_Leave;
            button_Delivery.MouseMove += button_Delivery_Mouse_Move;
            // 
            // Cooking
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1459, 797);
            Controls.Add(button_Delivery);
            Controls.Add(button_Cooking);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listView_Delivery);
            Controls.Add(listView_Cooking);
            Name = "Cooking";
            Text = "Cooking";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView_Booking;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader12;
        private ColumnHeader columnHeader1;
        private ListView listView1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private Label label1;
        private Label label2;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader10;
        private Button button1;
        private Button button2;
        private ListView listView_Cooking;
        private ListView listView_Delivery;
        private Button button_Cooking;
        private Button button_Delivery;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader13;
        private ColumnHeader columnHeader14;
    }
}