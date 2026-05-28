using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp_OrderFood
{
    public partial class Revenue : Form
    {
        public Revenue()
        {
            InitializeComponent();

            //更新listView_Menu函式
            Refresh_Sale();

            comboBox_Year.Text = "請選擇";
            comboBox_Analyze.Text = "請選擇";
            comboBox_Category.Text = "請選擇";
            comboBox_plt.Text = "請選擇";
            label_Year_Sale.Text = "$ -";
            comboBox_Product.Visible = false;
            button_Add.Visible = false;
            button_Clear.Visible = false;

            //清除Chart函式
            Clear();     
        }

        //更新listView_Sale函式
        public void Refresh_Sale()
        {
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

            //泡麵類,一度讚(紅燒牛),AA001,110,1,A - 001,D - 01 / 03 - 0820A0431,已訂餐,2025 / 8 / 20 下午 04:31:50,
            //類別 商品名稱 商品編號 商品價格 數量 桌號 訂單編號 訂單狀態 訂單日期

            //開啟檔案
            StreamReader r_Sale = new StreamReader(link_Sale);
            string[] type = [];
            string[] name = [];
            int[] price = [];
            int[] count = [];
            string[] date = [];
            //不讀取檔案最後兩行空行
            for (int i = 0; i < count_Sale - 1; i++)
            {
                string str1 = r_Sale.ReadLine();  //讀取一列資料行
                if (str1 == null) break;  //若資料為空值，則跳過
                string[] str2 = str1.Split(cgap_Sale, StringSplitOptions.RemoveEmptyEntries);  //基於數組字串，將字串拆分為多少個子字串  //StringSplitOptions.RemoveEmptyEntries忽略空行  //StringSplitOptions.None不忽略空行

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

                //price
                // 調整陣列的大小
                System.Array.Resize(ref price, price.Length + 1);
                // 指定新的陣列值
                price[price.Length - 1] = 0;

                //count
                // 調整陣列的大小
                System.Array.Resize(ref count, count.Length + 1);
                // 指定新的陣列值
                count[count.Length - 1] = 0;

                //date
                // 調整陣列的大小
                System.Array.Resize(ref date, date.Length + 1);
                // 指定新的陣列值
                date[date.Length - 1] = str2[8].Substring(0, 4);
            }

            //comboBox加入選項
            for (int d = 0; d < name.Length; d++)
            {
                //comboBox加入選項
                comboBox_Year.Items.Add("請選擇");
                comboBox_Year.Items.Add(date[d]);
                //comboBox移除重複選項
                for (int k = 0; k < comboBox_Year.Items.Count; k++)
                {
                    string cItem1 = comboBox_Year.Items[k].ToString();
                    for (int m = k + 1; m < comboBox_Year.Items.Count; m++)
                    {
                        string cItem2 = comboBox_Year.Items[m].ToString();
                        if (cItem1 == cItem2)
                        {
                            comboBox_Year.Items.RemoveAt(m);
                            comboBox_Year.Text = "";
                        }
                    }
                }

                //comboBox加入選項
                comboBox_Category.Items.Add("請選擇");
                comboBox_Category.Items.Add(type[d]);
                //comboBox移除重複選項
                for (int k = 0; k < comboBox_Category.Items.Count; k++)
                {
                    string cItem1 = comboBox_Category.Items[k].ToString();
                    for (int m = k + 1; m < comboBox_Category.Items.Count; m++)
                    {
                        string cItem2 = comboBox_Category.Items[m].ToString();
                        if (cItem1 == cItem2)
                        {
                            comboBox_Category.Items.RemoveAt(m);
                            comboBox_Category.Text = "";
                        }
                    }
                }
            }
            //close the file
            r_Sale.Close();

            //comboBox加入選項
            comboBox_plt.Items.Add("請選擇");
            comboBox_plt.Items.Add("折線圖");
            comboBox_plt.Items.Add("長條圖");
            comboBox_plt.Items.Add("圓餅圖");
            //comboBox移除重複選項
            for (int k = 0; k < comboBox_plt.Items.Count; k++)
            {
                string cItem1 = comboBox_plt.Items[k].ToString();
                for (int m = k + 1; m < comboBox_plt.Items.Count; m++)
                {
                    string cItem2 = comboBox_plt.Items[m].ToString();
                    if (cItem1 == cItem2)
                    {
                        comboBox_plt.Items.RemoveAt(m);
                        comboBox_plt.Text = "";
                    }
                }
            }

            //comboBox加入選項
            comboBox_Analyze.Items.Add("請選擇");
            comboBox_Analyze.Items.Add("銷售額");
            comboBox_Analyze.Items.Add("銷售量");
        }

        //年度銷售額label / 年度銷售量label
        private void comboBox_Year_SelectedIndexChanged(object sender, EventArgs e)
        {
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

            //泡麵類,一度讚(紅燒牛),AA001,110,1,A - 001,D - 01 / 03 - 0820A0431,已訂餐,2025 / 8 / 20 下午 04:31:50,
            //類別 商品名稱 商品編號 商品價格 數量 桌號 訂單編號 訂單狀態 訂單日期

            //開啟檔案
            StreamReader r_Sale = new StreamReader(link_Sale);
            string[] type = [];
            string[] name = [];
            int[] price = [];
            int[] count = [];
            string[] date = [];
            int Year_Sale = 0;
            int Year_Volume = 0;
            int unit_calculate = 0;
            int count_calculate = 0;
            int sale_calculate = 0;
            label_Year_Sale.Text = "$ -";
            label_Year_Volume.Text = " -";
            //不讀取檔案最後兩行空行
            for (int i = 0; i < count_Sale - 1; i++)
            {
                string str1 = r_Sale.ReadLine();  //讀取一列資料行
                if (str1 == null) break;  //若資料為空值，則跳過
                string[] str2 = str1.Split(cgap_Sale, StringSplitOptions.RemoveEmptyEntries);  //基於數組字串，將字串拆分為多少個子字串  //StringSplitOptions.RemoveEmptyEntries忽略空行  //StringSplitOptions.None不忽略空行

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

                //price
                // 調整陣列的大小
                System.Array.Resize(ref price, price.Length + 1);
                // 指定新的陣列值
                price[price.Length - 1] = 0;

                //count
                // 調整陣列的大小
                System.Array.Resize(ref count, count.Length + 1);
                // 指定新的陣列值
                count[count.Length - 1] = 0;

                //date
                // 調整陣列的大小
                System.Array.Resize(ref date, date.Length + 1);
                // 指定新的陣列值
                date[date.Length - 1] = str2[8].Substring(0, 4);

                //計算年度銷售額
                if (comboBox_Year.Text == date[i])
                {
                    unit_calculate = Int32.Parse(str2[3]);
                    count_calculate = Int32.Parse(str2[4]);
                    sale_calculate = unit_calculate * count_calculate;
                    Year_Sale += sale_calculate;
                    Year_Volume += count_calculate;
                    //Debug.WriteLine(Year_Sale);
                    //Debug.WriteLine(Year_Volume);
                }
            }
            //close the file
            r_Sale.Close();

            switch (comboBox_Year.Text)
            {
                case "請選擇":
                    label_Year_Sale.Text = "$ -";
                    label_Year_Volume.Text = " -";
                    label_Product_Sale.Text = "$ -";
                    label_Product_Volume.Text = " -";
                    break;
                default:
                    label_Year_Sale.Text = Convert.ToString("$ " + string.Format("{0:0,0}", Year_Sale));
                    label_Year_Volume.Text = Convert.ToString(string.Format("{0:0,0}", Year_Volume));
                    break;
            }
        }

        private void comboBox_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
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

            //泡麵類,一度讚(紅燒牛),AA001,110,1,A - 001,D - 01 / 03 - 0820A0431,已訂餐,2025 / 8 / 20 下午 04:31:50,
            //類別 商品名稱 商品編號 商品價格 數量 桌號 訂單編號 訂單狀態 訂單日期

            //開啟檔案
            StreamReader r_Sale = new StreamReader(link_Sale);
            string[] type = [];
            string[] name = [];
            //不讀取檔案最後兩行空行
            for (int i = 0; i < count_Sale - 1; i++)
            {
                string str1 = r_Sale.ReadLine();  //讀取一列資料行
                if (str1 == null) break;  //若資料為空值，則跳過
                string[] str2 = str1.Split(cgap_Sale, StringSplitOptions.RemoveEmptyEntries);  //基於數組字串，將字串拆分為多少個子字串  //StringSplitOptions.RemoveEmptyEntries忽略空行  //StringSplitOptions.None不忽略空行

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
            }

            //清空comboBox選項
            comboBox_Product.Items.Clear();
            for (int d = 0; d < name.Length; d++)
            {
                //依照部門，comboBox加入所屬姓名
                if (comboBox_Category.Text == type[d])
                {
                    comboBox_Product.Items.Add(name[d]);
                }

                //comboBox移除重複選項
                for (int k = 0; k < comboBox_Product.Items.Count; k++)
                {
                    string cItem1 = comboBox_Product.Items[k].ToString();
                    for (int m = k + 1; m < comboBox_Product.Items.Count; m++)
                    {
                        string cItem2 = comboBox_Product.Items[m].ToString();
                        if (cItem1 == cItem2)
                        {
                            comboBox_Product.Items.RemoveAt(m);
                            comboBox_Product.Text = "";
                        }
                    }
                }
            }
        }

        // 繪製 Sin / Cos 圖表（兩個圖區）
        public void ShowSinCosChart()
        {
            //清除Chart函式
            Clear();

            // 建立兩個系列
            Series sinSeries = new Series("Sin");
            sinSeries.ChartType = SeriesChartType.Line;
            sinSeries.ChartArea = "SinArea"; // 指定使用哪個圖區
            sinSeries.BorderWidth = 4; // 線條粗度（預設是 1）

            Series cosSeries = new Series("Cos");
            cosSeries.ChartType = SeriesChartType.Line;
            cosSeries.ChartArea = "CosArea";
            cosSeries.BorderWidth = 4; // 線條粗度

            // 加入 Series
            chart1.Series.Add(sinSeries);
            chart1.Series.Add(cosSeries);

            // 加上標題
            chart1.Titles.Add("Sin / Cos 函數圖形");

            // 加上圖例
            Legend legend = new Legend();
            chart1.Legends.Add(legend);

            // 建立兩個圖區（上下排列）
            ChartArea area1 = new ChartArea("SinArea");
            ChartArea area2 = new ChartArea("CosArea");

            // 設定圖區在圖表中的位置（百分比）
            area1.Position = new ElementPosition(5, 5, 70, 45);   // 寬度 70% 左上
            area2.Position = new ElementPosition(5, 55, 70, 40);  // 寬度 70% 左下

            chart1.ChartAreas.Add(area1);
            chart1.ChartAreas.Add(area2);

            // 加入資料點
            for (int i = 0; i < 720; i++)
            {
                double radians = i * 2 * Math.PI / 360;
                sinSeries.Points.AddXY(i, Math.Sin(radians));
                cosSeries.Points.AddXY(i, Math.Cos(radians));
            }
        }

        // 繪製 Sin / Cos 圖表（一個圖區）
        public void ShowSinCosConbineChart()
        {
            //清除Chart函式
            Clear();

            //版2
            // 建立兩個系列（Series） - Sin 與 Cos
            Series sinSeries = new Series("Sin");
            sinSeries.ChartType = SeriesChartType.Line;

            Series cosSeries = new Series("Cos");
            cosSeries.ChartType = SeriesChartType.Line;

            // 將 Series 加入圖表
            chart1.Series.Add(sinSeries);
            chart1.Series.Add(cosSeries);

            // 加入標題
            chart1.Titles.Add("Sin / Cos 函數圖形");

            // 建立圖例
            Legend legend = new Legend("Default");
            chart1.Legends.Add(legend);
            //chart1.Legends.Add("");

            // 加入資料點
            for (int i = 0; i < 720; i++)
            {
                double radians = i * 2 * Math.PI / 360;
                chart1.Series["Sin"].Points.AddXY(i, Math.Sin(radians));
                chart1.Series["Cos"].Points.AddXY(i, Math.Cos(radians));
            }
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            // 繪製 Sin / Cos 圖表（兩個圖區）
            ShowSinCosChart();

            // 繪製 Sin / Cos 圖表（一個圖區）
            ShowSinCosConbineChart();
        }

        //清除Chart函式
        public void Clear()
        {
            // 清除所有內容
            chart1.Series.Clear();
            chart1.ChartAreas.Clear();
            chart1.Legends.Clear();
            chart1.Titles.Clear();

            // 建立圖表區域（恢復預設）
            ChartArea area = new ChartArea("Default");
            chart1.ChartAreas.Add(area);

            // 清除圖表區域邊框
            area.BorderWidth = 0; // 清除邊框線寬
            area.BorderColor = Color.Transparent; // 設為透明
            area.BorderDashStyle = ChartDashStyle.NotSet; // 清除線條樣式

            // 邊框與格線恢復預設（可省略，除非你改過）
            area.AxisX.MajorGrid.LineColor = Color.LightGray;
            area.AxisY.MajorGrid.LineColor = Color.LightGray;
            area.BorderDashStyle = ChartDashStyle.Solid;
            area.BorderColor = Color.Gray;

            // 注意：不新增 Series，讓呼叫方決定要新增哪個 Series！
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            //清除Chart函式
            Clear();
        }

        // 繪製折線圖
        public void ShowLineChart(double[] data, string title)
        {
            //清除Chart函式
            Clear();

            // 新增 Series
            var salesSeries = new Series("Sales");
            salesSeries.ChartType = SeriesChartType.Line;
            chart1.Series.Add(salesSeries);

            // 設定圖表標題
            chart1.Titles.Clear();
            chart1.Titles.Add(title);
            chart1.Titles[0].Font = new Font("微軟正黑體", 14, FontStyle.Bold);

            // 設定 X 軸與 Y 軸標題
            chart1.ChartAreas[0].AxisX.Title = "月份";
            if (comboBox_Analyze.Text == "銷售額")
            {
                chart1.ChartAreas[0].AxisY.Title = "銷售額";
            }
            else
            {
                chart1.ChartAreas[0].AxisY.Title = "銷售量";
            }
            chart1.ChartAreas[0].AxisX.TitleFont = new Font("微軟正黑體", 12, FontStyle.Bold);
            chart1.ChartAreas[0].AxisY.TitleFont = new Font("微軟正黑體", 12, FontStyle.Bold);

            // 設定資料標記點為紅色圓點
            var series = chart1.Series[0];
            series.ChartType = SeriesChartType.Line;
            series.MarkerStyle = MarkerStyle.Circle;
            series.MarkerColor = Color.Red;
            series.MarkerSize = 8;
            series.Color = Color.Blue; // 線的顏色可自訂

            // 顯示資料標籤（數值）
            series.IsValueShownAsLabel = true;
            series.LabelForeColor = Color.Black;  // 數值字體顏色，可改成你要的
            series.Font = new Font("微軟正黑體", 10, FontStyle.Bold);  // 數值字體樣式
            if (comboBox_Analyze.Text == "銷售額")
            {
                // 顯示格式為：$ 12,345
                series.LabelFormat = "'$ ' #,0";
            }
            else
            {
                // 顯示格式為：12,345
                series.LabelFormat = "#,0";
            }
            // 設定格線顏色為淺灰
            chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.LightGray;
            chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray;

            // 設定圖表框線（上下左右都有）
            chart1.ChartAreas[0].BorderDashStyle = ChartDashStyle.Solid;
            chart1.ChartAreas[0].BorderWidth = 1;
            chart1.ChartAreas[0].BorderColor = Color.Gray;
            //chart1.ChartAreas[0].BorderSkin.SkinStyle = BorderSkinStyle.FrameThin1;    

            // 加入資料點
            string[] data_month = ["一月", "二月", "三月", "四月", "五月", "六月", "七月", "八月", "九月", "十月", "十一月", "十二月"];

            for (int i = 0; i < data_month.Length; i++)
            {
                chart1.Series[0].Points.AddXY(data_month[i], data[i]);
            }

            // 設定Y軸格式
            // 將 string 陣列轉成 double 陣列
            double[] sales = data.Select(s => Convert.ToDouble(s)).ToArray();
            // 取得實際的最大與最小銷售值
            double actualMin = sales.Min();
            double actualMax = sales.Max();
            double minY = 0;
            double maxY = 0;
            if (comboBox_Analyze.Text == "銷售額")
            {
                // 加入偏移量後，使用 10000 為單位做整數取整
                minY = Math.Floor((actualMin - 40000) / 10000) * 10000;
                maxY = Math.Ceiling((actualMax + 40000) / 10000) * 10000;
            }
            else
            {
                // 加入偏移量後，使用 10000 為單位做整數取整
                minY = Math.Floor((actualMin - 4000) / 1000) * 1000;
                maxY = Math.Ceiling((actualMax + 4000) / 1000) * 1000;
            }
            // 確保最小值不為負數
            if (minY < 0) minY = 0;
            // 設定 Y 軸範圍與間距
            var axisY = chart1.ChartAreas[0].AxisY;
            axisY.Minimum = minY;
            axisY.Maximum = maxY;
            if (comboBox_Analyze.Text == "銷售額")
            {
                axisY.Interval = 20000;  // 每 20,000 一格
                axisY.LabelStyle.Format = "'$ ' #,0";  // Y軸刻度格式：$ 20,000
            }
            else
            {
                axisY.Interval = 2000;  // 每 2,000 一格
                axisY.LabelStyle.Format = "#,0";  // Y軸刻度格式：2,000
            }
        }

        // 繪製長條圖函式
        public void ShowBarChart(string[] data_X, double[] data_Y, string title)
        {
            //清除Chart函式
            Clear();

            // 新增 Series
            var salesSeries = new Series("Sales");
            salesSeries.ChartType = SeriesChartType.Bar;
            chart1.Series.Add(salesSeries);

            // 設定圖表標題
            chart1.Titles.Clear();
            chart1.Titles.Add(title);
            chart1.Titles[0].Font = new Font("微軟正黑體", 14, FontStyle.Bold);

            // 設定 X 軸與 Y 軸標題
            chart1.ChartAreas[0].AxisX.Title = "商品類別";
            if (comboBox_Analyze.Text == "銷售額")
            {
                chart1.ChartAreas[0].AxisY.Title = "銷售額";
            }
            else
            {
                chart1.ChartAreas[0].AxisY.Title = "銷售量";
            }
            chart1.ChartAreas[0].AxisX.TitleFont = new Font("微軟正黑體", 12, FontStyle.Bold);
            chart1.ChartAreas[0].AxisY.TitleFont = new Font("微軟正黑體", 12, FontStyle.Bold);

            // 設定資料標記點為紅色圓點
            var series = chart1.Series[0];


            // 顯示資料標籤（數值）
            series.IsValueShownAsLabel = true;
            series.LabelForeColor = Color.Black;  // 數值字體顏色，可改成你要的
            series.Font = new Font("微軟正黑體", 10, FontStyle.Bold);  // 數值字體樣式
            if (comboBox_Analyze.Text == "銷售額")
            {
                // 顯示格式為：$ 12,345
                series.LabelFormat = "'$ ' #,0";
            }
            else
            {
                // 顯示格式為：12,345
                series.LabelFormat = "#,0";
            }
            // 設定格線顏色為淺灰
            chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.LightGray;
            chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray;

            // 設定圖表框線（上下左右都有）
            chart1.ChartAreas[0].BorderDashStyle = ChartDashStyle.Solid;
            chart1.ChartAreas[0].BorderWidth = 1;
            chart1.ChartAreas[0].BorderColor = Color.Gray;
            //chart1.ChartAreas[0].BorderSkin.SkinStyle = BorderSkinStyle.FrameThin1;    

            // 加入資料點
            for (int i = 0; i < data_X.Length; i++)
            {
                chart1.Series[0].Points.AddXY(data_X[i], data_Y[i]);
            }

            // 設定Y軸格式
            // 將 string 陣列轉成 double 陣列
            double[] sales = data_Y.Select(s => Convert.ToDouble(s)).ToArray();
            // 取得實際的最大與最小銷售值
            double actualMin = sales.Min();
            double actualMax = sales.Max();
            double minY = 0;
            double maxY = 0;
            if (comboBox_Analyze.Text == "銷售額")
            {
                // 加入偏移量後，使用 10000 為單位做整數取整
                minY = Math.Floor((actualMin - 40000) / 10000) * 10000;
                maxY = Math.Ceiling((actualMax + 40000) / 10000) * 10000;
            }
            else
            {
                // 加入偏移量後，使用 10000 為單位做整數取整
                minY = Math.Floor((actualMin - 4000) / 1000) * 1000;
                maxY = Math.Ceiling((actualMax + 4000) / 1000) * 1000;
            }
            // 確保最小值不為負數
            if (minY < 0) minY = 0;
            // 設定 Y 軸範圍與間距
            var axisY = chart1.ChartAreas[0].AxisY;
            axisY.Minimum = minY;
            axisY.Maximum = maxY;
            if (comboBox_Analyze.Text == "銷售額")
            {
                axisY.Interval = 100000;  // 每 100,000 一格
                axisY.LabelStyle.Format = "'$ ' #,0";  // Y軸刻度格式：$ 100,000
            }
            else
            {
                axisY.Interval = 2000;  // 每 2,000 一格
                axisY.LabelStyle.Format = "#,0";  // Y軸刻度格式：2,000
            }
        }

        // 繪製圓餅圖函式
        public void ShowPieChart(string[] data_X, double[] data_Y, string title)
        {
            //清除Chart函式
            Clear();

            // 新增 Series
            var pieSeries = new Series("Sales");
            pieSeries.ChartType = SeriesChartType.Pie;
            pieSeries.BorderWidth = 1;
            chart1.Series.Add(pieSeries);

            // 設定圖表標題
            chart1.Titles.Clear();
            chart1.Titles.Add(title);
            chart1.Titles[0].Font = new Font("微軟正黑體", 20, FontStyle.Bold);

            // 設定資料標記點的樣式
            var series = chart1.Series[0];
            series.MarkerStyle = MarkerStyle.Circle;
            series.MarkerColor = Color.Red;
            series.MarkerSize = 8;
            series.Color = Color.Blue; // 線的顏色可自訂

            // 顯示資料標籤（數值）
            series.IsValueShownAsLabel = true;
            series.LabelForeColor = Color.Black;  // 數值字體顏色，可改成你要的
            series.Font = new Font("微軟正黑體", 16, FontStyle.Bold);  // 數值字體樣式

            if (comboBox_Analyze.Text == "銷售額")
            {
                // 顯示格式為：$ 12,345
                series.LabelFormat = "'$ ' #,0";
            }
            else
            {
                // 顯示格式為：12,345
                series.LabelFormat = "#,0";
            }

            // 加入資料點
            for (int i = 0; i < data_X.Length; i++)
            {
                pieSeries.Points.AddXY(data_X[i], data_Y[i]);
            }

            // 顯示資料標籤並顯示名稱
            foreach (var point in pieSeries.Points)
            {
                point.IsValueShownAsLabel = true;
                if (comboBox_Analyze.Text == "銷售額")
                {
                    point.Label = $"{point.AxisLabel}{Environment.NewLine}{point.YValues[0]:$ #,0}";  // 中文與數字換行顯示
                }
                else
                {
                    point.Label = $"{point.AxisLabel}{Environment.NewLine}{point.YValues[0]:#,0}";  // 中文與數字換行顯示
                }
                point.LabelForeColor = Color.Black;  // 標籤字顏色
                point.Font = new Font("微軟正黑體", 16, FontStyle.Bold);  // 標籤字體樣式

            }

            // 設定圓餅圖顯示方式
            chart1.Series[0].BorderWidth = 2;
            chart1.Series[0].BorderColor = Color.Black;

            // 圓餅圖的色彩配置（可選）
            chart1.Series[0].Palette = ChartColorPalette.Pastel; //--------------
            //chart1.Series[0].Palette = ChartColorPalette.BrightPastel; //-------------
            //chart1.Series[0].Palette = ChartColorPalette.Fire;
            //chart1.Series[0].Palette = ChartColorPalette.Grayscale;
            //chart1.Series[0].Palette = ChartColorPalette.None;
            //chart1.Series[0].Palette = ChartColorPalette.Berry;
            //chart1.Series[0].Palette = ChartColorPalette.Bright;
            //chart1.Series[0].Palette = ChartColorPalette.Chocolate;
            //chart1.Series[0].Palette = ChartColorPalette.EarthTones;
            //chart1.Series[0].Palette = ChartColorPalette.Excel;
            //chart1.Series[0].Palette = ChartColorPalette.Light;
            //chart1.Series[0].Palette = ChartColorPalette.SeaGreen;
            //chart1.Series[0].Palette = ChartColorPalette.SemiTransparent;

            /*
            // 加上圖例並設置位置在右側
            chart1.Legends.Clear();  // 清除舊的圖例
            var legend = new Legend("Legend")
            {
                Docking = Docking.Right,          // 設定圖例放在右側
                Alignment = StringAlignment.Center,
                Font = new Font("微軟正黑體", 16, FontStyle.Bold), // 設定圖例字體大小
                BorderWidth = 2,                 // 設定邊框寬度
                BorderColor = Color.Black,       // 設定邊框顏色
                BackColor = Color.Transparent    // 設定圖例背景顏色
            };            
            chart1.Legends.Add(legend);
            */
        }

        //銷售分析Button
        private void button_Sales_Analyze_Click(object sender, EventArgs e)
        {
            if (comboBox_Year.Text == "請選擇")
            {
                MessageBox.Show("請選擇年份。");
                return;
            }

            if (comboBox_Analyze.Text == "請選擇")
            {
                MessageBox.Show("請選擇分析類型。");
                return;
            }

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

            //泡麵類,一度讚(紅燒牛),AA001,110,1,A - 001,D - 01 / 03 - 0820A0431,已訂餐,2025 / 8 / 20 下午 04:31:50,
            //類別 商品名稱 商品編號 商品價格 數量 桌號 訂單編號 訂單狀態 訂單日期

            //開啟檔案
            StreamReader r_Sale = new StreamReader(link_Sale);
            string[] type = [];
            string[] name = [];
            int[] price = [];
            int[] count = [];
            string[] date = [];
            string[] year = [];
            string[] month = [];
            int month_Jan_Sale = 0;
            int month_Feb_Sale = 0;
            int month_Mar_Sale = 0;
            int month_Apr_Sale = 0;
            int month_May_Sale = 0;
            int month_Jun_Sale = 0;
            int month_Jul_Sale = 0;
            int month_Aug_Sale = 0;
            int month_Sep_Sale = 0;
            int month_Oct_Sale = 0;
            int month_Nov_Sale = 0;
            int month_Dec_Sale = 0;
            int month_Jan_Volume = 0;
            int month_Feb_Volume = 0;
            int month_Mar_Volume = 0;
            int month_Apr_Volume = 0;
            int month_May_Volume = 0;
            int month_Jun_Volume = 0;
            int month_Jul_Volume = 0;
            int month_Aug_Volume = 0;
            int month_Sep_Volume = 0;
            int month_Oct_Volume = 0;
            int month_Nov_Volume = 0;
            int month_Dec_Volume = 0;
            //不讀取檔案最後兩行空行
            for (int i = 0; i < count_Sale - 1; i++)
            {
                string str1 = r_Sale.ReadLine();  //讀取一列資料行
                if (str1 == null) break;  //若資料為空值，則跳過
                string[] str2 = str1.Split(cgap_Sale, StringSplitOptions.RemoveEmptyEntries);  //基於數組字串，將字串拆分為多少個子字串  //StringSplitOptions.RemoveEmptyEntries忽略空行  //StringSplitOptions.None不忽略空行

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

                //price
                // 調整陣列的大小
                System.Array.Resize(ref price, price.Length + 1);
                // 指定新的陣列值
                price[price.Length - 1] = 0;

                //count
                // 調整陣列的大小
                System.Array.Resize(ref count, count.Length + 1);
                // 指定新的陣列值
                count[count.Length - 1] = 0;

                //date
                // 調整陣列的大小
                System.Array.Resize(ref date, date.Length + 1);
                // 指定新的陣列值
                date[date.Length - 1] = str2[8];

                //year
                // 調整陣列的大小
                System.Array.Resize(ref year, year.Length + 1);
                // 指定新的陣列值
                year[year.Length - 1] = str2[8].Substring(0, 4);

                if (date[i].Substring(7, 1) != "/")
                {
                    //month
                    // 調整陣列的大小
                    System.Array.Resize(ref month, month.Length + 1);
                    // 指定新的陣列值
                    month[month.Length - 1] = "0" + str2[8].Substring(5, 1);
                }
                else
                {
                    //month
                    // 調整陣列的大小
                    System.Array.Resize(ref month, month.Length + 1);
                    // 指定新的陣列值
                    month[month.Length - 1] = str2[8].Substring(5, 2);
                }

                //計算每月銷售量
                if (comboBox_Year.Text == year[i])
                {
                    int unit_calculate = Int32.Parse(str2[3]);
                    int count_calculate = Int32.Parse(str2[4]);
                    int sale_calculate = unit_calculate * count_calculate;

                    switch (month[i])
                    {
                        case "01":
                            month_Jan_Sale += sale_calculate;
                            month_Jan_Volume += count_calculate;
                            break;

                        case "02":
                            month_Feb_Sale += sale_calculate;
                            month_Feb_Volume += count_calculate;
                            break;

                        case "03":
                            month_Mar_Sale += sale_calculate;
                            month_Mar_Volume += count_calculate;
                            break;

                        case "04":
                            month_Apr_Sale += sale_calculate;
                            month_Apr_Volume += count_calculate;
                            break;

                        case "05":
                            month_May_Sale += sale_calculate;
                            month_May_Volume += count_calculate;
                            break;

                        case "06":
                            month_Jun_Sale += sale_calculate;
                            month_Jun_Volume += count_calculate;
                            break;

                        case "07":
                            month_Jul_Sale += sale_calculate;
                            month_Jul_Volume += count_calculate;
                            break;

                        case "08":
                            month_Aug_Sale += sale_calculate;
                            month_Aug_Volume += count_calculate;
                            break;

                        case "09":
                            month_Sep_Sale += sale_calculate;
                            month_Sep_Volume += count_calculate;
                            break;

                        case "10":
                            month_Oct_Sale += sale_calculate;
                            month_Oct_Volume += count_calculate;
                            break;

                        case "11":
                            month_Nov_Sale += sale_calculate;
                            month_Nov_Volume += count_calculate;
                            break;

                        case "12":
                            month_Dec_Sale += sale_calculate;
                            month_Dec_Volume += count_calculate;
                            break;
                        default:
                            break;
                    }
                }
            }
            //close the file
            r_Sale.Close();

            double[] data = [];
            switch (comboBox_Analyze.Text)
            {
                case "銷售額":
                    //顯示每月銷售額圖表
                    data = [month_Jan_Sale, month_Feb_Sale, month_Mar_Sale, month_Apr_Sale, month_May_Sale, month_Jun_Sale, month_Jul_Sale, month_Aug_Sale, month_Sep_Sale, month_Oct_Sale, month_Nov_Sale, month_Dec_Sale];
                    // 繪製折線圖
                    ShowLineChart(data, comboBox_Year.Text + "年銷售額統計");
                    break;

                case "銷售量":
                    //顯示每月銷售量圖表
                    data = [month_Jan_Volume, month_Feb_Volume, month_Mar_Volume, month_Apr_Volume, month_May_Volume, month_Jun_Volume, month_Jul_Volume, month_Aug_Volume, month_Sep_Volume, month_Oct_Volume, month_Nov_Volume, month_Dec_Volume];
                    // 繪製折線圖
                    ShowLineChart(data, comboBox_Year.Text + "年銷售量統計");
                    break;
                default:
                    break;
            }

            /*
            //輸出每月銷售額
            int total_Sale = month_Jan_Sale + month_Feb_Sale + month_Mar_Sale + month_Apr_Sale + month_May_Sale + month_Jun_Sale + month_Jul_Sale + month_Aug_Sale + month_Sep_Sale + month_Oct_Sale + month_Nov_Sale + month_Dec_Sale;
            Debug.WriteLine("一月" + month_Jan_Sale);
            Debug.WriteLine("二月" + month_Feb_Sale);
            Debug.WriteLine("三月" + month_Mar_Sale);
            Debug.WriteLine("四月" + month_Apr_Sale);
            Debug.WriteLine("五月" + month_May_Sale);
            Debug.WriteLine("六月" + month_Jun_Sale);
            Debug.WriteLine("七月" + month_Jul_Sale);
            Debug.WriteLine("八月" + month_Aug_Sale);
            Debug.WriteLine("九月" + month_Sep_Sale);
            Debug.WriteLine("十月" + month_Oct_Sale);
            Debug.WriteLine("十一月" + month_Nov_Sale);
            Debug.WriteLine("十二月" + month_Dec_Sale);
            Debug.WriteLine("總額" + total_Sale);
            
            //輸出每月銷售量
            int total_Volume = month_Jan_Volume + month_Feb_Volume + month_Mar_Volume + month_Apr_Volume + month_May_Volume + month_Jun_Volume + month_Jul_Volume + month_Aug_Volume + month_Sep_Volume + month_Oct_Volume + month_Nov_Volume + month_Dec_Volume;
            Debug.WriteLine("一月" + month_Jan_Volume);
            Debug.WriteLine("二月" + month_Feb_Volume);
            Debug.WriteLine("三月" + month_Mar_Volume);
            Debug.WriteLine("四月" + month_Apr_Volume);
            Debug.WriteLine("五月" + month_May_Volume);
            Debug.WriteLine("六月" + month_Jun_Volume);
            Debug.WriteLine("七月" + month_Jul_Volume);
            Debug.WriteLine("八月" + month_Aug_Volume);
            Debug.WriteLine("九月" + month_Sep_Volume);
            Debug.WriteLine("十月" + month_Oct_Volume);
            Debug.WriteLine("十一月" + month_Nov_Volume);
            Debug.WriteLine("十二月" + month_Dec_Volume);
            Debug.WriteLine("總量" + total_Volume);
            */
        }

        //商品類別分析Button
        private void button_Category_Analyze_Click(object sender, EventArgs e)
        {
            if (comboBox_Year.Text == "請選擇")
            {
                MessageBox.Show("請選擇年份。");
                return;
            }

            if (comboBox_Analyze.Text == "請選擇")
            {
                MessageBox.Show("請選擇分析類型。");
                return;
            }

            
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

            //泡麵類,一度讚(紅燒牛),AA001,110,1,A - 001,D - 01 / 03 - 0820A0431,已訂餐,2025 / 8 / 20 下午 04:31:50,
            //類別 商品名稱 商品編號 商品價格 數量 桌號 訂單編號 訂單狀態 訂單日期

            //開啟檔案
            StreamReader r_Sale = new StreamReader(link_Sale);
            string[] type = [];
            string[] name = [];
            int[] price = [];
            int[] count = [];
            string[] date = [];
            int[] Category_Sale = [];
            int[] Category_Volume = [];
            //不讀取檔案最後兩行空行
            for (int i = 0; i < count_Sale - 1; i++)
            {
                string str1 = r_Sale.ReadLine();  //讀取一列資料行
                if (str1 == null) break;  //若資料為空值，則跳過
                string[] str2 = str1.Split(cgap_Sale, StringSplitOptions.RemoveEmptyEntries);  //基於數組字串，將字串拆分為多少個子字串  //StringSplitOptions.RemoveEmptyEntries忽略空行  //StringSplitOptions.None不忽略空行

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

                //price
                // 調整陣列的大小
                System.Array.Resize(ref price, price.Length + 1);
                // 指定新的陣列值
                price[price.Length - 1] = 0;

                //count
                // 調整陣列的大小
                System.Array.Resize(ref count, count.Length + 1);
                // 指定新的陣列值
                count[count.Length - 1] = 0;

                //date
                // 調整陣列的大小
                System.Array.Resize(ref date, date.Length + 1);
                // 指定新的陣列值
                date[date.Length - 1] = str2[8].Substring(0, 4);

                //計算商品各類別銷售量
                if (comboBox_Year.Text == date[i])
                {
                    int unit_calculate = Int32.Parse(str2[3]);
                    int count_calculate = Int32.Parse(str2[4]);
                    int sale_calculate = unit_calculate * count_calculate;

                    for (int j = 0; j < comboBox_Category.Items.Count; j++)
                    {
                        //Category_Sale
                        // 調整陣列的大小
                        System.Array.Resize(ref Category_Sale, Category_Sale.Length + 1);
                        // 指定新的陣列值
                        Category_Sale[Category_Sale.Length - 1] = 0;

                        //Category_Volume
                        // 調整陣列的大小
                        System.Array.Resize(ref Category_Volume, Category_Volume.Length + 1);
                        // 指定新的陣列值
                        Category_Volume[Category_Volume.Length - 1] = 0;

                        if (Convert.ToString(comboBox_Category.Items[j]) == str2[0])
                        {
                            Category_Sale[j] += sale_calculate;
                            Category_Volume[j] += count_calculate;
                        }
                    }
                }
            }
            //close the file
            r_Sale.Close();



            //繪製長條圖函式
            List<string> data_X = new List<string>();
            List<double> data_Y = new List<double>();
            switch (comboBox_Analyze.Text)
            {
                case "銷售額":
                    for (int k = 0; k < comboBox_Category.Items.Count - 1; k++)
                    {
                        if (Category_Sale[k] != 0)
                        {
                            data_X.Add(Convert.ToString(comboBox_Category.Items[k]));
                            data_Y.Add(Category_Sale[k]);
                        }
                    }
                    // 繪製長條圖
                    ShowBarChart(data_X.ToArray(), data_Y.ToArray(), comboBox_Year.Text + "年各商品類別銷售額統計");
                    break;

                case "銷售量":
                    for (int k = 0; k < comboBox_Category.Items.Count - 1; k++)
                    {
                        if (Category_Volume[k] != 0)
                        {
                            data_X.Add(Convert.ToString(comboBox_Category.Items[k]));
                            data_Y.Add(Category_Volume[k]);
                        }
                    }
                    // 繪製長條圖
                    ShowBarChart(data_X.ToArray(), data_Y.ToArray(), comboBox_Year.Text + "年各商品類別銷售量統計");
                    break;
                default:
                    break;
            }
            


            /*
            //輸出商品各類別銷售額
            for (int k = 0; k < comboBox_Category.Items.Count - 1; k++)
            {
                if (Category_Sale[k] != 0)
                {
                    Debug.WriteLine(Convert.ToString(comboBox_Category.Items[k]) + Category_Sale[k]);
                }
            }

            //輸出商品各類別銷售量
            for (int k = 0; k < comboBox_Category.Items.Count - 1; k++)
            {
                if (Category_Volume[k] != 0)
                {
                    Debug.WriteLine(Convert.ToString(comboBox_Category.Items[k]) + Category_Volume[k]);
                }
            }
            */
        }

        //商品分析Button

        private void button_Product_Analyze_Click(object sender, EventArgs e)
        {
            if (comboBox_Year.Text == "請選擇")
            {
                MessageBox.Show("請選擇年份。");
                return;
            }

            if (comboBox_Category.Text == "請選擇")
            {
                MessageBox.Show("請選擇商品類別。");
                return;
            }

            if (comboBox_plt.Text == "請選擇")
            {
                MessageBox.Show("請選擇圖表。");
                return;
            }



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

            //泡麵類,一度讚(紅燒牛),AA001,110,1,A - 001,D - 01 / 03 - 0820A0431,已訂餐,2025 / 8 / 20 下午 04:31:50,
            //類別 商品名稱 商品編號 商品價格 數量 桌號 訂單編號 訂單狀態 訂單日期

            //開啟檔案
            StreamReader r_Sale = new StreamReader(link_Sale);
            string[] type = [];
            string[] name = [];
            int[] price = [];
            int[] count = [];
            string[] date = [];
            string[] year = [];
            string[] month = [];
            int month_Jan_Sale = 0;
            int month_Feb_Sale = 0;
            int month_Mar_Sale = 0;
            int month_Apr_Sale = 0;
            int month_May_Sale = 0;
            int month_Jun_Sale = 0;
            int month_Jul_Sale = 0;
            int month_Aug_Sale = 0;
            int month_Sep_Sale = 0;
            int month_Oct_Sale = 0;
            int month_Nov_Sale = 0;
            int month_Dec_Sale = 0;
            int month_Jan_Volume = 0;
            int month_Feb_Volume = 0;
            int month_Mar_Volume = 0;
            int month_Apr_Volume = 0;
            int month_May_Volume = 0;
            int month_Jun_Volume = 0;
            int month_Jul_Volume = 0;
            int month_Aug_Volume = 0;
            int month_Sep_Volume = 0;
            int month_Oct_Volume = 0;
            int month_Nov_Volume = 0;
            int month_Dec_Volume = 0;
            int[] Product_Sale = [];
            int[] Product_Volume = [];
            int Year_Sale_Product = 0;
            int Year_Volume_Product = 0;
            //不讀取檔案最後兩行空行
            for (int i = 0; i < count_Sale - 1; i++)
            {
                string str1 = r_Sale.ReadLine();  //讀取一列資料行
                if (str1 == null) break;  //若資料為空值，則跳過
                string[] str2 = str1.Split(cgap_Sale, StringSplitOptions.RemoveEmptyEntries);  //基於數組字串，將字串拆分為多少個子字串  //StringSplitOptions.RemoveEmptyEntries忽略空行  //StringSplitOptions.None不忽略空行

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

                //price
                // 調整陣列的大小
                System.Array.Resize(ref price, price.Length + 1);
                // 指定新的陣列值
                price[price.Length - 1] = 0;

                //count
                // 調整陣列的大小
                System.Array.Resize(ref count, count.Length + 1);
                // 指定新的陣列值
                count[count.Length - 1] = 0;

                //date
                // 調整陣列的大小
                System.Array.Resize(ref date, date.Length + 1);
                // 指定新的陣列值
                date[date.Length - 1] = str2[8];

                //year
                // 調整陣列的大小
                System.Array.Resize(ref year, year.Length + 1);
                // 指定新的陣列值
                year[year.Length - 1] = str2[8].Substring(0, 4);

                if (date[i].Substring(7, 1) != "/")
                {
                    //month
                    // 調整陣列的大小
                    System.Array.Resize(ref month, month.Length + 1);
                    // 指定新的陣列值
                    month[month.Length - 1] = "0" + str2[8].Substring(5, 1);
                }
                else
                {
                    //month
                    // 調整陣列的大小
                    System.Array.Resize(ref month, month.Length + 1);
                    // 指定新的陣列值
                    month[month.Length - 1] = str2[8].Substring(5, 2);
                }

                //計算商品每月銷售量及銷售額(折線圖)
                if (comboBox_Year.Text == year[i])
                {
                    if (comboBox_Category.Text == type[i])
                    {
                        int unit_calculate = Int32.Parse(str2[3]);
                        int count_calculate = Int32.Parse(str2[4]);
                        int sale_calculate = unit_calculate * count_calculate;

                        switch (month[i])
                        {
                            case "01":
                                month_Jan_Volume += count_calculate;
                                month_Jan_Sale += sale_calculate;
                                break;

                            case "02":
                                month_Feb_Volume += count_calculate;
                                month_Feb_Sale += sale_calculate;
                                break;

                            case "03":
                                month_Mar_Volume += count_calculate;
                                month_Mar_Sale += sale_calculate;
                                break;

                            case "04":
                                month_Apr_Volume += count_calculate;
                                month_Apr_Sale += sale_calculate;
                                break;

                            case "05":
                                month_May_Volume += count_calculate;
                                month_May_Sale += sale_calculate;
                                break;

                            case "06":
                                month_Jun_Volume += count_calculate;
                                month_Jun_Sale += sale_calculate;
                                break;

                            case "07":
                                month_Jul_Volume += count_calculate;
                                month_Jul_Sale += sale_calculate;
                                break;

                            case "08":
                                month_Aug_Volume += count_calculate;
                                month_Aug_Sale += sale_calculate;
                                break;

                            case "09":
                                month_Sep_Volume += count_calculate;
                                month_Sep_Sale += sale_calculate;
                                break;

                            case "10":
                                month_Oct_Volume += count_calculate;
                                month_Oct_Sale += sale_calculate;
                                break;

                            case "11":
                                month_Nov_Volume += count_calculate;
                                month_Nov_Sale += sale_calculate;
                                break;

                            case "12":
                                month_Dec_Volume += count_calculate;
                                month_Dec_Sale += sale_calculate;
                                break;
                            default:
                                //顯示每月銷售額圖表
                                break;
                        }
                    }
                }

                //計算商品銷售量及銷售額(圓餅圖/長條圖)
                if (comboBox_Year.Text == year[i])
                {
                    int unit_calculate = Int32.Parse(str2[3]);
                    int count_calculate = Int32.Parse(str2[4]);
                    int sale_calculate = unit_calculate * count_calculate;

                    //商品類別
                    if (comboBox_Category.Text == type[i])
                    {
                        for (int j = 0; j < comboBox_Product.Items.Count; j++)
                        {
                            //Product_Sale
                            // 調整陣列的大小
                            System.Array.Resize(ref Product_Sale, Product_Sale.Length + 1);
                            // 指定新的陣列值
                            Product_Sale[Product_Sale.Length - 1] = 0;

                            //Product_Volume
                            // 調整陣列的大小
                            System.Array.Resize(ref Product_Volume, Product_Volume.Length + 1);
                            // 指定新的陣列值
                            Product_Volume[Product_Volume.Length - 1] = 0;

                            if (Convert.ToString(comboBox_Product.Items[j]) == str2[1])
                            {
                                Product_Sale[j] += sale_calculate;
                                Product_Volume[j] += count_calculate;
                                Year_Sale_Product += sale_calculate;
                                Year_Volume_Product += count_calculate;
                            }
                        }
                    }
                }
            }
            //close the file
            r_Sale.Close();


            switch (comboBox_Category.Text)
            {
                case "請選擇":
                    label_Product_Sale.Text = "$ -";
                    label_Product_Volume.Text = " -";
                    break;
                default:
                    label_Product_Sale.Text = Convert.ToString("$ " + string.Format("{0:0,0}", Year_Sale_Product));
                    label_Product_Volume.Text = Convert.ToString(string.Format("{0:0,0}", Year_Volume_Product));
                    break;
            }

            //輸出商品每月銷售量及銷售額(折線圖)
            //輸出商品銷售量及銷售額(圓餅圖/長條圖)
            switch (comboBox_plt.Text)
            {
                case "折線圖":
                    double[] data = [];
                    switch (comboBox_Analyze.Text)
                    {
                        case "銷售額":
                            //顯示每月銷售額圖表
                            data = [month_Jan_Sale, month_Feb_Sale, month_Mar_Sale, month_Apr_Sale, month_May_Sale, month_Jun_Sale, month_Jul_Sale, month_Aug_Sale, month_Sep_Sale, month_Oct_Sale, month_Nov_Sale, month_Dec_Sale];
                            // 繪製折線圖
                            ShowLineChart(data, comboBox_Year.Text + "年" + comboBox_Category.Text + "銷售額統計");
                            break;

                        case "銷售量":
                            //顯示每月銷售量圖表
                            data = [month_Jan_Volume, month_Feb_Volume, month_Mar_Volume, month_Apr_Volume, month_May_Volume, month_Jun_Volume, month_Jul_Volume, month_Aug_Volume, month_Sep_Volume, month_Oct_Volume, month_Nov_Volume, month_Dec_Volume];
                            // 繪製折線圖
                            ShowLineChart(data, comboBox_Year.Text + "年" + comboBox_Category.Text + "銷售量統計");
                            break;
                        default:
                            break;
                    }
                    break;

                case "長條圖":

                    //繪製長條圖函式
                    List<string> data_X = new List<string>();
                    List<double> data_Y = new List<double>();

                    if (comboBox_Product.Items.Count == 0)
                    {
                        MessageBox.Show("此商品無銷售數據。");
                        //MessageBox.Show("沒有可用的產品，無法繪製圖表。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;  // 退出方法，避免繪圖錯誤
                    }

                    switch (comboBox_Analyze.Text)
                    {
                        case "銷售額":

                            for (int k = 0; k < comboBox_Product.Items.Count; k++)
                            {
                                // 確保 k 沒超過 Product_Sale 的長度
                                if (k < Product_Sale.Length && Product_Sale[k] != 0)
                                {
                                    data_X.Add(Convert.ToString(comboBox_Product.Items[k]));
                                    data_Y.Add(Product_Sale[k]);
                                }
                            }

                            // 檢查是否有有效數據
                            if (data_X.Count > 0 && data_Y.Count > 0)
                            {
                                // 繪製長條圖
                                ShowBarChart(data_X.ToArray(), data_Y.ToArray(), comboBox_Year.Text + "年" + comboBox_Category.Text + "銷售額統計");
                            }
                            else
                            {
                                MessageBox.Show("此商品無銷售數據。");
                                //MessageBox.Show("沒有有效的銷售額數據，無法繪製圖表。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            // 繪製長條圖
                            ShowBarChart(data_X.ToArray(), data_Y.ToArray(), comboBox_Year.Text + "年" + comboBox_Category.Text + "銷售額統計");
                            break;

                        case "銷售量":
                            for (int k = 0; k < comboBox_Product.Items.Count; k++)
                            {
                                // 確保 k 沒超過 Product_Sale 的長度
                                if (k < Product_Volume.Length && Product_Volume[k] != 0)
                                {
                                    data_X.Add(Convert.ToString(comboBox_Product.Items[k]));
                                    data_Y.Add(Product_Volume[k]);
                                }
                            }


                            // 檢查是否有有效數據
                            if (data_X.Count > 0 && data_Y.Count > 0)
                            {
                                // 繪製長條圖
                                ShowBarChart(data_X.ToArray(), data_Y.ToArray(), comboBox_Year.Text + "年" + comboBox_Category.Text + "銷售額統計");
                            }
                            else
                            {
                                MessageBox.Show("此商品無銷售數據。");
                                //MessageBox.Show("沒有有效的銷售額數據，無法繪製圖表。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            // 繪製長條圖
                            ShowBarChart(data_X.ToArray(), data_Y.ToArray(), comboBox_Year.Text + "年" + comboBox_Category.Text + "銷售量統計");
                            break;
                        default:
                            break;
                    }
                    break;

                case "圓餅圖":
                    //繪製圓餅圖函式
                    List<string> data_X_Pie = new List<string>();
                    List<double> data_Y_Pie = new List<double>();

                    if (comboBox_Product.Items.Count == 0)
                    {
                        MessageBox.Show("此商品無銷售數據。");
                        //MessageBox.Show("沒有可用的產品，無法繪製圖表。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;  // 退出方法，避免繪圖錯誤
                    }

                    switch (comboBox_Analyze.Text)
                    {
                        case "銷售額":

                            for (int k = 0; k < comboBox_Product.Items.Count; k++)
                            {
                                // 確保 k 沒超過 Product_Sale 的長度
                                if (k < Product_Sale.Length && Product_Sale[k] != 0)
                                {
                                    data_X_Pie.Add(Convert.ToString(comboBox_Product.Items[k]));
                                    data_Y_Pie.Add(Product_Sale[k]);
                                }
                            }

                            // 檢查是否有有效數據
                            if (data_X_Pie.Count > 0 && data_Y_Pie.Count > 0)
                            {
                                // 繪製圓餅圖
                                ShowPieChart(data_X_Pie.ToArray(), data_Y_Pie.ToArray(), comboBox_Year.Text + "年" + comboBox_Category.Text + "銷售額統計");
                            }
                            else
                            {
                                MessageBox.Show("此商品無銷售數據。");
                                //MessageBox.Show("沒有有效的銷售額數據，無法繪製圖表。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            // 繪製圓餅圖
                            ShowPieChart(data_X_Pie.ToArray(), data_Y_Pie.ToArray(), comboBox_Year.Text + "年" + comboBox_Category.Text + "銷售額統計");
                            break;

                        case "銷售量":
                            for (int k = 0; k < comboBox_Product.Items.Count; k++)
                            {
                                // 確保 k 沒超過 Product_Sale 的長度
                                if (k < Product_Volume.Length && Product_Volume[k] != 0)
                                {
                                    data_X_Pie.Add(Convert.ToString(comboBox_Product.Items[k]));
                                    data_Y_Pie.Add(Product_Volume[k]);
                                }
                            }


                            // 檢查是否有有效數據
                            if (data_X_Pie.Count > 0 && data_Y_Pie.Count > 0)
                            {
                                // 繪製圓餅圖
                                ShowPieChart(data_X_Pie.ToArray(), data_Y_Pie.ToArray(), comboBox_Year.Text + "年" + comboBox_Category.Text + "銷售額統計");
                            }
                            else
                            {
                                MessageBox.Show("此商品無銷售數據。");
                                //MessageBox.Show("沒有有效的銷售額數據，無法繪製圖表。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            // 繪製圓餅圖
                            ShowPieChart(data_X_Pie.ToArray(), data_Y_Pie.ToArray(), comboBox_Year.Text + "年" + comboBox_Category.Text + "銷售量統計");
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }


            /*
            //輸出商品銷售額
            for (int k = 0; k < comboBox_Product.Items.Count; k++)
            {
                if (Product_Sale[k] != 0)
                {
                    Debug.WriteLine(Convert.ToString(comboBox_Product.Items[k]) + Product_Sale[k]);
                }
            }

            //輸出商品銷售量
            for (int k = 0; k < comboBox_Product.Items.Count; k++)
            {
                if (Product_Volume[k] != 0)
                {
                    Debug.WriteLine(Convert.ToString(comboBox_Product.Items[k]) + Product_Volume[k]);
                }
            }
            */


            /*            
            //輸出商品每月銷售額
            int total_Sale = month_Jan_Sale + month_Feb_Sale + month_Mar_Sale + month_Apr_Sale + month_May_Sale + month_Jun_Sale + month_Jul_Sale + month_Aug_Sale + month_Sep_Sale + month_Oct_Sale + month_Nov_Sale + month_Dec_Sale;
            Debug.WriteLine("一月" + comboBox_Category.Text + month_Jan_Sale);
            Debug.WriteLine("二月" + comboBox_Category.Text + month_Feb_Sale);
            Debug.WriteLine("三月" + comboBox_Category.Text + month_Mar_Sale);
            Debug.WriteLine("四月" + comboBox_Category.Text + month_Apr_Sale);
            Debug.WriteLine("五月" + comboBox_Category.Text + month_May_Sale);
            Debug.WriteLine("六月" + comboBox_Category.Text + month_Jun_Sale);
            Debug.WriteLine("七月" + comboBox_Category.Text + month_Jul_Sale);
            Debug.WriteLine("八月" + comboBox_Category.Text + month_Aug_Sale);
            Debug.WriteLine("九月" + comboBox_Category.Text + month_Sep_Sale);
            Debug.WriteLine("十月" + comboBox_Category.Text + month_Oct_Sale);
            Debug.WriteLine("十一月" + comboBox_Category.Text + month_Nov_Sale);
            Debug.WriteLine("十二月" + comboBox_Category.Text + month_Dec_Sale);
            Debug.WriteLine("總額" + comboBox_Category.Text + total_Sale);
            
            //輸出商品每月銷售量
            int total_Volume = month_Jan_Volume + month_Feb_Volume + month_Mar_Volume + month_Apr_Volume + month_May_Volume + month_Jun_Volume + month_Jul_Volume + month_Aug_Volume + month_Sep_Volume + month_Oct_Volume + month_Nov_Volume + month_Dec_Volume;
            Debug.WriteLine("一月" + comboBox_Category.Text + month_Jan_Volume);
            Debug.WriteLine("二月" + comboBox_Category.Text + month_Feb_Volume);
            Debug.WriteLine("三月" + comboBox_Category.Text + month_Mar_Volume);
            Debug.WriteLine("四月" + comboBox_Category.Text + month_Apr_Volume);
            Debug.WriteLine("五月" + comboBox_Category.Text + month_May_Volume);
            Debug.WriteLine("六月" + comboBox_Category.Text + month_Jun_Volume);
            Debug.WriteLine("七月" + comboBox_Category.Text + month_Jul_Volume);
            Debug.WriteLine("八月" + comboBox_Category.Text + month_Aug_Volume);
            Debug.WriteLine("九月" + comboBox_Category.Text + month_Sep_Volume);
            Debug.WriteLine("十月" + comboBox_Category.Text + month_Oct_Volume);
            Debug.WriteLine("十一月" + comboBox_Category.Text + month_Nov_Volume);
            Debug.WriteLine("十二月" + comboBox_Category.Text + month_Dec_Volume);
            Debug.WriteLine("總量" + comboBox_Category.Text + total_Volume);
            */
        }

        private void comboBox_plt_SelectedIndexChanged(object sender, EventArgs e)
        {
            //商品分析
            //輸出商品每月銷售量及銷售額(折線圖)
            //輸出商品銷售量及銷售額(圓餅圖/長條圖)
        }
        
        //按鈕樣式
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

        private void button_Clear_Mouse_Move(object sender, MouseEventArgs e)
        {
            button_Clear.BackColor = Color.SteelBlue;
            button_Clear.ForeColor = Color.White;
            button_Clear.Cursor = Cursors.Hand;
        }

        private void button_Clear_Mouse_Leave(object sender, EventArgs e)
        {
            button_Clear.BackColor = Color.FromArgb(0, 150, 150, 150);
            button_Clear.ForeColor = Color.FromArgb(0, 0, 0, 0);
        }

        private void button_Sales_Analyze_Mouse_Move(object sender, MouseEventArgs e)
        {
            button_Sales_Analyze.BackColor = Color.SteelBlue;
            button_Sales_Analyze.ForeColor = Color.White;
            button_Sales_Analyze.Cursor = Cursors.Hand;
        }

        private void button_Sales_Analyze_Mouse_Leave(object sender, EventArgs e)
        {
            button_Sales_Analyze.BackColor = Color.FromArgb(0, 150, 150, 150);
            button_Sales_Analyze.ForeColor = Color.FromArgb(0, 0, 0, 0);
        }

        private void button_Category_Analyze_Mouse_Move(object sender, MouseEventArgs e)
        {
            button_Category_Analyze.BackColor = Color.SteelBlue;
            button_Category_Analyze.ForeColor = Color.White;
            button_Category_Analyze.Cursor = Cursors.Hand;
        }

        private void button_Category_Analyze_Mouse_Leave(object sender, EventArgs e)
        {
            button_Category_Analyze.BackColor = Color.FromArgb(0, 150, 150, 150);
            button_Category_Analyze.ForeColor = Color.FromArgb(0, 0, 0, 0);
        }

        private void button_Product_Analyze_Mouse_Move(object sender, MouseEventArgs e)
        {
            button_Product_Analyze.BackColor = Color.SteelBlue;
            button_Product_Analyze.ForeColor = Color.White;
            button_Product_Analyze.Cursor = Cursors.Hand;
        }

        private void button_Product_Analyze_Mouse_Leave(object sender, EventArgs e)
        {
            button_Product_Analyze.BackColor = Color.FromArgb(0, 150, 150, 150);
            button_Product_Analyze.ForeColor = Color.FromArgb(0, 0, 0, 0);
        }
    }
}
