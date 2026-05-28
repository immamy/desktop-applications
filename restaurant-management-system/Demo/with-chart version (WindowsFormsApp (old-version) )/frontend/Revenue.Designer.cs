namespace WindowsFormsApp_OrderFood
{
    partial class Revenue
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button_Add = new System.Windows.Forms.Button();
            this.button_Clear = new System.Windows.Forms.Button();
            this.button_Sales_Analyze = new System.Windows.Forms.Button();
            this.comboBox_Year = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_Year_Sale = new System.Windows.Forms.Label();
            this.button_Category_Analyze = new System.Windows.Forms.Button();
            this.button_Product_Analyze = new System.Windows.Forms.Button();
            this.comboBox_Category = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_plt = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_Product = new System.Windows.Forms.ComboBox();
            this.comboBox_Analyze = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label_Year_Volume = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label_Product_Sale = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label_Product_Volume = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(295, 12);
            this.chart1.Name = "chart1";
            series2.BorderWidth = 4;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(1152, 773);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // button_Add
            // 
            this.button_Add.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20F);
            this.button_Add.Location = new System.Drawing.Point(1199, 710);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(121, 75);
            this.button_Add.TabIndex = 2;
            this.button_Add.Text = "顯示";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            this.button_Add.MouseLeave += new System.EventHandler(this.button_Add_Mouse_Leave);
            this.button_Add.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button_Add_Mouse_Move);
            // 
            // button_Clear
            // 
            this.button_Clear.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20F);
            this.button_Clear.Location = new System.Drawing.Point(1326, 710);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(117, 75);
            this.button_Clear.TabIndex = 2;
            this.button_Clear.Text = "清除";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            this.button_Clear.MouseLeave += new System.EventHandler(this.button_Clear_Mouse_Leave);
            this.button_Clear.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button_Clear_Mouse_Move);
            // 
            // button_Sales_Analyze
            // 
            this.button_Sales_Analyze.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20F);
            this.button_Sales_Analyze.Location = new System.Drawing.Point(12, 287);
            this.button_Sales_Analyze.Name = "button_Sales_Analyze";
            this.button_Sales_Analyze.Size = new System.Drawing.Size(205, 65);
            this.button_Sales_Analyze.TabIndex = 2;
            this.button_Sales_Analyze.Text = "銷售分析";
            this.button_Sales_Analyze.UseVisualStyleBackColor = true;
            this.button_Sales_Analyze.Click += new System.EventHandler(this.button_Sales_Analyze_Click);
            this.button_Sales_Analyze.MouseLeave += new System.EventHandler(this.button_Sales_Analyze_Mouse_Leave);
            this.button_Sales_Analyze.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button_Sales_Analyze_Mouse_Move);
            // 
            // comboBox_Year
            // 
            this.comboBox_Year.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F);
            this.comboBox_Year.FormattingEnabled = true;
            this.comboBox_Year.Location = new System.Drawing.Point(115, 10);
            this.comboBox_Year.Name = "comboBox_Year";
            this.comboBox_Year.Size = new System.Drawing.Size(121, 44);
            this.comboBox_Year.TabIndex = 3;
            this.comboBox_Year.SelectedIndexChanged += new System.EventHandler(this.comboBox_Year_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F);
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 36);
            this.label1.TabIndex = 4;
            this.label1.Text = "年份：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F);
            this.label2.Location = new System.Drawing.Point(13, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 36);
            this.label2.TabIndex = 4;
            this.label2.Text = "年度銷售額：";
            // 
            // label_Year_Sale
            // 
            this.label_Year_Sale.AutoSize = true;
            this.label_Year_Sale.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F);
            this.label_Year_Sale.Location = new System.Drawing.Point(13, 158);
            this.label_Year_Sale.Name = "label_Year_Sale";
            this.label_Year_Sale.Size = new System.Drawing.Size(50, 36);
            this.label_Year_Sale.TabIndex = 4;
            this.label_Year_Sale.Text = "$ -";
            // 
            // button_Category_Analyze
            // 
            this.button_Category_Analyze.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20F);
            this.button_Category_Analyze.Location = new System.Drawing.Point(12, 358);
            this.button_Category_Analyze.Name = "button_Category_Analyze";
            this.button_Category_Analyze.Size = new System.Drawing.Size(277, 65);
            this.button_Category_Analyze.TabIndex = 2;
            this.button_Category_Analyze.Text = "商品類別分析";
            this.button_Category_Analyze.UseVisualStyleBackColor = true;
            this.button_Category_Analyze.Click += new System.EventHandler(this.button_Category_Analyze_Click);
            this.button_Category_Analyze.MouseLeave += new System.EventHandler(this.button_Category_Analyze_Mouse_Leave);
            this.button_Category_Analyze.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button_Category_Analyze_Mouse_Move);
            // 
            // button_Product_Analyze
            // 
            this.button_Product_Analyze.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20F);
            this.button_Product_Analyze.Location = new System.Drawing.Point(17, 546);
            this.button_Product_Analyze.Name = "button_Product_Analyze";
            this.button_Product_Analyze.Size = new System.Drawing.Size(205, 65);
            this.button_Product_Analyze.TabIndex = 2;
            this.button_Product_Analyze.Text = "商品分析";
            this.button_Product_Analyze.UseVisualStyleBackColor = true;
            this.button_Product_Analyze.Click += new System.EventHandler(this.button_Product_Analyze_Click);
            this.button_Product_Analyze.MouseLeave += new System.EventHandler(this.button_Product_Analyze_Mouse_Leave);
            this.button_Product_Analyze.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button_Product_Analyze_Mouse_Move);
            // 
            // comboBox_Category
            // 
            this.comboBox_Category.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F);
            this.comboBox_Category.FormattingEnabled = true;
            this.comboBox_Category.Location = new System.Drawing.Point(173, 439);
            this.comboBox_Category.Name = "comboBox_Category";
            this.comboBox_Category.Size = new System.Drawing.Size(121, 44);
            this.comboBox_Category.TabIndex = 3;
            this.comboBox_Category.SelectedIndexChanged += new System.EventHandler(this.comboBox_Category_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F);
            this.label4.Location = new System.Drawing.Point(13, 439);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 36);
            this.label4.TabIndex = 4;
            this.label4.Text = "商品類別：";
            // 
            // comboBox_plt
            // 
            this.comboBox_plt.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F);
            this.comboBox_plt.FormattingEnabled = true;
            this.comboBox_plt.Location = new System.Drawing.Point(173, 493);
            this.comboBox_plt.Name = "comboBox_plt";
            this.comboBox_plt.Size = new System.Drawing.Size(121, 44);
            this.comboBox_plt.TabIndex = 3;
            this.comboBox_plt.SelectedIndexChanged += new System.EventHandler(this.comboBox_plt_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F);
            this.label5.Location = new System.Drawing.Point(13, 493);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 36);
            this.label5.TabIndex = 4;
            this.label5.Text = "圖表：";
            // 
            // comboBox_Product
            // 
            this.comboBox_Product.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F);
            this.comboBox_Product.FormattingEnabled = true;
            this.comboBox_Product.Location = new System.Drawing.Point(300, 439);
            this.comboBox_Product.Name = "comboBox_Product";
            this.comboBox_Product.Size = new System.Drawing.Size(121, 44);
            this.comboBox_Product.TabIndex = 3;
            // 
            // comboBox_Analyze
            // 
            this.comboBox_Analyze.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F);
            this.comboBox_Analyze.FormattingEnabled = true;
            this.comboBox_Analyze.Location = new System.Drawing.Point(115, 62);
            this.comboBox_Analyze.Name = "comboBox_Analyze";
            this.comboBox_Analyze.Size = new System.Drawing.Size(121, 44);
            this.comboBox_Analyze.TabIndex = 3;
            this.comboBox_Analyze.SelectedIndexChanged += new System.EventHandler(this.comboBox_Year_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F);
            this.label3.Location = new System.Drawing.Point(12, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 36);
            this.label3.TabIndex = 4;
            this.label3.Text = "分析：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F);
            this.label6.Location = new System.Drawing.Point(13, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(183, 36);
            this.label6.TabIndex = 4;
            this.label6.Text = "年度銷售量：";
            // 
            // label_Year_Volume
            // 
            this.label_Year_Volume.AutoSize = true;
            this.label_Year_Volume.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F);
            this.label_Year_Volume.Location = new System.Drawing.Point(13, 245);
            this.label_Year_Volume.Name = "label_Year_Volume";
            this.label_Year_Volume.Size = new System.Drawing.Size(34, 36);
            this.label_Year_Volume.TabIndex = 4;
            this.label_Year_Volume.Text = " -";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F);
            this.label8.Location = new System.Drawing.Point(13, 628);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(183, 36);
            this.label8.TabIndex = 4;
            this.label8.Text = "商品銷售額：";
            // 
            // label_Product_Sale
            // 
            this.label_Product_Sale.AutoSize = true;
            this.label_Product_Sale.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F);
            this.label_Product_Sale.Location = new System.Drawing.Point(13, 668);
            this.label_Product_Sale.Name = "label_Product_Sale";
            this.label_Product_Sale.Size = new System.Drawing.Size(50, 36);
            this.label_Product_Sale.TabIndex = 4;
            this.label_Product_Sale.Text = "$ -";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F);
            this.label10.Location = new System.Drawing.Point(13, 716);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(183, 36);
            this.label10.TabIndex = 4;
            this.label10.Text = "商品銷售量：";
            // 
            // label_Product_Volume
            // 
            this.label_Product_Volume.AutoSize = true;
            this.label_Product_Volume.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F);
            this.label_Product_Volume.Location = new System.Drawing.Point(13, 756);
            this.label_Product_Volume.Name = "label_Product_Volume";
            this.label_Product_Volume.Size = new System.Drawing.Size(27, 36);
            this.label_Product_Volume.TabIndex = 4;
            this.label_Product_Volume.Text = "-";
            // 
            // Revenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1459, 797);
            this.Controls.Add(this.label_Year_Volume);
            this.Controls.Add(this.label_Product_Volume);
            this.Controls.Add(this.label_Product_Sale);
            this.Controls.Add(this.label_Year_Sale);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_plt);
            this.Controls.Add(this.comboBox_Product);
            this.Controls.Add(this.comboBox_Category);
            this.Controls.Add(this.comboBox_Analyze);
            this.Controls.Add(this.comboBox_Year);
            this.Controls.Add(this.button_Product_Analyze);
            this.Controls.Add(this.button_Category_Analyze);
            this.Controls.Add(this.button_Sales_Analyze);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.chart1);
            this.Name = "Revenue";
            this.Text = "Revenue";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.Button button_Sales_Analyze;
        private System.Windows.Forms.ComboBox comboBox_Year;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_Year_Sale;
        private System.Windows.Forms.Button button_Category_Analyze;
        private System.Windows.Forms.Button button_Product_Analyze;
        private System.Windows.Forms.ComboBox comboBox_Category;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_plt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_Product;
        private System.Windows.Forms.ComboBox comboBox_Analyze;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_Year_Volume;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label_Product_Sale;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label_Product_Volume;
    }
}