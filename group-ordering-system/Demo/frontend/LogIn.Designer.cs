namespace WinFormsApp_Meal_expense_accounting
{
    partial class LogIn
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
            button_Confirm = new Button();
            button_Clear = new Button();
            label1 = new Label();
            label2 = new Label();
            textBox_Access = new TextBox();
            textBox_Password = new TextBox();
            SuspendLayout();
            // 
            // button_Confirm
            // 
            button_Confirm.Location = new Point(384, 390);
            button_Confirm.Name = "button_Confirm";
            button_Confirm.Size = new Size(78, 34);
            button_Confirm.TabIndex = 1;
            button_Confirm.Text = "確認";
            button_Confirm.UseVisualStyleBackColor = true;
            button_Confirm.Click += button_Confirm_Click;
            button_Confirm.MouseLeave += button_Confirm_Mouse_Leave;
            button_Confirm.MouseMove += button_Confirm_Mouse_Move;
            // 
            // button_Clear
            // 
            button_Clear.Location = new Point(468, 390);
            button_Clear.Name = "button_Clear";
            button_Clear.Size = new Size(78, 34);
            button_Clear.TabIndex = 1;
            button_Clear.Text = "清除";
            button_Clear.UseVisualStyleBackColor = true;
            button_Clear.Click += button_Clear_Click;
            button_Clear.MouseLeave += button_Clear_Mouse_Leave;
            button_Clear.MouseMove += button_Clear_Mouse_Move;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(314, 298);
            label1.Name = "label1";
            label1.Size = new Size(64, 23);
            label1.TabIndex = 2;
            label1.Text = "帳號：";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(314, 339);
            label2.Name = "label2";
            label2.Size = new Size(64, 23);
            label2.TabIndex = 3;
            label2.Text = "密碼：";
            // 
            // textBox_Access
            // 
            textBox_Access.Location = new Point(384, 295);
            textBox_Access.Name = "textBox_Access";
            textBox_Access.Size = new Size(153, 30);
            textBox_Access.TabIndex = 4;
            // 
            // textBox_Password
            // 
            textBox_Password.Location = new Point(384, 336);
            textBox_Password.Name = "textBox_Password";
            textBox_Password.PasswordChar = '*';
            textBox_Password.Size = new Size(153, 30);
            textBox_Password.TabIndex = 4;
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1159, 920);
            Controls.Add(textBox_Password);
            Controls.Add(textBox_Access);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button_Clear);
            Controls.Add(button_Confirm);
            Name = "LogIn";
            Text = "LogIn";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_Confirm;
        private Button button_Clear;
        private Label label1;
        private Label label2;
        private TextBox textBox_Access;
        private TextBox textBox_Password;
    }
}