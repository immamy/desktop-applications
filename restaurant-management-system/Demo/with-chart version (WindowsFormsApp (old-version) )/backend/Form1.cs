using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_OrderFood
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            button_Order.Visible = true;
            button_Cooking.Visible = true;
            button_Stuff.Visible = false;
            button_Sale.Visible = false;
            button_Revenue.Visible = false;

            button_Switch.ForeColor = System.Drawing.Color.SteelBlue;

            //測試版------------------------------
            openForm(new Sale());
            //測試版------------------------------
            
        }

        //Form頁面
        //母表單切換
        private void openForm(Form Form)
        {
            Form.TopLevel = false;  //最上層視窗通常用來作為應用程式中的主要表單，故子表單不能設為最上層表單
            Form.FormBorderStyle = FormBorderStyle.None;  //設定子表單邊框為無
            Form.Dock = DockStyle.Fill;  //設定子表單位置
            panel_ChildForm.Controls.Add(Form);  //將表單加入panel顯示
            panel_ChildForm.Tag = Form;  //將標籤設為子表單名
            Form.BringToFront();  //將表單放置到前面
            Form.Show();  //開啟表單
        }

        bool signal = false;
        private void button_Switch_Click(object sender, EventArgs e)
        {
            //openForm(new Form()); //呼叫開啟母表單方法，建立新表單物件

            if (signal)
            {
                openForm(new Order()); //呼叫開啟子表單方法，建立新表單物件
                button_Order.Visible = true;
                button_Cooking.Visible = true;
                button_Stuff.Visible = false;
                button_Sale.Visible = false;
                button_Revenue.Visible = false;
                button_Order.Location = new Point(12, 12);
                button_Cooking.Location = new Point(182, 12);
                signal = false;
            }
            else
            {
                openForm(new Stuff()); //呼叫開啟子表單方法，建立新表單物件
                button_Order.Visible = false;
                button_Cooking.Visible = false;
                button_Stuff.Visible = true;
                button_Sale.Visible = true;
                button_Revenue.Visible = true;
                button_Stuff.Location = new Point(12, 12);
                button_Sale.Location = new Point(182, 12);
                button_Revenue.Location = new Point(352, 12);
                signal = true;
            }
        }

        //Order頁面
        //子表單切換
        private void openOrder(Form Order)
        {
            Order.TopLevel = false;  //最上層視窗通常用來作為應用程式中的主要表單，故子表單不能設為最上層表單
            Order.FormBorderStyle = FormBorderStyle.None;  //設定子表單邊框為無
            Order.Dock = DockStyle.Fill;  //設定子表單位置
            panel_ChildForm.Controls.Add(Order);  //將表單加入panel顯示
            panel_ChildForm.Tag = Order;  //將標籤設為子表單名
            Order.BringToFront();  //將表單放置到前面
            Order.Show();  //開啟表單
        }

        //Order頁面 切換Button
        private void button_Order_Click(object sender, EventArgs e)
        {
            openOrder(new Order()); //呼叫開啟子表單方法，建立新表單物件
        }

        //Cooking頁面
        //子表單切換
        private void openCooking(Form Cooking)
        {
            Cooking.TopLevel = false;  //最上層視窗通常用來作為應用程式中的主要表單，故子表單不能設為最上層表單
            Cooking.FormBorderStyle = FormBorderStyle.None;  //設定子表單邊框為無
            Cooking.Dock = DockStyle.Fill;  //設定子表單位置
            panel_ChildForm.Controls.Add(Cooking);  //將表單加入panel顯示
            panel_ChildForm.Tag = Cooking;  //將標籤設為子表單名
            Cooking.BringToFront();  //將表單放置到前面
            Cooking.Show();  //開啟表單
        }

        //Cooking頁面 切換Button
        private void button_Cooking_Click(object sender, EventArgs e)
        {
            openCooking(new Cooking()); //呼叫開啟子表單方法，建立新表單物件
        }

        //Stuff頁面
        //子表單切換
        private void openStuff(Form Stuff)
        {
            Stuff.TopLevel = false;  //最上層視窗通常用來作為應用程式中的主要表單，故子表單不能設為最上層表單
            Stuff.FormBorderStyle = FormBorderStyle.None;  //設定子表單邊框為無
            Stuff.Dock = DockStyle.Fill;  //設定子表單位置
            panel_ChildForm.Controls.Add(Stuff);  //將表單加入panel顯示
            panel_ChildForm.Tag = Stuff;  //將標籤設為子表單名
            Stuff.BringToFront();  //將表單放置到前面
            Stuff.Show();  //開啟表單
        }

        //Stuff頁面 切換Button
        private void button_Stuff_Click(object sender, EventArgs e)
        {
            openStuff(new Stuff()); //呼叫開啟子表單方法，建立新表單物件
        }

        //Sale頁面
        //子表單切換
        private void openSale(Form Sale)
        {
            Sale.TopLevel = false;  //最上層視窗通常用來作為應用程式中的主要表單，故子表單不能設為最上層表單
            Sale.FormBorderStyle = FormBorderStyle.None;  //設定子表單邊框為無
            Sale.Dock = DockStyle.Fill;  //設定子表單位置
            panel_ChildForm.Controls.Add(Sale);  //將表單加入panel顯示
            panel_ChildForm.Tag = Sale;  //將標籤設為子表單名
            Sale.BringToFront();  //將表單放置到前面
            Sale.Show();  //開啟表單
        }

        //Sale頁面 切換Button
        private void button_Sale_Click(object sender, EventArgs e)
        {
            openSale(new Sale()); //呼叫開啟子表單方法，建立新表單物件
        }

        //Revenue頁面
        //子表單切換
        private void openRevenue(Form Revenue)
        {
            Revenue.TopLevel = false;  //最上層視窗通常用來作為應用程式中的主要表單，故子表單不能設為最上層表單
            Revenue.FormBorderStyle = FormBorderStyle.None;  //設定子表單邊框為無
            Revenue.Dock = DockStyle.Fill;  //設定子表單位置
            panel_ChildForm.Controls.Add(Revenue);  //將表單加入panel顯示
            panel_ChildForm.Tag = Revenue;  //將標籤設為子表單名
            Revenue.BringToFront();  //將表單放置到前面
            Revenue.Show();  //開啟表單
        }

        //Revenue頁面 切換Button
        private void button_Revenue_Click(object sender, EventArgs e)
        {
            openRevenue(new Revenue()); //呼叫開啟子表單方法，建立新表單物件
        }

        //Button樣式
        private void button_Switch_Mouse_Move(object sender, MouseEventArgs e)
        {
            button_Switch.BackColor = Color.SteelBlue;
            button_Switch.ForeColor = Color.White;
            button_Switch.Cursor = Cursors.Hand;
        }

        private void button_Switch_Mouse_Leave(object sender, EventArgs e)
        {
            button_Switch.BackColor = Color.FromArgb(0, 150, 150, 150);
            //button_Switch.ForeColor = Color.FromArgb(0, 0, 0, 0);
            button_Switch.ForeColor = System.Drawing.Color.SteelBlue;
        }

        private void button_Order_Mouse_Move(object sender, MouseEventArgs e)
        {
            button_Order.BackColor = Color.SteelBlue;
            button_Order.ForeColor = Color.White;
            button_Order.Cursor = Cursors.Hand;
        }

        private void button_Order_Mouse_Leave(object sender, EventArgs e)
        {
            button_Order.BackColor = Color.FromArgb(0, 150, 150, 150);
            button_Order.ForeColor = Color.FromArgb(0, 0, 0, 0);
        }

        private void button_Cooking_Mouse_Move(object sender, MouseEventArgs e)
        {
            button_Cooking.BackColor = Color.SteelBlue;
            button_Cooking.ForeColor = Color.White;
            button_Cooking.Cursor = Cursors.Hand;
        }

        private void button_Cooking_Mouse_Leave(object sender, EventArgs e)
        {
            button_Cooking.BackColor = Color.FromArgb(0, 150, 150, 150);
            button_Cooking.ForeColor = Color.FromArgb(0, 0, 0, 0);
        }

        private void button_Sale_Mouse_Move(object sender, MouseEventArgs e)
        {
            button_Sale.BackColor = Color.SteelBlue;
            button_Sale.ForeColor = Color.White;
            button_Sale.Cursor = Cursors.Hand;
        }

        private void button_Sale_Mouse_Leave(object sender, EventArgs e)
        {
            button_Sale.BackColor = Color.FromArgb(0, 150, 150, 150);
            button_Sale.ForeColor = Color.FromArgb(0, 0, 0, 0);
        }

        private void button_Stuff_Mouse_Move(object sender, MouseEventArgs e)
        {
            button_Stuff.BackColor = Color.SteelBlue;
            button_Stuff.ForeColor = Color.White;
            button_Stuff.Cursor = Cursors.Hand;
        }

        private void button_Stuff_Mouse_Leave(object sender, EventArgs e)
        {
            button_Stuff.BackColor = Color.FromArgb(0, 150, 150, 150);
            button_Stuff.ForeColor = Color.FromArgb(0, 0, 0, 0);
        }

        private void button_Revenue_Mouse_Move(object sender, MouseEventArgs e)
        {
            button_Revenue.BackColor = Color.SteelBlue;
            button_Revenue.ForeColor = Color.White;
            button_Revenue.Cursor = Cursors.Hand;
        }

        private void button_Revenue_Mouse_Leave(object sender, EventArgs e)
        {
            button_Revenue.BackColor = Color.FromArgb(0, 150, 150, 150);
            button_Revenue.ForeColor = Color.FromArgb(0, 0, 0, 0);
        }
    }
}
