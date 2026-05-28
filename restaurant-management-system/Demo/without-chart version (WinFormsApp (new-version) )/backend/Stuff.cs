using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp_OrderFood
{
    public partial class Stuff : Form
    {
        public Stuff()
        {
            InitializeComponent();

            //更新listView_In函式
            Refresh_In();

            comboBox_Mode.SelectedIndex = 0;

            textBox_Number.Text = "1";
            label_Balance.Text = "0";

            //groupBox無邊框
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox2.FlatStyle = FlatStyle.Flat;
        }

        //groupBox無邊框
        private void groupBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(this.BackColor);
        }

        private void groupBox2_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(this.BackColor);
        }

        //更新listView_In函式
        public void Refresh_In()
        {
            this.listView_In.Items.Clear();  //只移除資料列，保留標題列

            //Ingredients.txt
            //讀取資料
            string link_In;
            link_In = Application.StartupPath + "data\\Ingredients.txt";
            StreamReader r_count_In = new StreamReader(link_In);
            string sepatator_In = ",";  //以逗號分割字串
            char[] cgap_In = sepatator_In.ToCharArray();
            //逐行讀取到底，計算資料行數量
            int count_In = 0;
            while (!r_count_In.EndOfStream)
            {
                r_count_In.ReadLine();  //讀取一列資料行
                count_In += 1;
            }
            //close the file
            r_count_In.Close();

            //開啟檔案
            StreamReader r_In = new StreamReader(link_In);
            string[] type = [];
            string[] num = [];
            string[] name = [];
            int[] count = [];
            string[] place = [];
            string[] mode = [];
            string[] time = [];
            //不讀取檔案最後兩行空行
            for (int i = 0; i < count_In - 1; i++)
            {
                string str1 = r_In.ReadLine();  //讀取一列資料行
                if (str1 == null) break;  //若資料為空值，則跳過
                string[] str2 = str1.Split(cgap_In, StringSplitOptions.RemoveEmptyEntries);  //基於數組字串，將字串拆分為多少個子字串  //StringSplitOptions.RemoveEmptyEntries忽略空行  //StringSplitOptions.None不忽略空行

                //listView_In寫入新資料
                ListViewItem b = new ListViewItem(new string[] { str2[0], str2[1], str2[2], str2[3], str2[4], str2[5], str2[6], str2[7] });
                listView_In.Items.Add(b);

                //type
                // 調整陣列的大小
                System.Array.Resize(ref type, type.Length + 1);
                // 指定新的陣列值
                type[type.Length - 1] = str2[0];

                //num
                // 調整陣列的大小
                System.Array.Resize(ref num, num.Length + 1);
                // 指定新的陣列值
                num[num.Length - 1] = str2[1];

                //name
                // 調整陣列的大小
                System.Array.Resize(ref name, name.Length + 1);
                // 指定新的陣列值
                name[name.Length - 1] = str2[2];

                //count
                // 調整陣列的大小
                System.Array.Resize(ref count, count.Length + 1);
                // 指定新的陣列值
                count[count.Length - 1] = 0;

                //place
                // 調整陣列的大小
                System.Array.Resize(ref place, place.Length + 1);
                // 指定新的陣列值
                place[place.Length - 1] = str2[5];

                //mode
                // 調整陣列的大小
                System.Array.Resize(ref mode, mode.Length + 1);
                // 指定新的陣列值
                mode[mode.Length - 1] = str2[6];

                //time
                // 調整陣列的大小
                System.Array.Resize(ref time, time.Length + 1);
                // 指定新的陣列值
                time[time.Length - 1] = str2[7];
            }

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

                //comboBox加入選項
                comboBox_Name.Items.Add(name[d]);
                //comboBox移除重複選項
                for (int k = 0; k < comboBox_Name.Items.Count; k++)
                {
                    string cItem1 = comboBox_Name.Items[k].ToString();
                    for (int m = k + 1; m < comboBox_Name.Items.Count; m++)
                    {
                        string cItem2 = comboBox_Name.Items[m].ToString();
                        if (cItem1 == cItem2)
                        {
                            comboBox_Name.Items.RemoveAt(m);
                            comboBox_Name.Text = "";
                        }
                    }
                }

                //comboBox加入選項
                comboBox_Place.Items.Add(place[d]);
                //comboBox移除重複選項
                for (int k = 0; k < comboBox_Place.Items.Count; k++)
                {
                    string cItem1 = comboBox_Place.Items[k].ToString();
                    for (int m = k + 1; m < comboBox_Place.Items.Count; m++)
                    {
                        string cItem2 = comboBox_Place.Items[m].ToString();
                        if (cItem1 == cItem2)
                        {
                            comboBox_Place.Items.RemoveAt(m);
                            comboBox_Place.Text = "";
                        }
                    }
                }

                //comboBox加入選項
                comboBox_Mode.Items.Add("全部");
                comboBox_Mode.Items.Add("餘額");
                comboBox_Mode.Items.Add(mode[d]);
                //comboBox移除重複選項
                for (int k = 0; k < comboBox_Mode.Items.Count; k++)
                {
                    string cItem1 = comboBox_Mode.Items[k].ToString();
                    for (int m = k + 1; m < comboBox_Mode.Items.Count; m++)
                    {
                        string cItem2 = comboBox_Mode.Items[m].ToString();
                        if (cItem1 == cItem2)
                        {
                            comboBox_Mode.Items.RemoveAt(m);
                            comboBox_Mode.Text = "";
                        }
                    }
                }
            }
            //close the file
            r_In.Close();
        }

        //更新listView_Stat函式
        public void Refresh_Stat()
        {
            this.listView_In.Items.Clear();  //只移除資料列，保留標題列

            //Ingredients.txt
            //讀取資料
            string link_In;
            link_In = Application.StartupPath + "data\\Ingredients.txt";
            StreamReader r_count_In = new StreamReader(link_In);
            string sepatator_In = ",";  //以逗號分割字串
            char[] cgap_In = sepatator_In.ToCharArray();
            //逐行讀取到底，計算資料行數量
            int count_In = 0;
            while (!r_count_In.EndOfStream)
            {
                r_count_In.ReadLine();  //讀取一列資料行
                count_In += 1;
            }
            //close the file
            r_count_In.Close();

            //開啟檔案
            StreamReader r_In = new StreamReader(link_In);
            string[] type = [];
            string[] num = [];
            string[] name = [];
            int[] count = [];
            string[] unit = [];
            string[] place = [];
            string[] mode = [];
            string[] time = [];
            //不讀取檔案最後兩行空行
            for (int i = 0; i < count_In - 1; i++)
            {
                string str1 = r_In.ReadLine();  //讀取一列資料行
                if (str1 == null) break;  //若資料為空值，則跳過
                string[] str2 = str1.Split(cgap_In, StringSplitOptions.RemoveEmptyEntries);  //基於數組字串，將字串拆分為多少個子字串  //StringSplitOptions.RemoveEmptyEntries忽略空行  //StringSplitOptions.None不忽略空行

                //type
                // 調整陣列的大小
                System.Array.Resize(ref type, type.Length + 1);
                // 指定新的陣列值
                type[type.Length - 1] = str2[0];

                //num
                // 調整陣列的大小
                System.Array.Resize(ref num, num.Length + 1);
                // 指定新的陣列值
                num[num.Length - 1] = str2[1];

                //name
                // 調整陣列的大小
                System.Array.Resize(ref name, name.Length + 1);
                // 指定新的陣列值
                name[name.Length - 1] = str2[2];

                //count
                // 調整陣列的大小
                System.Array.Resize(ref count, count.Length + 1);
                // 指定新的陣列值
                count[count.Length - 1] = 0;

                //unit
                // 調整陣列的大小
                System.Array.Resize(ref unit, unit.Length + 1);
                // 指定新的陣列值
                unit[unit.Length - 1] = str2[4];

                //place
                // 調整陣列的大小
                System.Array.Resize(ref place, place.Length + 1);
                // 指定新的陣列值
                place[place.Length - 1] = str2[5];

                //mode
                // 調整陣列的大小
                System.Array.Resize(ref mode, mode.Length + 1);
                // 指定新的陣列值
                mode[mode.Length - 1] = str2[6];

                //time
                // 調整陣列的大小
                System.Array.Resize(ref time, time.Length + 1);
                // 指定新的陣列值
                time[time.Length - 1] = str2[7];

                //原儲值金額加入新增儲值金額
                for (int j = 0; j < name.Length; j++)
                {
                    if (str2[2] == name[j])
                    {
                        switch (str2[6])
                        {
                            case "入料":
                                count[j] += Int32.Parse(str2[3]);
                                break;

                            case "出料":
                                count[j] -= Int32.Parse(str2[3]);
                                break;

                            case "溢出":
                                count[j] += Int32.Parse(str2[3]);
                                break;

                            case "短少":
                                count[j] -= Int32.Parse(str2[3]);
                                break;
                            default:
                                break;
                        }
                    }
                }
            }

            //找出重複資料
            int[] remove_num = [];
            for (int k = 0; k < name.Length; k++)
            {
                for (int m = k + 1; m < name.Length; m++)
                {
                    if (name[k] == name[m])
                    {
                        // 調整陣列的大小
                        System.Array.Resize(ref remove_num, remove_num.Length + 1);
                        // 指定新的陣列值
                        remove_num[remove_num.Length - 1] = m;
                    }
                }
            }

            //將重複資料的儲值變0
            for (int h = 0; h < remove_num.Length; h++)
            {
                //將重複資料的儲值變0
                type[remove_num[h]] = null;
                num[remove_num[h]] = null;
                name[remove_num[h]] = null;
                count[remove_num[h]] = 0;
                place[remove_num[h]] = null;
                mode[remove_num[h]] = null;
                time[remove_num[h]] = null;
            }

            //listView_In寫入新資料
            for (int d = 0; d < name.Length; d++)
            {
                //儲值變0的資料不寫入listView
                if (count[d] != 0)
                {
                    //現在時間
                    DateTime currentTime = DateTime.Now;
                    string mode_stat = Convert.ToString("餘額");
                    //listView_In寫入新資料
                    ListViewItem c = new ListViewItem(new string[] { type[d], num[d], name[d], Convert.ToString(count[d]), unit[d], place[d], mode_stat, Convert.ToString(currentTime) });
                    listView_In.Items.Add(c);
                }
            }
            //close the file
            r_In.Close();
        }

        //comboBox函式
        public void ComboBoxFind(String comboBoxText, int number)
        {
            //Ingredients.txt
            //讀取資料
            string link_inn;
            link_inn = Application.StartupPath + "data\\Ingredients.txt";
            StreamReader r_count_inn = new StreamReader(link_inn);
            string sepatator_inn = ",";  //以逗號分割字串
            char[] cgap_inn = sepatator_inn.ToCharArray();
            //逐行讀取到底，計算資料行數量
            int count_inn = 0;
            while (!r_count_inn.EndOfStream)
            {
                r_count_inn.ReadLine();  //讀取一列資料行
                count_inn += 1;
            }
            //close the file
            r_count_inn.Close();

            //開啟檔案
            StreamReader r_inn = new StreamReader(link_inn);
            int[] product_count_order = [];
            this.listView_In.Items.Clear();  //只移除資料列，保留標題列                                                                                                
            //不讀取檔案最後兩行空行
            for (int i = 0; i < count_inn - 1; i++)
            {
                string str1 = r_inn.ReadLine();  //讀取一列資料行
                if (str1 == null) break;  //若資料為空值，則跳過
                string[] str2 = str1.Split(cgap_inn, StringSplitOptions.RemoveEmptyEntries);  //基於數組字串，將字串拆分為多少個子字串  //StringSplitOptions.RemoveEmptyEntries忽略空行  //StringSplitOptions.None不忽略空行

                //篩選存放狀態
                if (comboBoxText == Convert.ToString(str2[number]))
                {
                    //listView寫入新資料
                    ListViewItem b = new ListViewItem(new string[] { str2[0], str2[1], str2[2], str2[3], str2[4], str2[5], str2[6], str2[7] });
                    listView_In.Items.Add(b);
                }
                else if (comboBox_Mode.Text == Convert.ToString("餘額"))
                {
                    //更新listView_Stat函式
                    Refresh_Stat();
                }
                else if (comboBox_Mode.Text == Convert.ToString("全部"))
                {
                    //更新listView_inn函式
                    Refresh_In();
                }
            }
            //close the file
            r_inn.Close();
        }

        //ComboBox功能
        private void comboBox_Mode_SelectedIndexChanged(object sender, EventArgs e)
        {
            //comboBox顯示空
            comboBox_Type.SelectedItem = null;
            comboBox_Name.SelectedItem = null;
            comboBox_Place.SelectedItem = null;

            //加入現有食材清空按鈕函式
            Clear_Now();

            radioButton_Infeed.Checked = false;
            radioButton_Outfeed.Checked = false;
            radioButton_Overflow.Checked = false;
            radioButton_Shortage.Checked = false;

            //comboBox函式
            ComboBoxFind(comboBox_Mode.Text, 6);
        }

        private void comboBox_Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            //comboBox顯示空
            comboBox_Name.SelectedItem = null;
            comboBox_Place.SelectedItem = null;
            comboBox_Mode.SelectedItem = null;

            //comboBox函式
            ComboBoxFind(comboBox_Type.Text, 0);
        }

        private void comboBox_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            //comboBox顯示空
            comboBox_Type.SelectedItem = null;
            comboBox_Place.SelectedItem = null;
            comboBox_Mode.SelectedItem = null;

            //comboBox函式
            ComboBoxFind(comboBox_Name.Text, 2);
        }

        private void comboBox_Place_SelectedIndexChanged(object sender, EventArgs e)
        {
            //comboBox顯示空
            comboBox_Type.SelectedItem = null;
            comboBox_Name.SelectedItem = null;
            comboBox_Mode.SelectedItem = null;

            //comboBox函式
            ComboBoxFind(comboBox_Place.Text, 5);
        }

        //Button樣式
        private void button_Confirm_Now_Mouse_Move(object sender, MouseEventArgs e)
        {
            button_Confirm_Now.BackColor = Color.SteelBlue;
            button_Confirm_Now.ForeColor = Color.White;
            button_Confirm_Now.Cursor = Cursors.Hand;
        }

        private void button_Confirm_Now_Mouse_Leave(object sender, EventArgs e)
        {
            button_Confirm_Now.BackColor = Color.FromArgb(0, 150, 150, 150);
            button_Confirm_Now.ForeColor = Color.FromArgb(0, 0, 0, 0);
        }

        private void button_Cancel_Now_Mouse_Move(object sender, MouseEventArgs e)
        {
            button_Cancel_Now.BackColor = Color.SteelBlue;
            button_Cancel_Now.ForeColor = Color.White;
            button_Cancel_Now.Cursor = Cursors.Hand;
        }

        private void button_Cancel_Now_Mouse_Leave(object sender, EventArgs e)
        {
            button_Cancel_Now.BackColor = Color.FromArgb(0, 150, 150, 150);
            button_Cancel_Now.ForeColor = Color.FromArgb(0, 0, 0, 0);
        }
        private void button_Save_Mouse_Move(object sender, MouseEventArgs e)
        {
            button_Save.BackColor = Color.SteelBlue;
            button_Save.ForeColor = Color.White;
            button_Save.Cursor = Cursors.Hand;
        }

        private void button_Save_Mouse_Leave(object sender, EventArgs e)
        {
            button_Save.BackColor = Color.FromArgb(0, 150, 150, 150);
            button_Save.ForeColor = Color.FromArgb(0, 0, 0, 0);
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

        private void button_Confirm_New_Mouse_Move(object sender, MouseEventArgs e)
        {
            button_Confirm_New.BackColor = Color.SteelBlue;
            button_Confirm_New.ForeColor = Color.White;
            button_Confirm_New.Cursor = Cursors.Hand;
        }

        private void button_Confirm_New_Mouse_Leave(object sender, EventArgs e)
        {
            button_Confirm_New.BackColor = Color.FromArgb(0, 150, 150, 150);
            button_Confirm_New.ForeColor = Color.FromArgb(0, 0, 0, 0);
        }

        private void button_Cancel_New_Mouse_Move(object sender, MouseEventArgs e)
        {
            button_Cancel_New.BackColor = Color.SteelBlue;
            button_Cancel_New.ForeColor = Color.White;
            button_Cancel_New.Cursor = Cursors.Hand;
        }

        private void button_Cancel_New_Mouse_Leave(object sender, EventArgs e)
        {
            button_Cancel_New.BackColor = Color.FromArgb(0, 150, 150, 150);
            button_Cancel_New.ForeColor = Color.FromArgb(0, 0, 0, 0);
        }

        private void comboBox_AddType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Ingredients.txt
            //讀取資料
            string link_In;
            link_In = Application.StartupPath + "data\\Ingredients.txt";
            StreamReader r_count_In = new StreamReader(link_In);
            string sepatator_In = ",";  //以逗號分割字串
            char[] cgap_In = sepatator_In.ToCharArray();
            //逐行讀取到底，計算資料行數量
            int count_In = 0;
            while (!r_count_In.EndOfStream)
            {
                r_count_In.ReadLine();  //讀取一列資料行
                count_In += 1;
            }
            //close the file
            r_count_In.Close();

            //開啟檔案
            StreamReader r_In = new StreamReader(link_In);
            string[] type = [];
            string[] num = [];
            string[] name = [];
            int[] count = [];
            string[] place = [];
            string[] mode = [];
            string[] time = [];
            //不讀取檔案最後兩行空行
            for (int i = 0; i < count_In - 1; i++)
            {
                string str1 = r_In.ReadLine();  //讀取一列資料行
                if (str1 == null) break;  //若資料為空值，則跳過
                string[] str2 = str1.Split(cgap_In, StringSplitOptions.RemoveEmptyEntries);  //基於數組字串，將字串拆分為多少個子字串  //StringSplitOptions.RemoveEmptyEntries忽略空行  //StringSplitOptions.None不忽略空行

                //type
                // 調整陣列的大小
                System.Array.Resize(ref type, type.Length + 1);
                // 指定新的陣列值
                type[type.Length - 1] = str2[0];

                //num
                // 調整陣列的大小
                System.Array.Resize(ref num, num.Length + 1);
                // 指定新的陣列值
                num[num.Length - 1] = str2[1];

                //name
                // 調整陣列的大小
                System.Array.Resize(ref name, name.Length + 1);
                // 指定新的陣列值
                name[name.Length - 1] = str2[2];

                //count
                // 調整陣列的大小
                System.Array.Resize(ref count, count.Length + 1);
                // 指定新的陣列值
                count[count.Length - 1] = 0;

                //place
                // 調整陣列的大小
                System.Array.Resize(ref place, place.Length + 1);
                // 指定新的陣列值
                place[place.Length - 1] = str2[5];

                //mode
                // 調整陣列的大小
                System.Array.Resize(ref mode, mode.Length + 1);
                // 指定新的陣列值
                mode[mode.Length - 1] = str2[6];

                //time
                // 調整陣列的大小
                System.Array.Resize(ref time, time.Length + 1);
                // 指定新的陣列值
                time[time.Length - 1] = str2[7];
            }

            //清空comboBox選項
            comboBox_AddName.Items.Clear();
            comboBox_AddName.Text = "";
            label_Count.Text = "0";
            label_Balance.Text = "0";
            textBox_Number.Text = "1";
            for (int j = 0; j < num.Length; j++)
            {
                //依照類型，comboBox加入所屬產品編號
                if (comboBox_AddType.Text == type[j])
                {
                    comboBox_AddName.Items.Add(name[j]);
                }

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
            //close the file
            r_In.Close();
        }

        private void comboBox_AddName_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Ingredients.txt
            //讀取資料
            string link_In;
            link_In = Application.StartupPath + "data\\Ingredients.txt";
            StreamReader r_count_In = new StreamReader(link_In);
            string sepatator_In = ",";  //以逗號分割字串
            char[] cgap_In = sepatator_In.ToCharArray();
            //逐行讀取到底，計算資料行數量
            int count_In = 0;
            while (!r_count_In.EndOfStream)
            {
                r_count_In.ReadLine();  //讀取一列資料行
                count_In += 1;
            }
            //close the file
            r_count_In.Close();

            //開啟檔案
            StreamReader r_In = new StreamReader(link_In);
            string[] type = [];
            string[] num = [];
            string[] name = [];
            int[] count = [];
            string[] place = [];
            string[] mode = [];
            string[] time = [];
            //不讀取檔案最後兩行空行
            for (int i = 0; i < count_In - 1; i++)
            {
                string str1 = r_In.ReadLine();  //讀取一列資料行
                if (str1 == null) break;  //若資料為空值，則跳過
                string[] str2 = str1.Split(cgap_In, StringSplitOptions.RemoveEmptyEntries);  //基於數組字串，將字串拆分為多少個子字串  //StringSplitOptions.RemoveEmptyEntries忽略空行  //StringSplitOptions.None不忽略空行

                //type
                // 調整陣列的大小
                System.Array.Resize(ref type, type.Length + 1);
                // 指定新的陣列值
                type[type.Length - 1] = str2[0];

                //num
                // 調整陣列的大小
                System.Array.Resize(ref num, num.Length + 1);
                // 指定新的陣列值
                num[num.Length - 1] = str2[1];

                //name
                // 調整陣列的大小
                System.Array.Resize(ref name, name.Length + 1);
                // 指定新的陣列值
                name[name.Length - 1] = str2[2];

                //count
                // 調整陣列的大小
                System.Array.Resize(ref count, count.Length + 1);
                // 指定新的陣列值
                count[count.Length - 1] = 0;

                //place
                // 調整陣列的大小
                System.Array.Resize(ref place, place.Length + 1);
                // 指定新的陣列值
                place[place.Length - 1] = str2[5];

                //mode
                // 調整陣列的大小
                System.Array.Resize(ref mode, mode.Length + 1);
                // 指定新的陣列值
                mode[mode.Length - 1] = str2[6];

                //time
                // 調整陣列的大小
                System.Array.Resize(ref time, time.Length + 1);
                // 指定新的陣列值
                time[time.Length - 1] = str2[7];

                //原儲值金額加入新增儲值金額
                for (int j = 0; j < name.Length; j++)
                {
                    if (str2[2] == name[j])
                    {
                        count[j] += Int32.Parse(str2[3]);
                    }
                }
            }

            //找出重複資料
            int[] remove_num = [];
            for (int k = 0; k < name.Length; k++)
            {
                for (int m = k + 1; m < name.Length; m++)
                {
                    if (name[k] == name[m])
                    {
                        //Debug.WriteLine(name[k] + m);

                        // 調整陣列的大小
                        System.Array.Resize(ref remove_num, remove_num.Length + 1);
                        // 指定新的陣列值
                        remove_num[remove_num.Length - 1] = m;
                    }
                }
            }

            //將重複資料的儲值變0
            for (int h = 0; h < remove_num.Length; h++)
            {
                //將重複資料的儲值變0
                type[remove_num[h]] = null;
                num[remove_num[h]] = null;
                name[remove_num[h]] = null;
                count[remove_num[h]] = 0;
                place[remove_num[h]] = null;
                mode[remove_num[h]] = null;
                time[remove_num[h]] = null;
            }

            label_Count.Text = "0";
            label_Balance.Text = "0";
            textBox_Number.Text = "1";
            for (int j = 0; j < name.Length; j++)
            {
                //依照產品名稱，label顯示所屬餘額
                if (comboBox_AddName.Text == name[j])
                {
                    label_Balance.Text = Convert.ToString(count[j]);
                }

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
            //close the file
            r_In.Close();
        }

        private void textBox_Number_TextChanged(object sender, EventArgs e)
        {
            //設定最小值永為1
            if ((textBox_Number.Text == null) || (textBox_Number.Text == "") || (textBox_Number.Text == "0"))
            {
                textBox_Number.Text = "1";
            }
        }

        //+按鈕功能
        private void button_Increase_Click(object sender, EventArgs e)
        {
            int count = Int32.Parse(label_Count.Text);
            int balance = Int32.Parse(label_Balance.Text);
            int number = Int32.Parse(textBox_Number.Text);

            if ((comboBox_AddType.Text == "") || (comboBox_AddName.Text == "") || (radioButton_Infeed.Checked == true) || (radioButton_Outfeed.Checked == true) || (radioButton_Overflow.Checked == true) || (radioButton_Shortage.Checked == true))
            {
                if (radioButton_Infeed.Checked == true)
                {
                    count += number;
                    balance += number;
                }
                else if ((balance > 0) && radioButton_Outfeed.Checked == true)
                {
                    if (balance > number)
                    {
                        count += number;
                        balance -= number;
                    }
                    else
                    {
                        count += balance;
                        balance -= balance;
                    }
                }
                else if (radioButton_Overflow.Checked == true)
                {
                    count += number;
                    balance += number;
                }
                else if ((balance > 0) && radioButton_Shortage.Checked == true)
                {
                    if (balance > number)
                    {
                        count += number;
                        balance -= number;
                    }
                    else
                    {
                        count += balance;
                        balance -= balance;
                    }
                }
                else
                {
                    //break;
                }

                label_Count.Text = count.ToString();
                label_Balance.Text = balance.ToString();
            }
        }

        //-按鈕功能
        private void button_Reduce_Click(object sender, EventArgs e)
        {
            int count = Int32.Parse(label_Count.Text);
            int balance = Int32.Parse(label_Balance.Text);
            int number = Int32.Parse(textBox_Number.Text);

            if ((comboBox_AddType.Text == "") || (comboBox_AddName.Text == "") || (radioButton_Infeed.Checked == true) || (radioButton_Outfeed.Checked == true) || (radioButton_Overflow.Checked == true) || (radioButton_Shortage.Checked == true))
            {
                if ((count > 0) && radioButton_Infeed.Checked == true)
                {
                    count -= number;
                    balance -= number;
                }
                else if ((count > 0) && radioButton_Outfeed.Checked == true)
                {
                    if (count < number)
                    {
                        balance += count;
                        count -= count;
                    }
                    else
                    {
                        count -= number;
                        balance += number;

                    }
                }
                else if ((count > 0) && radioButton_Overflow.Checked == true)
                {
                    count -= number;
                    balance -= number;
                }
                else if ((count > 0) && radioButton_Shortage.Checked == true)
                {
                    if (count < number)
                    {
                        balance += count;
                        count -= count;
                    }
                    else
                    {
                        count -= number;
                        balance += number;

                    }
                }
                else
                {
                    //break;
                }

                label_Count.Text = count.ToString();
                label_Balance.Text = balance.ToString();
            }
        }

        //Button功能
        //加入現有食材確定按鈕功能
        private void button_Confirm_Now_Click(object sender, EventArgs e)
        {
            //若comboBox、TextBox為空值，不執行
            if (string.IsNullOrEmpty(comboBox_AddType.Text) || string.IsNullOrEmpty(comboBox_AddName.Text) || string.IsNullOrEmpty(label_Count.Text) || ((radioButton_Infeed.Checked == false) && (radioButton_Outfeed.Checked == false) && (radioButton_Overflow.Checked == false) && (radioButton_Shortage.Checked == false)))
            {
                MessageBox.Show("請輸入內容");
                return;
            }

            if (label_Count.Text == "0")
            {
                MessageBox.Show("請輸入數量");
                return;
            }

            if (comboBox_Mode.SelectedIndex != 0)
            {
                MessageBox.Show("請選擇庫存狀態為全部後，再新增資料。");
                return;
            }


            //判斷產品對應資訊
            //Ingredients.txt
            //讀取資料
            string link_In;
            link_In = Application.StartupPath + "data\\Ingredients.txt";
            StreamReader r_count_In = new StreamReader(link_In);
            string sepatator_In = ",";  //以逗號分割字串
            char[] cgap_In = sepatator_In.ToCharArray();
            //逐行讀取到底，計算資料行數量
            int count_In = 0;
            while (!r_count_In.EndOfStream)
            {
                r_count_In.ReadLine();  //讀取一列資料行
                count_In += 1;
            }
            //close the file
            r_count_In.Close();

            //開啟檔案
            StreamReader r_In = new StreamReader(link_In);
            string[] num = [];
            string[] name = [];
            string[] unit = [];
            string[] place = [];
            string AddNum = "";
            string AddUnit = "";
            string AddPlace = "";
            //不讀取檔案最後兩行空行
            for (int i = 0; i < count_In - 1; i++)
            {
                string str1 = r_In.ReadLine();  //讀取一列資料行
                if (str1 == null) break;  //若資料為空值，則跳過
                string[] str2 = str1.Split(cgap_In, StringSplitOptions.RemoveEmptyEntries);  //基於數組字串，將字串拆分為多少個子字串  //StringSplitOptions.RemoveEmptyEntries忽略空行  //StringSplitOptions.None不忽略空行

                //num
                // 調整陣列的大小
                System.Array.Resize(ref num, num.Length + 1);
                // 指定新的陣列值
                num[num.Length - 1] = str2[1];

                //name
                // 調整陣列的大小
                System.Array.Resize(ref name, name.Length + 1);
                // 指定新的陣列值
                name[name.Length - 1] = str2[2];

                //unit
                // 調整陣列的大小
                System.Array.Resize(ref unit, unit.Length + 1);
                // 指定新的陣列值
                unit[unit.Length - 1] = str2[4];

                //place
                // 調整陣列的大小
                System.Array.Resize(ref place, place.Length + 1);
                // 指定新的陣列值
                place[place.Length - 1] = str2[5];
            }
            //close the file
            r_In.Close();

            for (int j = 0; j < num.Length; j++)
            {
                //依照類型，comboBox加入所屬產品編號
                if (comboBox_AddName.Text == name[j])
                {
                    AddNum = Convert.ToString(num[j]);
                    AddUnit = Convert.ToString(unit[j]);
                    AddPlace = Convert.ToString(place[j]);
                }
            }

            //新增表格內容
            ListViewItem item = new ListViewItem(comboBox_AddType.Text);
            item.SubItems.Add(AddNum);
            item.SubItems.Add(comboBox_AddName.Text);
            item.SubItems.Add(label_Count.Text);
            item.SubItems.Add(AddUnit);
            item.SubItems.Add(AddPlace);


            if (radioButton_Infeed.Checked == true)
            {
                item.SubItems.Add(radioButton_Infeed.Text);
            }
            else if (radioButton_Outfeed.Checked == true)
            {
                item.SubItems.Add(radioButton_Outfeed.Text);
            }
            else if (radioButton_Overflow.Checked == true)
            {
                item.SubItems.Add(radioButton_Overflow.Text);
            }
            else if (radioButton_Shortage.Checked == true)
            {
                item.SubItems.Add(radioButton_Shortage.Text);
            }
            else
            {
                //break;
            }

            //現在時間
            DateTime currentTime = DateTime.Now;
            item.SubItems.Add(Convert.ToString(currentTime));
            listView_In.Items.Add(item);

            //加入現有食材清空按鈕函式
            Clear_Now();
            radioButton_Infeed.Checked = false;
            radioButton_Outfeed.Checked = false;
            radioButton_Overflow.Checked = false;
            radioButton_Shortage.Checked = false;
        }

        //加入新食材確定按鈕功能
        private void button_Confirm_New_Click(object sender, EventArgs e)
        {
            //若comboBox、TextBox為空值，不執行
            if (string.IsNullOrEmpty(textBox_AddType.Text) || string.IsNullOrEmpty(textBox_AddName.Text) || string.IsNullOrEmpty(textBox_AddNum.Text) || string.IsNullOrEmpty(textBox_AddCount.Text) || string.IsNullOrEmpty(textBox_AddUnit.Text) || string.IsNullOrEmpty(textBox_AddPlace.Text))
            {
                MessageBox.Show("請輸入內容");
                return;
            }

            if (comboBox_Mode.SelectedIndex != 0)
            {
                MessageBox.Show("請選擇庫存狀態為全部後，再新增資料。");
                return;
            }

            //新增表格內容
            ListViewItem item = new ListViewItem(textBox_AddType.Text);
            item.SubItems.Add(textBox_AddNum.Text);
            item.SubItems.Add(textBox_AddName.Text);
            item.SubItems.Add(textBox_AddCount.Text);
            item.SubItems.Add(textBox_AddUnit.Text);
            item.SubItems.Add(textBox_AddPlace.Text);
            item.SubItems.Add("入料");

            //現在時間
            DateTime currentTime = DateTime.Now;
            item.SubItems.Add(Convert.ToString(currentTime));
            listView_In.Items.Add(item);

            //加入新食材取消按鈕功能
            Clear_New();
        }

        //儲存按鈕功能
        private void button_Save_Click(object sender, EventArgs e)
        {
            //若listView沒有資料列，顯示提示框。
            if (listView_In.Items.Count == 0)
            {
                MessageBox.Show("請還原原始資料");
                return;
            }

            string s = "";
            for (int m = 0; m < listView_In.Items.Count; m++)
            {
                for (int n = 0; n < listView_In.Items[m].SubItems.Count; n++)
                {
                    s += listView_In.Items[m].SubItems[n].Text + ",";
                }
                s += "\r\n";
            }

            string link;
            link = Application.StartupPath + "data\\Ingredients.txt";
            using (StreamWriter sw = new StreamWriter(link))
            {
                sw.WriteLine(s);  //將listView資料寫入檔案
            }
            MessageBox.Show("儲存成功：" + link);

            //更新listView_In函式
            Refresh_In();

            //更新listView_In函式
            Refresh_Stat();
        }

        //移除列按鈕功能
        private void button_Remove_Click(object sender, EventArgs e)
        {
            // 若沒有資料列，顯示提示框。
            if (listView_In.Items.Count > 0)
            {
                //若有資料列，但未選擇資料列，顯示提示框。
                if (listView_In.SelectedItems.Count > 0)
                {
                    listView_In.Items.Remove(listView_In.SelectedItems[0]);
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

        //listView_In 排序Button
        private void listView_In_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (listView_In.Sorting == SortOrder.Ascending)
            {
                listView_In.Sorting = SortOrder.Descending;
            }
            else
            {
                listView_In.Sorting = SortOrder.Ascending;
            }
            listView_In.Sort();
        }

        //加入現有食材清空按鈕函式
        public void Clear_Now()
        {
            comboBox_AddType.Text = "";
            comboBox_AddName.Text = "";
            label_Count.Text = "0";
            label_Balance.Text = "0";
            textBox_Number.Text = "1";
        }

        //加入新食材清空按鈕函式
        public void Clear_New()
        {
            textBox_AddType.Clear();
            textBox_AddName.Clear();
            textBox_AddNum.Clear();
            textBox_AddCount.Clear();
            textBox_AddUnit.Clear();
            textBox_AddPlace.Clear();
        }

        //加入現有食材取消按鈕功能
        private void button_Cancel_Now_Click(object sender, EventArgs e)
        {
            //加入現有食材清空按鈕函式
            Clear_Now();

            radioButton_Infeed.Checked = false;
            radioButton_Outfeed.Checked = false;
            radioButton_Overflow.Checked = false;
            radioButton_Shortage.Checked = false;
        }

        //加入新食材取消按鈕功能
        private void button_Cancel_New_Click(object sender, EventArgs e)
        {
            //加入新食材取消按鈕功能
            Clear_New();
        }

        private void radioButton_Infeed_CheckedChanged(object sender, EventArgs e)
        {
            if ((radioButton_Outfeed.Checked == true) || (radioButton_Overflow.Checked == true) || (radioButton_Shortage.Checked == true))
            {
                //加入現有食材清空按鈕函式
                Clear_Now();
            }
        }

        private void radioButton_Outfeed_CheckedChanged(object sender, EventArgs e)
        {
            if ((radioButton_Infeed.Checked == true) || (radioButton_Overflow.Checked == true) || (radioButton_Shortage.Checked == true))
            {
                //加入現有食材清空按鈕函式
                Clear_Now();
            }
        }

        private void radioButton_Overflow_CheckedChanged(object sender, EventArgs e)
        {
            if ((radioButton_Infeed.Checked == true) || (radioButton_Outfeed.Checked == true) || (radioButton_Shortage.Checked == true))
            {
                //加入現有食材清空按鈕函式
                Clear_Now();
            }
        }

        private void radioButton_Shortage_CheckedChanged(object sender, EventArgs e)
        {
            if ((radioButton_Infeed.Checked == true) || (radioButton_Outfeed.Checked == true) || (radioButton_Overflow.Checked == true))
            {
                //加入現有食材清空按鈕函式
                Clear_Now();
            }
        }
    }
}
