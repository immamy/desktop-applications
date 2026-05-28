namespace WinFormsApp_OrderFood
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            button_Switch = new Button();
            button_Stuff = new Button();
            button_Sale = new Button();
            button_Cooking = new Button();
            button_Order = new Button();
            panel_ChildForm = new Panel();
            button_Revenue = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button_Switch);
            panel1.Controls.Add(button_Stuff);
            panel1.Controls.Add(button_Revenue);
            panel1.Controls.Add(button_Sale);
            panel1.Controls.Add(button_Cooking);
            panel1.Controls.Add(button_Order);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1481, 122);
            panel1.TabIndex = 0;
            // 
            // button_Switch
            // 
            button_Switch.Font = new Font("Microsoft JhengHei UI", 20F);
            button_Switch.Location = new Point(1219, 12);
            button_Switch.Name = "button_Switch";
            button_Switch.Size = new Size(250, 100);
            button_Switch.TabIndex = 0;
            button_Switch.Text = "前台/後台";
            button_Switch.UseVisualStyleBackColor = true;
            button_Switch.Click += button_Switch_Click;
            button_Switch.MouseLeave += button_Switch_Mouse_Leave;
            button_Switch.MouseMove += button_Switch_Mouse_Move;
            // 
            // button_Stuff
            // 
            button_Stuff.Font = new Font("Microsoft JhengHei UI", 20F);
            button_Stuff.Location = new Point(523, 12);
            button_Stuff.Name = "button_Stuff";
            button_Stuff.Size = new Size(250, 100);
            button_Stuff.TabIndex = 0;
            button_Stuff.Text = "食材管理";
            button_Stuff.UseVisualStyleBackColor = true;
            button_Stuff.Click += button_Stuff_Click;
            button_Stuff.MouseLeave += button_Stuff_Mouse_Leave;
            button_Stuff.MouseMove += button_Stuff_Mouse_Move;
            // 
            // button_Sale
            // 
            button_Sale.Font = new Font("Microsoft JhengHei UI", 20F);
            button_Sale.Location = new Point(779, 12);
            button_Sale.Name = "button_Sale";
            button_Sale.Size = new Size(250, 100);
            button_Sale.TabIndex = 0;
            button_Sale.Text = "銷售數據";
            button_Sale.UseVisualStyleBackColor = true;
            button_Sale.Click += button_Sale_Click;
            button_Sale.MouseLeave += button_Sale_Mouse_Leave;
            button_Sale.MouseMove += button_Sale_Mouse_Move;
            // 
            // button_Cooking
            // 
            button_Cooking.Font = new Font("Microsoft JhengHei UI", 20F);
            button_Cooking.Location = new Point(267, 12);
            button_Cooking.Name = "button_Cooking";
            button_Cooking.Size = new Size(250, 100);
            button_Cooking.TabIndex = 0;
            button_Cooking.Text = "廚房";
            button_Cooking.UseVisualStyleBackColor = true;
            button_Cooking.Click += button_Cooking_Click;
            button_Cooking.MouseLeave += button_Cooking_Mouse_Leave;
            button_Cooking.MouseMove += button_Cooking_Mouse_Move;
            // 
            // button_Order
            // 
            button_Order.Font = new Font("Microsoft JhengHei UI", 20F);
            button_Order.Location = new Point(11, 12);
            button_Order.Name = "button_Order";
            button_Order.Size = new Size(250, 100);
            button_Order.TabIndex = 0;
            button_Order.Text = "點餐";
            button_Order.UseVisualStyleBackColor = true;
            button_Order.Click += button_Order_Click;
            button_Order.MouseLeave += button_Order_Mouse_Leave;
            button_Order.MouseMove += button_Order_Mouse_Move;
            // 
            // panel_ChildForm
            // 
            panel_ChildForm.Dock = DockStyle.Fill;
            panel_ChildForm.Location = new Point(0, 122);
            panel_ChildForm.Name = "panel_ChildForm";
            panel_ChildForm.Size = new Size(1481, 854);
            panel_ChildForm.TabIndex = 1;
            // 
            // button_Revenue
            // 
            button_Revenue.Font = new Font("Microsoft JhengHei UI", 20F);
            button_Revenue.Location = new Point(1035, 12);
            button_Revenue.Name = "button_Revenue";
            button_Revenue.Size = new Size(250, 100);
            button_Revenue.TabIndex = 0;
            button_Revenue.Text = "營收分析";
            button_Revenue.UseVisualStyleBackColor = true;
            button_Revenue.Click += button_Revenue_Click;
            button_Revenue.MouseLeave += button_Revenue_Mouse_Leave;
            button_Revenue.MouseMove += button_Revenue_Mouse_Move;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1481, 976);
            Controls.Add(panel_ChildForm);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel_ChildForm;
        private Button button_Switch;
        private Button button_Stuff;
        private Button button_Sale;
        private Button button_Cooking;
        private Button button_Order;
        private Button button_Revenue;
    }
}
