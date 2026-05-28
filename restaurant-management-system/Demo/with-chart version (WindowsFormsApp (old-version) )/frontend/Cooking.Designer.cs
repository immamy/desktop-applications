namespace WindowsFormsApp_OrderFood
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
            this.listView_Cooking = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_Cooking = new System.Windows.Forms.Button();
            this.button_Delivery = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listView_Delivery = new System.Windows.Forms.ListView();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView_Cooking
            // 
            this.listView_Cooking.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listView_Cooking.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F);
            this.listView_Cooking.FullRowSelect = true;
            this.listView_Cooking.HideSelection = false;
            this.listView_Cooking.Location = new System.Drawing.Point(12, 106);
            this.listView_Cooking.Name = "listView_Cooking";
            this.listView_Cooking.Size = new System.Drawing.Size(1435, 263);
            this.listView_Cooking.TabIndex = 0;
            this.listView_Cooking.UseCompatibleStateImageBehavior = false;
            this.listView_Cooking.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "類別";
            this.columnHeader1.Width = 110;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "商品名稱";
            this.columnHeader2.Width = 260;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "數量";
            this.columnHeader3.Width = 70;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "桌號";
            this.columnHeader4.Width = 80;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "訂單編號";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "狀態";
            this.columnHeader6.Width = 80;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "訂餐日期";
            this.columnHeader7.Width = 350;
            // 
            // button_Cooking
            // 
            this.button_Cooking.Font = new System.Drawing.Font("Microsoft JhengHei UI", 16F);
            this.button_Cooking.Location = new System.Drawing.Point(597, 31);
            this.button_Cooking.Name = "button_Cooking";
            this.button_Cooking.Size = new System.Drawing.Size(142, 60);
            this.button_Cooking.TabIndex = 1;
            this.button_Cooking.Text = "已製作";
            this.button_Cooking.UseVisualStyleBackColor = true;
            this.button_Cooking.Click += new System.EventHandler(this.button_Cooking_Click);
            this.button_Cooking.MouseLeave += new System.EventHandler(this.button_Cooking_Mouse_Leave);
            this.button_Cooking.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button_Cooking_Mouse_Move);
            // 
            // button_Delivery
            // 
            this.button_Delivery.Font = new System.Drawing.Font("Microsoft JhengHei UI", 16F);
            this.button_Delivery.Location = new System.Drawing.Point(597, 402);
            this.button_Delivery.Name = "button_Delivery";
            this.button_Delivery.Size = new System.Drawing.Size(142, 60);
            this.button_Delivery.TabIndex = 1;
            this.button_Delivery.Text = "已送達";
            this.button_Delivery.UseVisualStyleBackColor = true;
            this.button_Delivery.Click += new System.EventHandler(this.button_Delivery_Click);
            this.button_Delivery.MouseLeave += new System.EventHandler(this.button_Delivery_Mouse_Leave);
            this.button_Delivery.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button_Delivery_Mouse_Move);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F);
            this.label1.Location = new System.Drawing.Point(35, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "廚房";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F);
            this.label2.Location = new System.Drawing.Point(35, 416);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 46);
            this.label2.TabIndex = 2;
            this.label2.Text = "送餐";
            // 
            // listView_Delivery
            // 
            this.listView_Delivery.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader14,
            this.columnHeader12,
            this.columnHeader13});
            this.listView_Delivery.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F);
            this.listView_Delivery.FullRowSelect = true;
            this.listView_Delivery.HideSelection = false;
            this.listView_Delivery.Location = new System.Drawing.Point(12, 474);
            this.listView_Delivery.Name = "listView_Delivery";
            this.listView_Delivery.Size = new System.Drawing.Size(1435, 311);
            this.listView_Delivery.TabIndex = 0;
            this.listView_Delivery.UseCompatibleStateImageBehavior = false;
            this.listView_Delivery.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "類別";
            this.columnHeader8.Width = 110;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "商品名稱";
            this.columnHeader9.Width = 260;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "數量";
            this.columnHeader10.Width = 70;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "桌號";
            this.columnHeader11.Width = 80;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "訂單編號";
            this.columnHeader14.Width = 100;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "狀態";
            this.columnHeader12.Width = 80;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "製作日期";
            this.columnHeader13.Width = 350;
            // 
            // Cooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1459, 797);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Delivery);
            this.Controls.Add(this.button_Cooking);
            this.Controls.Add(this.listView_Delivery);
            this.Controls.Add(this.listView_Cooking);
            this.Name = "Cooking";
            this.Text = "Cooking";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView_Cooking;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Button button_Cooking;
        private System.Windows.Forms.Button button_Delivery;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView_Delivery;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}