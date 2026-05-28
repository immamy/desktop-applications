namespace WindowsFormsApp_OrderFood
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_Switch = new System.Windows.Forms.Button();
            this.button_Revenue = new System.Windows.Forms.Button();
            this.button_Sale = new System.Windows.Forms.Button();
            this.button_Stuff = new System.Windows.Forms.Button();
            this.button_Cooking = new System.Windows.Forms.Button();
            this.button_Order = new System.Windows.Forms.Button();
            this.panel_ChildForm = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_Switch);
            this.panel1.Controls.Add(this.button_Revenue);
            this.panel1.Controls.Add(this.button_Sale);
            this.panel1.Controls.Add(this.button_Stuff);
            this.panel1.Controls.Add(this.button_Cooking);
            this.panel1.Controls.Add(this.button_Order);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1481, 125);
            this.panel1.TabIndex = 0;
            // 
            // button_Switch
            // 
            this.button_Switch.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20F);
            this.button_Switch.Location = new System.Drawing.Point(1219, 12);
            this.button_Switch.Name = "button_Switch";
            this.button_Switch.Size = new System.Drawing.Size(250, 100);
            this.button_Switch.TabIndex = 0;
            this.button_Switch.Text = "前台/後台";
            this.button_Switch.UseVisualStyleBackColor = true;
            this.button_Switch.Click += new System.EventHandler(this.button_Switch_Click);
            this.button_Switch.MouseLeave += new System.EventHandler(this.button_Switch_Mouse_Leave);
            this.button_Switch.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button_Switch_Mouse_Move);
            // 
            // button_Revenue
            // 
            this.button_Revenue.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20F);
            this.button_Revenue.Location = new System.Drawing.Point(1036, 12);
            this.button_Revenue.Name = "button_Revenue";
            this.button_Revenue.Size = new System.Drawing.Size(250, 100);
            this.button_Revenue.TabIndex = 0;
            this.button_Revenue.Text = "營收分析";
            this.button_Revenue.UseVisualStyleBackColor = true;
            this.button_Revenue.Click += new System.EventHandler(this.button_Revenue_Click);
            this.button_Revenue.MouseLeave += new System.EventHandler(this.button_Revenue_Mouse_Leave);
            this.button_Revenue.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button_Revenue_Mouse_Move);
            // 
            // button_Sale
            // 
            this.button_Sale.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20F);
            this.button_Sale.Location = new System.Drawing.Point(780, 12);
            this.button_Sale.Name = "button_Sale";
            this.button_Sale.Size = new System.Drawing.Size(250, 100);
            this.button_Sale.TabIndex = 0;
            this.button_Sale.Text = "銷售數據";
            this.button_Sale.UseVisualStyleBackColor = true;
            this.button_Sale.Click += new System.EventHandler(this.button_Sale_Click);
            this.button_Sale.MouseLeave += new System.EventHandler(this.button_Sale_Mouse_Leave);
            this.button_Sale.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button_Sale_Mouse_Move);
            // 
            // button_Stuff
            // 
            this.button_Stuff.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20F);
            this.button_Stuff.Location = new System.Drawing.Point(524, 12);
            this.button_Stuff.Name = "button_Stuff";
            this.button_Stuff.Size = new System.Drawing.Size(250, 100);
            this.button_Stuff.TabIndex = 0;
            this.button_Stuff.Text = "食材管理";
            this.button_Stuff.UseVisualStyleBackColor = true;
            this.button_Stuff.Click += new System.EventHandler(this.button_Stuff_Click);
            this.button_Stuff.MouseLeave += new System.EventHandler(this.button_Stuff_Mouse_Leave);
            this.button_Stuff.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button_Stuff_Mouse_Move);
            // 
            // button_Cooking
            // 
            this.button_Cooking.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20F);
            this.button_Cooking.Location = new System.Drawing.Point(268, 12);
            this.button_Cooking.Name = "button_Cooking";
            this.button_Cooking.Size = new System.Drawing.Size(250, 100);
            this.button_Cooking.TabIndex = 0;
            this.button_Cooking.Text = "廚房";
            this.button_Cooking.UseVisualStyleBackColor = true;
            this.button_Cooking.Click += new System.EventHandler(this.button_Cooking_Click);
            this.button_Cooking.MouseLeave += new System.EventHandler(this.button_Cooking_Mouse_Leave);
            this.button_Cooking.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button_Cooking_Mouse_Move);
            // 
            // button_Order
            // 
            this.button_Order.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20F);
            this.button_Order.Location = new System.Drawing.Point(12, 12);
            this.button_Order.Name = "button_Order";
            this.button_Order.Size = new System.Drawing.Size(250, 100);
            this.button_Order.TabIndex = 0;
            this.button_Order.Text = "點餐";
            this.button_Order.UseVisualStyleBackColor = true;
            this.button_Order.Click += new System.EventHandler(this.button_Order_Click);
            this.button_Order.MouseLeave += new System.EventHandler(this.button_Order_Mouse_Leave);
            this.button_Order.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button_Order_Mouse_Move);
            // 
            // panel_ChildForm
            // 
            this.panel_ChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_ChildForm.Location = new System.Drawing.Point(0, 125);
            this.panel_ChildForm.Name = "panel_ChildForm";
            this.panel_ChildForm.Size = new System.Drawing.Size(1481, 851);
            this.panel_ChildForm.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1481, 976);
            this.Controls.Add(this.panel_ChildForm);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_ChildForm;
        private System.Windows.Forms.Button button_Switch;
        private System.Windows.Forms.Button button_Revenue;
        private System.Windows.Forms.Button button_Sale;
        private System.Windows.Forms.Button button_Stuff;
        private System.Windows.Forms.Button button_Cooking;
        private System.Windows.Forms.Button button_Order;
    }
}

