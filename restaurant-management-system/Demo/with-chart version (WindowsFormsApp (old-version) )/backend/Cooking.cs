using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_OrderFood
{
    public partial class Cooking : Form
    {
        public Cooking()
        {
            InitializeComponent();

            //更新listView_Cooking函式
            Refresh_Cooking();

            //更新listView_Delivery函式
            Refresh_Delivery();
        }

        //更新listView_Cooking函
        public void Refresh_Cooking()
        {
            this.listView_Cooking.Items.Clear();  //只移除資料列，保留標題列

            //Cooking.txt
            //讀取資料
            string link;
            link = Application.StartupPath + "data\\Cooking.txt";
            StreamReader r_count = new StreamReader(link);
            string sepatator = ",";  //以逗號分割字串
            char[] cgap = sepatator.ToCharArray();
            //逐行讀取到底，計算資料行數量
            int count = 0;
            while (!r_count.EndOfStream)
            {
                r_count.ReadLine();  //讀取一列資料行
                count += 1;
            }
            //close the file
            r_count.Close();

            //開啟檔案
            StreamReader r = new StreamReader(link);
            //不讀取檔案最後兩行空行
            for (int i = 0; i < count - 1; i++)
            {
                string str1 = r.ReadLine();  //讀取一列資料行
                if (str1 == null) break;  //若資料為空值，則跳過
                string[] str2 = str1.Split(cgap, StringSplitOptions.RemoveEmptyEntries);  //基於數組字串，將字串拆分為多少個子字串  //StringSplitOptions.RemoveEmptyEntries忽略空行  //StringSplitOptions.None不忽略空行

                if (str2[5] == "已訂餐")
                {
                    //listView寫入新資料
                    ListViewItem b = new ListViewItem(new string[] { str2[0], str2[1], str2[2], str2[3], str2[4], str2[5], str2[6] });
                    listView_Cooking.Items.Add(b);
                }
            }
            //close the file
            r.Close();
        }

        //更新listView_Delivery函
        public void Refresh_Delivery()
        {
            this.listView_Delivery.Items.Clear();  //只移除資料列，保留標題列

            //Delivery.txt
            //讀取資料
            string link;
            link = Application.StartupPath + "data\\Delivery.txt";
            StreamReader r_count = new StreamReader(link);
            string sepatator = ",";  //以逗號分割字串
            char[] cgap = sepatator.ToCharArray();
            //逐行讀取到底，計算資料行數量
            int count = 0;
            while (!r_count.EndOfStream)
            {
                r_count.ReadLine();  //讀取一列資料行
                count += 1;
            }
            //close the file
            r_count.Close();

            //開啟檔案
            StreamReader r = new StreamReader(link);
            //不讀取檔案最後兩行空行
            for (int i = 0; i < count - 1; i++)
            {
                string str1 = r.ReadLine();  //讀取一列資料行
                if (str1 == null) break;  //若資料為空值，則跳過
                string[] str2 = str1.Split(cgap, StringSplitOptions.RemoveEmptyEntries);  //基於數組字串，將字串拆分為多少個子字串  //StringSplitOptions.RemoveEmptyEntries忽略空行  //StringSplitOptions.None不忽略空行

                if (str2[5] == "已製作")
                {
                    //listView寫入新資料
                    ListViewItem b = new ListViewItem(new string[] { str2[0], str2[1], str2[2], str2[3], str2[4], str2[5], str2[6] });
                    listView_Delivery.Items.Add(b);
                }
            }
            //close the file
            r.Close();
        }

        //寫入Delivery.txt 已製作 日期凾式
        public void Write_Delivery()
        {
            //寫入Delivery.txt 已製作 日期
            //開啟檔案
            string link;
            link = Application.StartupPath + "data\\Delivery.txt";
            StreamReader r_count = new StreamReader(link);
            string sepatator = ",";  //以逗號分割字串
            char[] cgap = sepatator.ToCharArray();
            //逐行讀取到底，計算資料行數量
            int count = 0;
            while (!r_count.EndOfStream)
            {
                r_count.ReadLine();  //讀取一列資料行
                count += 1;
            }
            //close the file
            r_count.Close();

            //設為空值
            string s = "";
            //開啟檔案
            StreamReader r = new StreamReader(link);
            //不讀取檔案最後兩行空行
            for (int i = 0; i < count - 1; i++)
            {
                string str1 = r.ReadLine();  //讀取一列資料行
                if (str1 == null) break;  //若資料為空值，則跳過
                string[] str2 = str1.Split(cgap, StringSplitOptions.RemoveEmptyEntries);  //基於數組字串，將字串拆分為多少個子字串  //StringSplitOptions.RemoveEmptyEntries忽略空行  //StringSplitOptions.None不忽略空行

                //加入舊資料
                for (int m = 0; m < str2.Length; m++)
                {
                    s += str2[m] + ",";
                }
                //讀取舊資料最後一筆不換行
                if (i != (count - 1))
                {
                    s += "\r\n";
                }
            }
            //close the file
            r.Close();

            //加入新資料
            s += listView_Cooking.SelectedItems[0].SubItems[0].Text + ",";
            s += listView_Cooking.SelectedItems[0].SubItems[1].Text + ",";
            s += listView_Cooking.SelectedItems[0].SubItems[2].Text + ",";
            s += listView_Cooking.SelectedItems[0].SubItems[3].Text + ",";
            s += listView_Cooking.SelectedItems[0].SubItems[4].Text + ",";
            s += listView_Cooking.SelectedItems[0].SubItems[5].Text + ",";
            s += listView_Cooking.SelectedItems[0].SubItems[6].Text + ",";
            s += "\r\n";

            string link_Save;
            link_Save = Application.StartupPath + "data\\Delivery.txt";
            using (StreamWriter sw = new StreamWriter(link_Save))
            {
                sw.WriteLine(s);  //將listView資料寫入檔案
            }
            //MessageBox.Show("儲存成功：" + link_Save);
        }

        //更新Cooking.txt 已製作 日期凾式
        public void Revise_Cooking()
        {
            //更新Cooking.txt 已製作 日期
            //開啟檔案
            string link;
            link = Application.StartupPath + "data\\Cooking.txt";
            StreamReader r_count = new StreamReader(link);
            string sepatator = ",";  //以逗號分割字串
            char[] cgap = sepatator.ToCharArray();
            //逐行讀取到底，計算資料行數量
            int count = 0;
            while (!r_count.EndOfStream)
            {
                r_count.ReadLine();  //讀取一列資料行
                count += 1;
            }
            //close the file
            r_count.Close();

            //設為空值
            string s = "";
            //開啟檔案
            StreamReader r = new StreamReader(link);
            string[] type = [];
            string[] name = [];
            string[] num = [];
            string[] table_number = [];
            string[] booking_number = [];
            string[] state = [];
            string[] date = [];
            //不讀取檔案最後兩行空行
            for (int i = 0; i < count - 1; i++)
            {
                string str1 = r.ReadLine();  //讀取一列資料行
                if (str1 == null) break;  //若資料為空值，則跳過
                string[] str2 = str1.Split(cgap, StringSplitOptions.RemoveEmptyEntries);  //基於數組字串，將字串拆分為多少個子字串  //StringSplitOptions.RemoveEmptyEntries忽略空行  //StringSplitOptions.None不忽略空行

                //type
                // 調整陣列的大小
                System.Array.Resize(ref type, type.Length + 1);
                // 指定新的陣列值
                type[type.Length - 1] = str2[0];

                //name
                // 調整陣列的大小
                System.Array.Resize(ref name, name.Length + 1);
                // 指定新的陣列值
                name[name.Length - 1] = str2[1];

                //num
                // 調整陣列的大小
                System.Array.Resize(ref num, num.Length + 1);
                // 指定新的陣列值
                num[num.Length - 1] = str2[2];

                //table_number
                // 調整陣列的大小
                System.Array.Resize(ref table_number, table_number.Length + 1);
                // 指定新的陣列值
                table_number[table_number.Length - 1] = str2[3];

                //booking_number
                // 調整陣列的大小
                System.Array.Resize(ref booking_number, booking_number.Length + 1);
                // 指定新的陣列值
                booking_number[booking_number.Length - 1] = str2[4];

                //state
                // 調整陣列的大小
                System.Array.Resize(ref state, state.Length + 1);
                // 指定新的陣列值
                state[state.Length - 1] = str2[5];

                //date
                // 調整陣列的大小
                System.Array.Resize(ref date, date.Length + 1);
                // 指定新的陣列值
                date[date.Length - 1] = str2[6];

                //加入舊資料
                for (int m = 0; m < str2.Length; m++)
                {
                    //更新資料
                    //桌號與訂單編號相同 && 狀態不同 = 修改為新狀態                    
                    if ((listView_Cooking.SelectedItems[0].SubItems[3].Text == str2[3]) && (listView_Cooking.SelectedItems[0].SubItems[4].Text == str2[4]) && (listView_Cooking.SelectedItems[0].SubItems[5].Text != str2[5]))
                    {
                        s += str2[0] + ",";
                        s += str2[1] + ",";
                        s += str2[2] + ",";
                        s += str2[3] + ",";
                        s += str2[4] + ",";

                        string state_new = "已製作";
                        str2[5] = state_new;
                        s += str2[5] + ",";

                        DateTime currentTime = DateTime.Now;
                        str2[6] = Convert.ToString(currentTime);
                        s += str2[6] + ",";
                        break;
                    }
                    else
                    {
                        s += str2[m] + ",";
                    }
                }
                //讀取舊資料最後一筆不換行
                if (i != (count - 1))
                {
                    s += "\r\n";
                }
            }
            //close the file
            r.Close();

            string link_Save;
            link_Save = Application.StartupPath + "data\\Cooking.txt";
            using (StreamWriter sw = new StreamWriter(link_Save))
            {
                sw.WriteLine(s);  //將listView資料寫入檔案
            }
            //MessageBox.Show("儲存成功：" + link_Save);
        }

        //更新Delivery.txt 已製作 日期凾式
        public void Revise_Delivery()
        {
            //更新Delivery.txt 已製作 日期
            //開啟檔案
            string link;
            link = Application.StartupPath + "data\\Delivery.txt";
            StreamReader r_count = new StreamReader(link);
            string sepatator = ",";  //以逗號分割字串
            char[] cgap = sepatator.ToCharArray();
            //逐行讀取到底，計算資料行數量
            int count = 0;
            while (!r_count.EndOfStream)
            {
                r_count.ReadLine();  //讀取一列資料行
                count += 1;
            }
            //close the file
            r_count.Close();

            //設為空值
            string s = "";
            //開啟檔案
            StreamReader r = new StreamReader(link);
            string[] type = [];
            string[] name = [];
            string[] num = [];
            string[] table_number = [];
            string[] booking_number = [];
            string[] state = [];
            string[] date = [];
            //不讀取檔案最後兩行空行
            for (int i = 0; i < count - 1; i++)
            {
                string str1 = r.ReadLine();  //讀取一列資料行
                if (str1 == null) break;  //若資料為空值，則跳過
                string[] str2 = str1.Split(cgap, StringSplitOptions.RemoveEmptyEntries);  //基於數組字串，將字串拆分為多少個子字串  //StringSplitOptions.RemoveEmptyEntries忽略空行  //StringSplitOptions.None不忽略空行

                //type
                // 調整陣列的大小
                System.Array.Resize(ref type, type.Length + 1);
                // 指定新的陣列值
                type[type.Length - 1] = str2[0];

                //name
                // 調整陣列的大小
                System.Array.Resize(ref name, name.Length + 1);
                // 指定新的陣列值
                name[name.Length - 1] = str2[1];

                //num
                // 調整陣列的大小
                System.Array.Resize(ref num, num.Length + 1);
                // 指定新的陣列值
                num[num.Length - 1] = str2[2];

                //table_number
                // 調整陣列的大小
                System.Array.Resize(ref table_number, table_number.Length + 1);
                // 指定新的陣列值
                table_number[table_number.Length - 1] = str2[3];

                //booking_number
                // 調整陣列的大小
                System.Array.Resize(ref booking_number, booking_number.Length + 1);
                // 指定新的陣列值
                booking_number[booking_number.Length - 1] = str2[4];

                //state
                // 調整陣列的大小
                System.Array.Resize(ref state, state.Length + 1);
                // 指定新的陣列值
                state[state.Length - 1] = str2[5];

                //date
                // 調整陣列的大小
                System.Array.Resize(ref date, date.Length + 1);
                // 指定新的陣列值
                date[date.Length - 1] = str2[6];

                //加入舊資料
                for (int m = 0; m < str2.Length; m++)
                {
                    //更新資料
                    //桌號與訂單編號相同 && 狀態不同 = 修改為新狀態                    
                    if ((listView_Delivery.SelectedItems[0].SubItems[3].Text == str2[3]) && (listView_Delivery.SelectedItems[0].SubItems[4].Text == str2[4]) && (listView_Delivery.SelectedItems[0].SubItems[5].Text != str2[5]))
                    {
                        s += str2[0] + ",";
                        s += str2[1] + ",";
                        s += str2[2] + ",";
                        s += str2[3] + ",";
                        s += str2[4] + ",";

                        string state_new = "已送達";
                        str2[5] = state_new;
                        s += str2[5] + ",";

                        DateTime currentTime = DateTime.Now;
                        str2[6] = Convert.ToString(currentTime);
                        s += str2[6] + ",";
                        break;
                    }
                    else
                    {
                        s += str2[m] + ",";
                    }
                }
                //讀取舊資料最後一筆不換行
                if (i != (count - 1))
                {
                    s += "\r\n";
                }
            }
            //close the file
            r.Close();

            string link_Save;
            link_Save = Application.StartupPath + "data\\Delivery.txt";
            using (StreamWriter sw = new StreamWriter(link_Save))
            {
                sw.WriteLine(s);  //將listView資料寫入檔案
            }
            //MessageBox.Show("儲存成功：" + link_Save);
        }

        //已製作按鈕
        private void button_Cooking_Click(object sender, EventArgs e)
        {
            // 若沒有資料列，顯示提示框。
            if (listView_Cooking.Items.Count > 0)
            {
                //若有資料列，但未選擇資料列，顯示提示框。
                if (listView_Cooking.SelectedItems.Count > 0)
                {
                    //更新listView狀態 日期
                    string state = Convert.ToString(listView_Cooking.SelectedItems[0].SubItems[5]);
                    state = "已製作";
                    listView_Cooking.SelectedItems[0].SubItems[5].Text = state;

                    DateTime currentTime = DateTime.Now;
                    listView_Cooking.SelectedItems[0].SubItems[6].Text = Convert.ToString(currentTime);

                    //寫入Delivery.txt 已製作 日期凾式
                    Write_Delivery();

                    //更新Cooking.txt 已製作 日期凾式
                    Revise_Cooking();

                    //更新listView_Cooking函式
                    Refresh_Cooking();

                    //更新listView_Delivery函式
                    Refresh_Delivery();
                }
                else
                {
                    MessageBox.Show("請點選已製作的訂單。");
                    return;
                }
            }
            else
            {
                MessageBox.Show("沒有可製作的訂單。");
                return;
            }
        }

        //已送達按鈕
        private void button_Delivery_Click(object sender, EventArgs e)
        {
            // 若沒有資料列，顯示提示框。
            if (listView_Delivery.Items.Count > 0)
            {
                //若有資料列，但未選擇資料列，顯示提示框。
                if (listView_Delivery.SelectedItems.Count > 0)
                {
                    //listView_Delivery移除列
                    //listView_Delivery.Items.Remove(listView_Delivery.SelectedItems[0]);

                    //更新listView狀態 日期
                    string state = Convert.ToString(listView_Delivery.SelectedItems[0].SubItems[5]);
                    state = "已送達";
                    listView_Delivery.SelectedItems[0].SubItems[5].Text = state;

                    DateTime currentTime = DateTime.Now;
                    listView_Delivery.SelectedItems[0].SubItems[6].Text = Convert.ToString(currentTime);

                    //更新Delivery.txt 已送達 日期
                    Revise_Delivery();

                    //更新listView_Cooking函式
                    Refresh_Cooking();

                    //更新listView_Delivery函式
                    Refresh_Delivery();
                }
                else
                {
                    MessageBox.Show("請點選已送達的訂單。");
                    return;
                }
            }
            else
            {
                MessageBox.Show("沒有可送達的訂單。");
                return;
            }
        }

        //按鈕樣式
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

        private void button_Delivery_Mouse_Move(object sender, MouseEventArgs e)
        {
            button_Delivery.BackColor = Color.SteelBlue;
            button_Delivery.ForeColor = Color.White;
            button_Delivery.Cursor = Cursors.Hand;
        }

        private void button_Delivery_Mouse_Leave(object sender, EventArgs e)
        {
            button_Delivery.BackColor = Color.FromArgb(0, 150, 150, 150);
            button_Delivery.ForeColor = Color.FromArgb(0, 0, 0, 0);
        }
    }
}
