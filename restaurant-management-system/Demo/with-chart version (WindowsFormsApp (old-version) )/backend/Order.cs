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
    public partial class Order : Form
    {
        public Order()
        {
            InitializeComponent();

            //更新listView_Menu函式
            Refresh_Menu();

            comboBox_Type.SelectedIndex = 0;
            textBox_Count.Text = "1";
            label_UnitPrice.Visible = false;
        }

        //更新listView_Menu函
        public void Refresh_Menu()
        {
            this.listView_Menu.Items.Clear();  //只移除資料列，保留標題列

            //In.txt
            //讀取資料
            string link_Menu;
            link_Menu = Application.StartupPath + "data\\Order.txt";
            StreamReader r_count_Menu = new StreamReader(link_Menu);
            string sepatator_Menu = ",";  //以逗號分割字串
            char[] cgap_Menu = sepatator_Menu.ToCharArray();
            //逐行讀取到底，計算資料行數量
            int count_Menu = 0;
            while (!r_count_Menu.EndOfStream)
            {
                r_count_Menu.ReadLine();  //讀取一列資料行
                count_Menu += 1;
            }
            //close the file
            r_count_Menu.Close();

            //開啟檔案
            StreamReader r_Menu = new StreamReader(link_Menu);
            string[] type = [];
            string[] name = [];
            string[] num = [];
            int[] price = [];
            //不讀取檔案最後兩行空行
            for (int i = 0; i < count_Menu - 1; i++)
            {
                string str1 = r_Menu.ReadLine();  //讀取一列資料行
                if (str1 == null) break;  //若資料為空值，則跳過
                string[] str2 = str1.Split(cgap_Menu, StringSplitOptions.RemoveEmptyEntries);  //基於數組字串，將字串拆分為多少個子字串  //StringSplitOptions.RemoveEmptyEntries忽略空行  //StringSplitOptions.None不忽略空行

                //listView_Menu寫入新資料
                ListViewItem b = new ListViewItem(new string[] { str2[0], str2[1], str2[2], Convert.ToString("$ " + string.Format("{0:0,0}", str2[3])) });
                listView_Menu.Items.Add(b);

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

                //price
                // 調整陣列的大小
                System.Array.Resize(ref price, price.Length + 1);
                // 指定新的陣列值
                price[price.Length - 1] = 0;
            }

            comboBox_Type.Items.Add("全部商品");
            //comboBox加入選項
            for (int d = 0; d < name.Length; d++)
            {
                //comboBox加入選項
                comboBox_Type.Items.Add(type[d]);
                //comboBox移除重複選項
                for (int k = 0; k < comboBox_Type.Items.Count; k++)
                {
                    string cItem1 = comboBox_Type.Items[k].ToString();
                    for (int m = k + 1; m < comboBox_Type.Items.Count; m++)
                    {
                        string cItem2 = comboBox_Type.Items[m].ToString();
                        if (cItem1 == cItem2)
                        {
                            comboBox_Type.Items.RemoveAt(m);
                            comboBox_Type.Text = "";
                        }
                    }
                }

                //comboBox加入選項
                comboBox_AddType.Items.Add(type[d]);
                //comboBox移除重複選項
                for (int k = 0; k < comboBox_AddType.Items.Count; k++)
                {
                    string cItem1 = comboBox_AddType.Items[k].ToString();
                    for (int m = k + 1; m < comboBox_AddType.Items.Count; m++)
                    {
                        string cItem2 = comboBox_AddType.Items[m].ToString();
                        if (cItem1 == cItem2)
                        {
                            comboBox_AddType.Items.RemoveAt(m);
                            comboBox_AddType.Text = "";
                        }
                    }
                }
            }
            //close the file
            r_Menu.Close();
        }

        private void comboBox_Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Order.txt
            //讀取資料
            string link_Menu;
            link_Menu = Application.StartupPath + "data\\Order.txt";
            StreamReader r_count_Menu = new StreamReader(link_Menu);
            string sepatator_Menu = ",";  //以逗號分割字串
            char[] cgap_Menu = sepatator_Menu.ToCharArray();
            //逐行讀取到底，計算資料行數量
            int count_Menu = 0;
            while (!r_count_Menu.EndOfStream)
            {
                r_count_Menu.ReadLine();  //讀取一列資料行
                count_Menu += 1;
            }
            //close the file
            r_count_Menu.Close();

            //開啟檔案
            StreamReader r_Menu = new StreamReader(link_Menu);
            this.listView_Menu.Items.Clear();  //只移除資料列，保留標題列                                                                                                
            //不讀取檔案最後兩行空行
            for (int i = 0; i < count_Menu - 1; i++)
            {
                string str1 = r_Menu.ReadLine();  //讀取一列資料行
                if (str1 == null) break;  //若資料為空值，則跳過
                string[] str2 = str1.Split(cgap_Menu, StringSplitOptions.RemoveEmptyEntries);  //基於數組字串，將字串拆分為多少個子字串  //StringSplitOptions.RemoveEmptyEntries忽略空行  //StringSplitOptions.None不忽略空行

                //篩選存放狀態
                if (comboBox_Type.Text == Convert.ToString(str2[0]))
                {
                    //listView寫入新資料
                    ListViewItem b = new ListViewItem(new string[] { str2[0], str2[1], str2[2], Convert.ToString("$ " + string.Format("{0:0,0}", str2[3])) });
                    listView_Menu.Items.Add(b);
                }
                else if (comboBox_Type.Text == Convert.ToString("全部商品"))
                {
                    //更新listView_Menu函式
                    Refresh_Menu();
                }
            }
            //close the file
            r_Menu.Close();
        }

        private void comboBox_AddType_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_AddName.Text = "";
            comboBox_AddName.DropDownWidth = 450;

            //Order.txt
            //讀取資料
            string link_Menu;
            link_Menu = Application.StartupPath + "data\\Order.txt";
            StreamReader r_count_Menu = new StreamReader(link_Menu);
            string sepatator_Menu = ",";  //以逗號分割字串
            char[] cgap_Menu = sepatator_Menu.ToCharArray();
            //逐行讀取到底，計算資料行數量
            int count_Menu = 0;
            while (!r_count_Menu.EndOfStream)
            {
                r_count_Menu.ReadLine();  //讀取一列資料行
                count_Menu += 1;
            }
            //close the file
            r_count_Menu.Close();

            //開啟檔案
            StreamReader r_Menu = new StreamReader(link_Menu);
            comboBox_AddName.Items.Clear();
            //不讀取檔案最後兩行空行
            for (int i = 0; i < count_Menu - 1; i++)
            {
                string str1 = r_Menu.ReadLine();  //讀取一列資料行
                if (str1 == null) break;  //若資料為空值，則跳過
                string[] str2 = str1.Split(cgap_Menu, StringSplitOptions.RemoveEmptyEntries);  //基於數組字串，將字串拆分為多少個子字串  //StringSplitOptions.RemoveEmptyEntries忽略空行  //StringSplitOptions.None不忽略空行

                //篩選存放狀態
                if (comboBox_AddType.Text == Convert.ToString(str2[0]))
                {
                    //comboBox加入選項
                    comboBox_AddName.Items.Add(str2[1]);
                    //comboBox移除重複選項
                    for (int k = 0; k < comboBox_AddName.Items.Count; k++)
                    {
                        string cItem1 = comboBox_AddName.Items[k].ToString();
                        for (int m = k + 1; m < comboBox_AddName.Items.Count; m++)
                        {
                            string cItem2 = comboBox_AddName.Items[m].ToString();
                            if (cItem1 == cItem2)
                            {
                                comboBox_AddName.Items.RemoveAt(m);
                                comboBox_AddName.Text = "";
                            }
                        }
                    }
                }
            }
            //close the file
            r_Menu.Close();
        }

        private void comboBox_AddName_SelectedIndexChanged(object sender, EventArgs e)
        {
            //In.txt
            //讀取資料
            string link_Menu;
            link_Menu = Application.StartupPath + "data\\Order.txt";
            StreamReader r_count_Menu = new StreamReader(link_Menu);
            string sepatator_Menu = ",";  //以逗號分割字串
            char[] cgap_Menu = sepatator_Menu.ToCharArray();
            //逐行讀取到底，計算資料行數量
            int count_Menu = 0;
            while (!r_count_Menu.EndOfStream)
            {
                r_count_Menu.ReadLine();  //讀取一列資料行
                count_Menu += 1;
            }
            //close the file
            r_count_Menu.Close();

            //開啟檔案
            StreamReader r_Menu = new StreamReader(link_Menu);
            string[] type = [];
            string[] name = [];
            string[] num = [];
            string[] price = [];
            //不讀取檔案最後兩行空行
            for (int i = 0; i < count_Menu - 1; i++)
            {
                string str1 = r_Menu.ReadLine();  //讀取一列資料行
                if (str1 == null) break;  //若資料為空值，則跳過
                string[] str2 = str1.Split(cgap_Menu, StringSplitOptions.RemoveEmptyEntries);  //基於數組字串，將字串拆分為多少個子字串  //StringSplitOptions.RemoveEmptyEntries忽略空行  //StringSplitOptions.None不忽略空行

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

                //price
                // 調整陣列的大小
                System.Array.Resize(ref price, price.Length + 1);
                // 指定新的陣列值
                price[price.Length - 1] = str2[3];
            }

            for (int d = 0; d < name.Length; d++)
            {
                if (comboBox_AddName.Text == Convert.ToString(name[d]))
                {
                    label_UnitPrice.Text = Convert.ToString(price[d]);
                }
            }
        }

        private void textBox_Count_TextChanged(object sender, EventArgs e)
        {
            //設定最小值永為1
            if ((textBox_Count.Text == null) || (textBox_Count.Text == "") || (textBox_Count.Text == "0"))
            {
                textBox_Count.Text = "1";
            }
        }

        //+按鈕功能
        private void button_Increase_Click(object sender, EventArgs e)
        {
            int count = Int32.Parse(textBox_Count.Text);
            count += 1;
            textBox_Count.Text = count.ToString();
        }

        //-按鈕功能
        private void button_Reduce_Click(object sender, EventArgs e)
        {
            int count = Int32.Parse(textBox_Count.Text);
            count -= 1;
            textBox_Count.Text = count.ToString();
        }

        //加入Button
        private void button_Add_Click(object sender, EventArgs e)
        {
            if (textBox_TableNum.Text == null || textBox_TableNum.Text == "")
            {
                MessageBox.Show("請輸入桌號。");
                return;
            }

            if (comboBox_AddType.Text == null || comboBox_AddType.Text == "" || comboBox_AddName.Text == null || comboBox_AddName.Text == "")
            {
                MessageBox.Show("請選擇商品名稱。");
                return;
            }

            //In.txt
            //讀取資料
            string link_Menu;
            link_Menu = Application.StartupPath + "data\\Order.txt";
            StreamReader r_count_Menu = new StreamReader(link_Menu);
            string sepatator_Menu = ",";  //以逗號分割字串
            char[] cgap_Menu = sepatator_Menu.ToCharArray();
            //逐行讀取到底，計算資料行數量
            int count_Menu = 0;
            while (!r_count_Menu.EndOfStream)
            {
                r_count_Menu.ReadLine();  //讀取一列資料行
                count_Menu += 1;
            }
            //close the file
            r_count_Menu.Close();

            //開啟檔案
            StreamReader r_Menu = new StreamReader(link_Menu);
            string[] type = [];
            string[] name = [];
            string[] num = [];
            string[] price = [];
            //不讀取檔案最後兩行空行
            for (int i = 0; i < count_Menu - 1; i++)
            {
                string str1 = r_Menu.ReadLine();  //讀取一列資料行
                if (str1 == null) break;  //若資料為空值，則跳過
                string[] str2 = str1.Split(cgap_Menu, StringSplitOptions.RemoveEmptyEntries);  //基於數組字串，將字串拆分為多少個子字串  //StringSplitOptions.RemoveEmptyEntries忽略空行  //StringSplitOptions.None不忽略空行

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

                //price
                // 調整陣列的大小
                System.Array.Resize(ref price, price.Length + 1);
                // 指定新的陣列值
                price[price.Length - 1] = str2[3];
            }

            for (int d = 0; d < name.Length; d++)
            {
                if (comboBox_AddName.Text == Convert.ToString(name[d]))
                {
                    DateTime currentTime = DateTime.Now;
                    string booking_number = "";
                    string date = Convert.ToString(currentTime);

                    /*
                    Debug.WriteLine(date);
                    Debug.WriteLine(date.Substring(0, 1)); // 2
                    Debug.WriteLine(date.Substring(1, 1)); // 0
                    Debug.WriteLine(date.Substring(2, 1)); // 2
                    Debug.WriteLine(date.Substring(3, 1)); // 5
                    Debug.WriteLine(date.Substring(4, 1)); // /
                    Debug.WriteLine(date.Substring(5, 1)); // 8
                    Debug.WriteLine(date.Substring(6, 1)); // /
                    Debug.WriteLine(date.Substring(7, 1)); // 1
                    Debug.WriteLine(date.Substring(8, 1)); // 9
                    Debug.WriteLine("---------------------");

                    date = Convert.ToString("2025/10/19 下午 05:21:33");
                    Debug.WriteLine(date);
                    Debug.WriteLine(date.Substring(0, 1)); // 2
                    Debug.WriteLine(date.Substring(1, 1)); // 0
                    Debug.WriteLine(date.Substring(2, 1)); // 2
                    Debug.WriteLine(date.Substring(3, 1)); // 5
                    Debug.WriteLine(date.Substring(4, 1)); // /
                    Debug.WriteLine(date.Substring(5, 1)); // 1
                    Debug.WriteLine(date.Substring(6, 1)); // 0
                    Debug.WriteLine(date.Substring(7, 1)); // /
                    Debug.WriteLine(date.Substring(8, 1)); // 1
                    Debug.WriteLine(date.Substring(9, 1)); // 9
                    Debug.WriteLine("---------------------");
                    */

                    //date = Convert.ToString("2025/8/19 下午 05:21:33");
                    //date = Convert.ToString("2025/10/19 下午 05:21:33");


                    if (date.Substring(7, 1) != "/")
                    {
                        if (date.Substring(10, 2) == "上午")
                        {
                            booking_number = "D-0" + date.Substring(5, 1) + date.Substring(7, 2) + "M" + date.Substring(13, 2) + date.Substring(16, 2);
                        }
                        else if (date.Substring(10, 2) == "下午")
                        {
                            booking_number = "D-0" + date.Substring(5, 1) + date.Substring(7, 2) + "A" + date.Substring(13, 2) + date.Substring(16, 2);
                        }
                    }
                    else
                    {
                        if (date.Substring(11, 2) == "上午")
                        {
                            booking_number = "D-" + date.Substring(5, 2) + date.Substring(8, 2) + "M" + date.Substring(14, 2) + date.Substring(17, 2);
                        }
                        else if (date.Substring(11, 2) == "下午")
                        {
                            booking_number = "D-" + date.Substring(5, 2) + date.Substring(8, 2) + "A" + date.Substring(14, 2) + date.Substring(17, 2);
                        }
                    }

                    //listView_Menu寫入新資料
                    ListViewItem b = new ListViewItem(new string[] { type[d], name[d], num[d], price[d], Convert.ToString(textBox_Count.Text), Convert.ToString(textBox_TableNum.Text), booking_number, "已訂餐", Convert.ToString(currentTime) });
                    listView_Booking.Items.Add(b);

                    int TotalPrice = Int32.Parse(label_TotalPrice.Text);
                    TotalPrice += Int32.Parse(price[d]) * (Int32.Parse(textBox_Count.Text));
                    label_TotalPrice.Text = Convert.ToString(TotalPrice);
                }
            }

            textBox_Count.Text = "1";
            comboBox_AddType.Text = "";
            comboBox_AddName.Text = "";
            comboBox_AddName.Items.Clear();
        }

        //移除列Button
        private void button_Remove_Click(object sender, EventArgs e)
        {
            // 若沒有資料列，顯示提示框。
            if (listView_Booking.Items.Count > 0)
            {
                //若有資料列，但未選擇資料列，顯示提示框。
                if (listView_Booking.SelectedItems.Count > 0)
                {
                    listView_Booking.Items.Remove(listView_Booking.SelectedItems[0]);

                    int TotalPrice = Int32.Parse(label_TotalPrice.Text);
                    TotalPrice -= Int32.Parse(label_UnitPrice.Text) * (Int32.Parse(textBox_Count.Text));
                    label_TotalPrice.Text = Convert.ToString(TotalPrice);
                }
                else
                {
                    MessageBox.Show("請點選要移除的資料列。");
                    return;
                }
            }
            else
            {
                MessageBox.Show("沒有可移除的資料列。");
                return;
            }
        }

        //送出訂單Button
        private void button_Submit_Click(object sender, EventArgs e)
        {
            string booking_number_old;
            string booking_number_new;

            // 若沒有資料列，顯示提示框。
            if (listView_Booking.Items.Count > 0)
            {
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
                for (int m = 0; m < listView_Booking.Items.Count; m++)
                {
                    s += listView_Booking.Items[m].SubItems[0].Text + ",";
                    s += listView_Booking.Items[m].SubItems[1].Text + ",";
                    s += listView_Booking.Items[m].SubItems[4].Text + ",";
                    s += listView_Booking.Items[m].SubItems[5].Text + ",";

                    booking_number_old = listView_Booking.Items[m].SubItems[6].Text;
                    if (listView_Booking.Items.Count > 9)
                    {
                        if (m < 9)
                        {
                            booking_number_new = booking_number_old.Substring(0, 2) + "0" + Convert.ToString(m + 1) + "/" + Convert.ToString(listView_Booking.Items.Count) + "-" + booking_number_old.Substring(2, 9);
                        }
                        else
                        {
                            booking_number_new = booking_number_old.Substring(0, 2) + Convert.ToString(m + 1) + "/" + Convert.ToString(listView_Booking.Items.Count) + "-" + booking_number_old.Substring(2, 9);
                        }
                    }
                    else
                    {
                        if (m < 9)
                        {
                            booking_number_new = booking_number_old.Substring(0, 2) + "0" + Convert.ToString(m + 1) + "/" + "0" + Convert.ToString(listView_Booking.Items.Count) + "-" + booking_number_old.Substring(2, 9);
                        }
                        else
                        {
                            booking_number_new = booking_number_old.Substring(0, 2) + Convert.ToString(m + 1) + "/" + "0" + Convert.ToString(listView_Booking.Items.Count) + "-" + booking_number_old.Substring(2, 9);
                        }
                    }
                    s += booking_number_new + ",";

                    s += listView_Booking.Items[m].SubItems[7].Text + ",";
                    s += listView_Booking.Items[m].SubItems[8].Text + ",";
                    s += "\r\n";
                }

                string link_Save;
                link_Save = Application.StartupPath + "data\\Cooking.txt";
                using (StreamWriter sw = new StreamWriter(link_Save))
                {
                    sw.WriteLine(s);  //將listView資料寫入檔案
                }
                //MessageBox.Show("儲存成功：" + link_Save);










                //開啟檔案
                string link_Sale;
                link_Sale = Application.StartupPath + "data\\Sale.txt";
                StreamReader r_count_Sale = new StreamReader(link_Sale);
                string sepatator_Sale = ",";  //以逗號分割字串
                char[] cgap_Sale = sepatator_Sale.ToCharArray();
                //逐行讀取到底，計算資料行數量
                int count_Sale = 0;
                while (!r_count_Sale.EndOfStream)
                {
                    r_count_Sale.ReadLine();  //讀取一列資料行
                    count_Sale += 1;
                }
                //close the file
                r_count_Sale.Close();

                //設為空值
                string s_Sale = "";
                //開啟檔案
                StreamReader r_Sale = new StreamReader(link_Sale);
                //不讀取檔案最後兩行空行
                for (int i = 0; i < count_Sale - 1; i++)
                {
                    string str1_Sale = r_Sale.ReadLine();  //讀取一列資料行
                    if (str1_Sale == null) break;  //若資料為空值，則跳過
                    string[] str2_Sale = str1_Sale.Split(cgap, StringSplitOptions.RemoveEmptyEntries);  //基於數組字串，將字串拆分為多少個子字串  //StringSplitOptions.RemoveEmptyEntries忽略空行  //StringSplitOptions.None不忽略空行

                    //加入舊資料
                    for (int m = 0; m < str2_Sale.Length; m++)
                    {
                        s_Sale += str2_Sale[m] + ",";
                    }
                    //讀取舊資料最後一筆不換行
                    if (i != (count_Sale - 1))
                    {
                        s_Sale += "\r\n";
                    }
                }
                //close the file
                r_Sale.Close();

                //加入新資料
                for (int m = 0; m < listView_Booking.Items.Count; m++)
                {
                    for (int n = 0; n < listView_Booking.Items[m].SubItems.Count; n++)
                    {
                        if (n == 6)
                        {
                            booking_number_old = listView_Booking.Items[m].SubItems[6].Text;
                            if (listView_Booking.Items.Count > 9)
                            {
                                if (m < 9)
                                {
                                    booking_number_new = booking_number_old.Substring(0, 2) + "0" + Convert.ToString(m + 1) + "/" + Convert.ToString(listView_Booking.Items.Count) + "-" + booking_number_old.Substring(2, 9);
                                }
                                else
                                {
                                    booking_number_new = booking_number_old.Substring(0, 2) + Convert.ToString(m + 1) + "/" + Convert.ToString(listView_Booking.Items.Count) + "-" + booking_number_old.Substring(2, 9);
                                }
                            }
                            else
                            {
                                if (m < 9)
                                {
                                    booking_number_new = booking_number_old.Substring(0, 2) + "0" + Convert.ToString(m + 1) + "/" + "0" + Convert.ToString(listView_Booking.Items.Count) + "-" + booking_number_old.Substring(2, 9);
                                }
                                else
                                {
                                    booking_number_new = booking_number_old.Substring(0, 2) + Convert.ToString(m + 1) + "/" + "0" + Convert.ToString(listView_Booking.Items.Count) + "-" + booking_number_old.Substring(2, 9);
                                }
                            }
                            s_Sale += booking_number_new + ",";
                        }
                        else
                        {
                            s_Sale += listView_Booking.Items[m].SubItems[n].Text + ",";
                        }
                    }
                    s_Sale += "\r\n";
                }

                string link_Sale_Save;
                link_Sale_Save = Application.StartupPath + "data\\Sale.txt";
                using (StreamWriter sw = new StreamWriter(link_Sale_Save))
                {
                    sw.WriteLine(s_Sale);  //將listView資料寫入檔案
                }
                //MessageBox.Show("儲存成功：" + link_Sale_Save);
                MessageBox.Show("請稍後!我們馬上為您服務。");

                //只移除資料列，保留標題列
                this.listView_Booking.Items.Clear();
                label_TotalPrice.Text = "0";
            }
            else
            {
                MessageBox.Show("請加入商品，再重新送出訂單。");
                return;
            }
        }

        //按鈕樣式
        private void button_Submit_Mouse_Move(object sender, MouseEventArgs e)
        {
            button_Submit.BackColor = Color.SteelBlue;
            button_Submit.ForeColor = Color.White;
            button_Submit.Cursor = Cursors.Hand;
        }

        private void button_Submit_Mouse_Leave(object sender, EventArgs e)
        {
            button_Submit.BackColor = Color.FromArgb(0, 150, 150, 150);
            button_Submit.ForeColor = Color.FromArgb(0, 0, 0, 0);
        }

        private void button_Increase_Mouse_Move(object sender, MouseEventArgs e)
        {
            button_Increase.BackColor = Color.SteelBlue;
            button_Increase.ForeColor = Color.White;
            button_Increase.Cursor = Cursors.Hand;
        }

        private void button_Increase_Mouse_Leave(object sender, EventArgs e)
        {
            button_Increase.BackColor = Color.FromArgb(0, 150, 150, 150);
            button_Increase.ForeColor = Color.FromArgb(0, 0, 0, 0);
        }

        private void button_Reduce_Mouse_Move(object sender, MouseEventArgs e)
        {
            button_Reduce.BackColor = Color.SteelBlue;
            button_Reduce.ForeColor = Color.White;
            button_Reduce.Cursor = Cursors.Hand;
        }

        private void button_Reduce_Mouse_Leave(object sender, EventArgs e)
        {
            button_Reduce.BackColor = Color.FromArgb(0, 150, 150, 150);
            button_Reduce.ForeColor = Color.FromArgb(0, 0, 0, 0);
        }

        private void button_Add_Mouse_Move(object sender, MouseEventArgs e)
        {
            button_Add.BackColor = Color.SteelBlue;
            button_Add.ForeColor = Color.White;
            button_Add.Cursor = Cursors.Hand;
        }

        private void button_Add_Mouse_Leave(object sender, EventArgs e)
        {
            button_Add.BackColor = Color.FromArgb(0, 150, 150, 150);
            button_Add.ForeColor = Color.FromArgb(0, 0, 0, 0);
        }

        private void button_Remove_Mouse_Move(object sender, MouseEventArgs e)
        {
            button_Remove.BackColor = Color.SteelBlue;
            button_Remove.ForeColor = Color.White;
            button_Remove.Cursor = Cursors.Hand;
        }

        private void button_Remove_Mouse_Leave(object sender, EventArgs e)
        {
            button_Remove.BackColor = Color.FromArgb(0, 150, 150, 150);
            button_Remove.ForeColor = Color.FromArgb(0, 0, 0, 0);
        }
    }
}
