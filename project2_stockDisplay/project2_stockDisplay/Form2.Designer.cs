namespace project2_stockDisplay
{
    partial class Form2
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart_price = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_volume = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ticker_label = new System.Windows.Forms.Label();
            this.dateTimePicker_startDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_endDate = new System.Windows.Forms.DateTimePicker();
            this.label_startDate = new System.Windows.Forms.Label();
            this.label_endDate = new System.Windows.Forms.Label();
            this.button_clear = new System.Windows.Forms.Button();
            this.comboBox_patterns = new System.Windows.Forms.ComboBox();
            this.label_candlestickPattern = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_bearish = new System.Windows.Forms.Label();
            this.label_bullish = new System.Windows.Forms.Label();
            this.label_doji = new System.Windows.Forms.Label();
            this.label_dragonfly = new System.Windows.Forms.Label();
            this.label_gravestone = new System.Windows.Forms.Label();
            this.label_hammer = new System.Windows.Forms.Label();
            this.label_invertedHammer = new System.Windows.Forms.Label();
            this.label_marubozu = new System.Windows.Forms.Label();
            this.label_neutral = new System.Windows.Forms.Label();
            this.label_info = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart_price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_volume)).BeginInit();
            this.SuspendLayout();
            // 
            // chart_price
            // 
            chartArea3.Name = "ChartArea1";
            this.chart_price.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart_price.Legends.Add(legend3);
            this.chart_price.Location = new System.Drawing.Point(11, 31);
            this.chart_price.Margin = new System.Windows.Forms.Padding(2);
            this.chart_price.Name = "chart_price";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Candlestick;
            series3.Legend = "Legend1";
            series3.Name = "Daily OHLC";
            series3.YValuesPerPoint = 4;
            this.chart_price.Series.Add(series3);
            this.chart_price.Size = new System.Drawing.Size(742, 218);
            this.chart_price.TabIndex = 1;
            this.chart_price.Text = "Price Chart";
            // 
            // chart_volume
            // 
            chartArea4.Name = "ChartArea1";
            this.chart_volume.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart_volume.Legends.Add(legend4);
            this.chart_volume.Location = new System.Drawing.Point(11, 259);
            this.chart_volume.Margin = new System.Windows.Forms.Padding(2);
            this.chart_volume.Name = "chart_volume";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Candlestick;
            series4.Legend = "Legend1";
            series4.Name = "Volume";
            series4.YValuesPerPoint = 4;
            this.chart_volume.Series.Add(series4);
            this.chart_volume.Size = new System.Drawing.Size(742, 176);
            this.chart_volume.TabIndex = 2;
            this.chart_volume.Text = "chart2";
            // 
            // ticker_label
            // 
            this.ticker_label.AutoSize = true;
            this.ticker_label.Location = new System.Drawing.Point(342, 5);
            this.ticker_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ticker_label.Name = "ticker_label";
            this.ticker_label.Size = new System.Drawing.Size(35, 13);
            this.ticker_label.TabIndex = 3;
            this.ticker_label.Text = "label1";
            // 
            // dateTimePicker_startDate
            // 
            this.dateTimePicker_startDate.Location = new System.Drawing.Point(767, 238);
            this.dateTimePicker_startDate.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker_startDate.Name = "dateTimePicker_startDate";
            this.dateTimePicker_startDate.Size = new System.Drawing.Size(196, 20);
            this.dateTimePicker_startDate.TabIndex = 8;
            this.dateTimePicker_startDate.ValueChanged += new System.EventHandler(this.dateTimePicker_startDate_ValueChanged);
            // 
            // dateTimePicker_endDate
            // 
            this.dateTimePicker_endDate.Location = new System.Drawing.Point(767, 292);
            this.dateTimePicker_endDate.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker_endDate.Name = "dateTimePicker_endDate";
            this.dateTimePicker_endDate.Size = new System.Drawing.Size(199, 20);
            this.dateTimePicker_endDate.TabIndex = 9;
            this.dateTimePicker_endDate.ValueChanged += new System.EventHandler(this.dateTimePicker_endDate_ValueChanged);
            // 
            // label_startDate
            // 
            this.label_startDate.AutoSize = true;
            this.label_startDate.Location = new System.Drawing.Point(771, 222);
            this.label_startDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_startDate.Name = "label_startDate";
            this.label_startDate.Size = new System.Drawing.Size(55, 13);
            this.label_startDate.TabIndex = 10;
            this.label_startDate.Text = "Start Date";
            // 
            // label_endDate
            // 
            this.label_endDate.AutoSize = true;
            this.label_endDate.Location = new System.Drawing.Point(775, 273);
            this.label_endDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_endDate.Name = "label_endDate";
            this.label_endDate.Size = new System.Drawing.Size(52, 13);
            this.label_endDate.TabIndex = 11;
            this.label_endDate.Text = "End Date";
            // 
            // button_clear
            // 
            this.button_clear.Location = new System.Drawing.Point(891, 43);
            this.button_clear.Margin = new System.Windows.Forms.Padding(2);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(68, 40);
            this.button_clear.TabIndex = 13;
            this.button_clear.Text = "Clear Annotations";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // comboBox_patterns
            // 
            this.comboBox_patterns.FormattingEnabled = true;
            this.comboBox_patterns.Location = new System.Drawing.Point(764, 54);
            this.comboBox_patterns.Name = "comboBox_patterns";
            this.comboBox_patterns.Size = new System.Drawing.Size(121, 21);
            this.comboBox_patterns.TabIndex = 14;
            this.comboBox_patterns.SelectedIndexChanged += new System.EventHandler(this.comboBox_patterns_SelectedIndexChanged);
            // 
            // label_candlestickPattern
            // 
            this.label_candlestickPattern.AutoSize = true;
            this.label_candlestickPattern.Location = new System.Drawing.Point(768, 33);
            this.label_candlestickPattern.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_candlestickPattern.Name = "label_candlestickPattern";
            this.label_candlestickPattern.Size = new System.Drawing.Size(99, 13);
            this.label_candlestickPattern.TabIndex = 15;
            this.label_candlestickPattern.Text = "Candlestick Pattern";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 446);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Pattern Annotation Legend";
            // 
            // label_bearish
            // 
            this.label_bearish.AutoSize = true;
            this.label_bearish.Location = new System.Drawing.Point(25, 478);
            this.label_bearish.Name = "label_bearish";
            this.label_bearish.Size = new System.Drawing.Size(42, 13);
            this.label_bearish.TabIndex = 17;
            this.label_bearish.Text = "Bearish";
            // 
            // label_bullish
            // 
            this.label_bullish.AutoSize = true;
            this.label_bullish.Location = new System.Drawing.Point(25, 507);
            this.label_bullish.Name = "label_bullish";
            this.label_bullish.Size = new System.Drawing.Size(37, 13);
            this.label_bullish.TabIndex = 18;
            this.label_bullish.Text = "Bullish";
            // 
            // label_doji
            // 
            this.label_doji.AutoSize = true;
            this.label_doji.Location = new System.Drawing.Point(92, 478);
            this.label_doji.Name = "label_doji";
            this.label_doji.Size = new System.Drawing.Size(25, 13);
            this.label_doji.TabIndex = 19;
            this.label_doji.Text = "Doji";
            // 
            // label_dragonfly
            // 
            this.label_dragonfly.AutoSize = true;
            this.label_dragonfly.Location = new System.Drawing.Point(92, 507);
            this.label_dragonfly.Name = "label_dragonfly";
            this.label_dragonfly.Size = new System.Drawing.Size(52, 13);
            this.label_dragonfly.TabIndex = 20;
            this.label_dragonfly.Text = "Dragonfly";
            // 
            // label_gravestone
            // 
            this.label_gravestone.AutoSize = true;
            this.label_gravestone.Location = new System.Drawing.Point(154, 478);
            this.label_gravestone.Name = "label_gravestone";
            this.label_gravestone.Size = new System.Drawing.Size(62, 13);
            this.label_gravestone.TabIndex = 21;
            this.label_gravestone.Text = "Gravestone";
            // 
            // label_hammer
            // 
            this.label_hammer.AutoSize = true;
            this.label_hammer.Location = new System.Drawing.Point(235, 478);
            this.label_hammer.Name = "label_hammer";
            this.label_hammer.Size = new System.Drawing.Size(46, 13);
            this.label_hammer.TabIndex = 22;
            this.label_hammer.Text = "Hammer";
            // 
            // label_invertedHammer
            // 
            this.label_invertedHammer.AutoSize = true;
            this.label_invertedHammer.Location = new System.Drawing.Point(235, 507);
            this.label_invertedHammer.Name = "label_invertedHammer";
            this.label_invertedHammer.Size = new System.Drawing.Size(88, 13);
            this.label_invertedHammer.TabIndex = 23;
            this.label_invertedHammer.Text = "Inverted Hammer";
            // 
            // label_marubozu
            // 
            this.label_marubozu.AutoSize = true;
            this.label_marubozu.Location = new System.Drawing.Point(162, 507);
            this.label_marubozu.Name = "label_marubozu";
            this.label_marubozu.Size = new System.Drawing.Size(54, 13);
            this.label_marubozu.TabIndex = 24;
            this.label_marubozu.Text = "Marubozu";
            // 
            // label_neutral
            // 
            this.label_neutral.AutoSize = true;
            this.label_neutral.Location = new System.Drawing.Point(299, 478);
            this.label_neutral.Name = "label_neutral";
            this.label_neutral.Size = new System.Drawing.Size(41, 13);
            this.label_neutral.TabIndex = 25;
            this.label_neutral.Text = "Neutral";
            // 
            // label_info
            // 
            this.label_info.AutoSize = true;
            this.label_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_info.ForeColor = System.Drawing.Color.Red;
            this.label_info.Location = new System.Drawing.Point(764, 90);
            this.label_info.Name = "label_info";
            this.label_info.Size = new System.Drawing.Size(53, 16);
            this.label_info.TabIndex = 28;
            this.label_info.Text = "NOTE:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(764, 109);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(195, 76);
            this.textBox1.TabIndex = 29;
            this.textBox1.Text = "The Candlestick Pattern dropdown box only shows available patterns found from the" +
    " candlesticks in the CSV files. Different files may show different available can" +
    "dlestick patterns,";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 549);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label_info);
            this.Controls.Add(this.label_neutral);
            this.Controls.Add(this.label_marubozu);
            this.Controls.Add(this.label_invertedHammer);
            this.Controls.Add(this.label_hammer);
            this.Controls.Add(this.label_gravestone);
            this.Controls.Add(this.label_dragonfly);
            this.Controls.Add(this.label_doji);
            this.Controls.Add(this.label_bullish);
            this.Controls.Add(this.label_bearish);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_candlestickPattern);
            this.Controls.Add(this.comboBox_patterns);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.label_endDate);
            this.Controls.Add(this.label_startDate);
            this.Controls.Add(this.dateTimePicker_endDate);
            this.Controls.Add(this.dateTimePicker_startDate);
            this.Controls.Add(this.ticker_label);
            this.Controls.Add(this.chart_volume);
            this.Controls.Add(this.chart_price);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.chart_price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_volume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_price;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_volume;
        private System.Windows.Forms.Label ticker_label;
        private System.Windows.Forms.DateTimePicker dateTimePicker_startDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker_endDate;
        private System.Windows.Forms.Label label_startDate;
        private System.Windows.Forms.Label label_endDate;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.ComboBox comboBox_patterns;
        private System.Windows.Forms.Label label_candlestickPattern;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_bearish;
        private System.Windows.Forms.Label label_bullish;
        private System.Windows.Forms.Label label_doji;
        private System.Windows.Forms.Label label_dragonfly;
        private System.Windows.Forms.Label label_gravestone;
        private System.Windows.Forms.Label label_hammer;
        private System.Windows.Forms.Label label_invertedHammer;
        private System.Windows.Forms.Label label_marubozu;
        private System.Windows.Forms.Label label_neutral;
        private System.Windows.Forms.Label label_info;
        private System.Windows.Forms.TextBox textBox1;
    }
}