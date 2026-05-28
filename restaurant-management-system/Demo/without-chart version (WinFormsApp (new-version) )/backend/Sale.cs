using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WinFormsApp_OrderFood
{
    public partial class Sale : Form
    {
        public Sale()
        {
            InitializeComponent();

            //更新listView_Cooking函式
            Refresh_Sale();

            comboBox_Type.SelectedIndex = 0;
            comboBox_TableNum.SelectedIndex = 0;

            dateTimePicker_Start.Value = Convert.ToDateTime("2024/01/01");
            dateTimePicker_End.Value = Convert.ToDateTime("2024/12/31");
        }

        //更新listView_Sale函
        public void Refresh_Sale()
        {
            this.listView_Sale.Items.Clear();  //只移除資料列，保留標題列

            //Sale.txt
            //讀取資料
            string link;
            link = Application.StartupPath + "data\\Sale.txt";
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
            string[] type = [];
            string[] table_num = [];
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

                //table_num
                // 調整陣列的大小
                System.Array.Resize(ref table_num, table_num.Length + 1);
                // 指定新的陣列值
                table_num[table_num.Length - 1] = str2[5];

                //listView寫入新資料
                ListViewItem b = new ListViewItem(new string[] { str2[0], str2[1], str2[2], Convert.ToString("$ " + string.Format("{0:0,0}", str2[3])), str2[4], str2[5], str2[6], str2[7], str2[8] });
                listView_Sale.Items.Add(b);                
            }

            comboBox_Type.Items.Add("全部商品");
            //comboBox加入選項
            for (int d = 0; d < type.Length; d++)
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

                comboBox_TableNum.Items.Add("全部桌號");
                //comboBox加入選項
                comboBox_TableNum.Items.Add(table_num[d]);
                //comboBox移除重複選項
                for (int k = 0; k < comboBox_TableNum.Items.Count; k++)
                {
                    string cItem1 = comboBox_TableNum.Items[k].ToString();
                    for (int m = k + 1; m < comboBox_TableNum.Items.Count; m++)
                    {
                        string cItem2 = comboBox_TableNum.Items[m].ToString();
                        if (cItem1 == cItem2)
                        {
                            comboBox_TableNum.Items.RemoveAt(m);
                            comboBox_TableNum.Text = "";
                        }
                    }
                }
            }
            //close the file
            r.Close();
        }

        private void comboBox_Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_TableNum.Text = "";
            dateTimePicker_Start.Value = Convert.ToDateTime("2024/01/01");
            dateTimePicker_End.Value = Convert.ToDateTime("2024/12/31");

            //Sale.txt
            //讀取資料
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

            //開啟檔案
            StreamReader r_Sale = new StreamReader(link_Sale);
            this.listView_Sale.Items.Clear();  //只移除資料列，保留標題列                                                                                                
            //不讀取檔案最後兩行空行
            for (int i = 0; i < count_Sale - 1; i++)
            {
                string str1 = r_Sale.ReadLine();  //讀取一列資料行
                if (str1 == null) break;  //若資料為空值，則跳過
                string[] str2 = str1.Split(cgap_Sale, StringSplitOptions.RemoveEmptyEntries);  //基於數組字串，將字串拆分為多少個子字串  //StringSplitOptions.RemoveEmptyEntries忽略空行  //StringSplitOptions.None不忽略空行

                //篩選存放狀態
                if (comboBox_Type.Text == Convert.ToString(str2[0]))
                {
                    //listView寫入新資料
                    ListViewItem b = new ListViewItem(new string[] { str2[0], str2[1], str2[2], Convert.ToString("$ " + string.Format("{0:0,0}", str2[3])), str2[4], str2[5], str2[6], str2[7], str2[8] });
                    listView_Sale.Items.Add(b);
                }
                else if (comboBox_Type.Text == Convert.ToString("全部商品"))
                {
                    //更新listView_Sale函式
                    Refresh_Sale();
                }
            }
            //close the file
            r_Sale.Close();
        }

        private void comboBox_TableNum_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_Type.Text = "";
            dateTimePicker_Start.Value = Convert.ToDateTime("2024/01/01");
            dateTimePicker_End.Value = Convert.ToDateTime("2024/12/31");

            //Sale.txt
            //讀取資料
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

            //開啟檔案
            StreamReader r_Sale = new StreamReader(link_Sale);
            this.listView_Sale.Items.Clear();  //只移除資料列，保留標題列                                                                                                
            //不讀取檔案最後兩行空行
            for (int i = 0; i < count_Sale - 1; i++)
            {
                string str1 = r_Sale.ReadLine();  //讀取一列資料行
                if (str1 == null) break;  //若資料為空值，則跳過
                string[] str2 = str1.Split(cgap_Sale, StringSplitOptions.RemoveEmptyEntries);  //基於數組字串，將字串拆分為多少個子字串  //StringSplitOptions.RemoveEmptyEntries忽略空行  //StringSplitOptions.None不忽略空行

                //篩選存放狀態
                if (comboBox_TableNum.Text == Convert.ToString(str2[5]))
                {
                    //listView寫入新資料
                    ListViewItem b = new ListViewItem(new string[] { str2[0], str2[1], str2[2], Convert.ToString("$ " + string.Format("{0:0,0}", str2[3])), str2[4], str2[5], str2[6], str2[7], str2[8] });
                    listView_Sale.Items.Add(b);
                }
                else if (comboBox_TableNum.Text == Convert.ToString("全部商品"))
                {
                    //更新listView_Sale函式
                    Refresh_Sale();
                }
            }
            //close the file
            r_Sale.Close();
        }

        //DateTimePicker函式
        public void DateTimePicker()
        {
            //listView顯示所有資料函式
            Refresh_Sale();

            //Sale.txt
            //讀取資料
            string link_Order;
            link_Order = Application.StartupPath + "data\\Sale.txt";
            StreamReader r_count_Order = new StreamReader(link_Order);
            string sepatator_Order = ",";  //以逗號分割字串
            char[] cgap_Order = sepatator_Order.ToCharArray();
            //逐行讀取到底，計算資料行數量
            int count_Order = 0;
            while (!r_count_Order.EndOfStream)
            {
                r_count_Order.ReadLine();  //讀取一列資料行
                count_Order += 1;
            }
            //close the file
            r_count_Order.Close();

            //開啟檔案
            StreamReader r_Order = new StreamReader(link_Order);
            this.listView_Sale.Items.Clear();  //只移除資料列，保留標題列                                                                                                
            //不讀取檔案最後兩行空行
            for (int i = 0; i < count_Order - 1; i++)
            {
                string str1 = r_Order.ReadLine();  //讀取一列資料行
                if (str1 == null) break;  //若資料為空值，則跳過
                string[] str2 = str1.Split(cgap_Order, StringSplitOptions.RemoveEmptyEntries);  //基於數組字串，將字串拆分為多少個子字串  //StringSplitOptions.RemoveEmptyEntries忽略空行  //StringSplitOptions.None不忽略空行

                //篩選日期
                if ((Convert.ToDateTime(str2[8]) > Convert.ToDateTime(dateTimePicker_Start.Value)) && (Convert.ToDateTime(str2[8]) < Convert.ToDateTime(dateTimePicker_End.Value)))
                {
                    //listView寫入新資料
                    ListViewItem b = new ListViewItem(new string[] { str2[0], str2[1], str2[2], Convert.ToString("$ " + string.Format("{0:0,0}", str2[3])), str2[4], str2[5], str2[6], str2[7], str2[8] });
                    listView_Sale.Items.Add(b);
                }
            }
            //close the file
            r_Order.Close();
        }

        private void dateTimePicker_Start_ValueChanged(object sender, EventArgs e)
        {
            //DateTimePicker函式
            DateTimePicker();
        }

        private void dateTimePicker_End_ValueChanged(object sender, EventArgs e)
        {
            //DateTimePicker函式
            DateTimePicker();
        }
    }
}
