namespace WinFormsApp_Meal_expense_accounting
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
            panel2 = new Panel();
            button_LogIn = new Button();
            button_Setting = new Button();
            button_Restaurant = new Button();
            button_People = new Button();
            button_Booking = new Button();
            button_Order = new Button();
            button_Deposit = new Button();
            button_Details = new Button();
            button_Information = new Button();
            panel3 = new Panel();
            panel_ChildForm = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 976);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(button_Information);
            panel2.Controls.Add(button_LogIn);
            panel2.Controls.Add(button_Setting);
            panel2.Controls.Add(button_Restaurant);
            panel2.Controls.Add(button_People);
            panel2.Controls.Add(button_Booking);
            panel2.Controls.Add(button_Order);
            panel2.Controls.Add(button_Deposit);
            panel2.Controls.Add(button_Details);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 138);
            panel2.Name = "panel2";
            panel2.Size = new Size(300, 838);
            panel2.TabIndex = 1;
            // 
            // button_LogIn
            // 
            button_LogIn.Location = new Point(0, 0);
            button_LogIn.Name = "button_LogIn";
            button_LogIn.Size = new Size(300, 93);
            button_LogIn.TabIndex = 1;
            button_LogIn.Text = "LogIn";
            button_LogIn.UseVisualStyleBackColor = true;
            button_LogIn.Click += button_LogIn_Click;
            button_LogIn.MouseLeave += button_LogIn_Mouse_Leave;
            button_LogIn.MouseMove += button_LogIn_Mouse_Move;
            // 
            // button_Setting
            // 
            button_Setting.Location = new Point(0, 651);
            button_Setting.Name = "button_Setting";
            button_Setting.Size = new Size(300, 93);
            button_Setting.TabIndex = 0;
            button_Setting.Text = "Setting";
            button_Setting.UseVisualStyleBackColor = true;
            button_Setting.Click += button_Setting_Click;
            button_Setting.MouseLeave += button_Setting_Mouse_Leave;
            button_Setting.MouseMove += button_Setting_Mouse_Move;
            // 
            // button_Restaurant
            // 
            button_Restaurant.Location = new Point(0, 279);
            button_Restaurant.Name = "button_Restaurant";
            button_Restaurant.Size = new Size(300, 93);
            button_Restaurant.TabIndex = 5;
            button_Restaurant.Text = "Restaurant";
            button_Restaurant.UseVisualStyleBackColor = true;
            button_Restaurant.Click += button_Restaurant_Click;
            button_Restaurant.MouseLeave += button_Restaurant_Mouse_Leave;
            button_Restaurant.MouseMove += button_Restaurant_Mouse_Move;
            // 
            // button_People
            // 
            button_People.Location = new Point(0, 558);
            button_People.Name = "button_People";
            button_People.Size = new Size(300, 93);
            button_People.TabIndex = 6;
            button_People.Text = "People";
            button_People.UseVisualStyleBackColor = true;
            button_People.Click += button_People_Click;
            button_People.MouseLeave += button_People_Mouse_Leave;
            button_People.MouseMove += button_People_Mouse_Move;
            // 
            // button_Booking
            // 
            button_Booking.Location = new Point(0, 186);
            button_Booking.Name = "button_Booking";
            button_Booking.Size = new Size(300, 93);
            button_Booking.TabIndex = 7;
            button_Booking.Text = "Booking";
            button_Booking.UseVisualStyleBackColor = true;
            button_Booking.Click += button_Booking_Click;
            button_Booking.MouseLeave += button_Booking_Mouse_Leave;
            button_Booking.MouseMove += button_Booking_Mouse_Move;
            // 
            // button_Order
            // 
            button_Order.Location = new Point(0, 93);
            button_Order.Name = "button_Order";
            button_Order.Size = new Size(300, 93);
            button_Order.TabIndex = 4;
            button_Order.Text = "Order";
            button_Order.UseVisualStyleBackColor = true;
            button_Order.Click += button_Order_Click;
            button_Order.MouseLeave += button_Order_Mouse_Leave;
            button_Order.MouseMove += button_Order_Mouse_Move;
            // 
            // button_Deposit
            // 
            button_Deposit.Location = new Point(0, 465);
            button_Deposit.Name = "button_Deposit";
            button_Deposit.Size = new Size(300, 93);
            button_Deposit.TabIndex = 2;
            button_Deposit.Text = "Deposit";
            button_Deposit.UseVisualStyleBackColor = true;
            button_Deposit.Click += button_Deposit_Click;
            button_Deposit.MouseLeave += button_Deposit_Mouse_Leave;
            button_Deposit.MouseMove += button_Deposit_Mouse_Move;
            // 
            // button_Details
            // 
            button_Details.Location = new Point(0, 372);
            button_Details.Name = "button_Details";
            button_Details.Size = new Size(300, 93);
            button_Details.TabIndex = 3;
            button_Details.Text = "Details";
            button_Details.UseVisualStyleBackColor = true;
            button_Details.Click += button_Details_Click;
            button_Details.MouseLeave += button_Details_Mouse_Leave;
            button_Details.MouseMove += button_Details_Mouse_Move;
            // 
            // button_Information
            // 
            button_Information.Location = new Point(0, 744);
            button_Information.Name = "button_Information";
            button_Information.Size = new Size(300, 93);
            button_Information.TabIndex = 8;
            button_Information.Text = "Information";
            button_Information.UseVisualStyleBackColor = true;
            button_Information.Click += button_Information_Click;
            button_Information.MouseLeave += button_Information_Mouse_Leave;
            button_Information.MouseMove += button_Information_Mouse_Move;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(300, 138);
            panel3.TabIndex = 0;
            // 
            // panel_ChildForm
            // 
            panel_ChildForm.Dock = DockStyle.Fill;
            panel_ChildForm.Location = new Point(300, 0);
            panel_ChildForm.Name = "panel_ChildForm";
            panel_ChildForm.Size = new Size(1181, 976);
            panel_ChildForm.TabIndex = 1;
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
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button_Information;
        private Button button_Booking;
        private Button button_People;
        private Button button_Restaurant;
        private Button button_Order;
        private Button button_Details;
        private Button button_Deposit;
        private Button button_LogIn;
        private Panel panel3;
        private Panel panel_ChildForm;
        private Button button_Setting;
        private Panel panel2;
    }
}
