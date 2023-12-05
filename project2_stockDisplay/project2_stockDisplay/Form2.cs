using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace project2_stockDisplay
{
    public partial class Form2 : Form
    {
        private List<smartCandlestick> data;
        private List<smartCandlestick> allData;

        // Creates the form2
        public Form2(List<smartCandlestick> smartCandlestickPass)
        {
            InitializeComponent();
            setLegend();
            allData = smartCandlestickPass;
            data = allData;
            populateChartDaily(data);
            populateChartVolume(data);
            populateComboBoxPatterns(data);
            if (dateTimePicker_startDate != null)
            {
                dateTimePicker_startDate.Value = new DateTime(2021, 1, 1);
            }
        }

        // Populate the daily price chart
        public void populateChartDaily(List<smartCandlestick> data)
        {
            chart_price.Series["Daily OHLC"].Points.Clear();

            // Using data binding
            chart_price.DataSource = data;
            chart_price.Series["Daily OHLC"].XValueMember = "Date";
            chart_price.Series["Daily OHLC"].YValueMembers = "High,Low,Open,Close";
            chart_price.DataBind();

            int index = 0;

            foreach (DataPoint point in chart_price.Series["Daily OHLC"].Points)
            {
                // Check we haven't reached the end of the data
                if (index < data.Count)
                {
                    smartCandlestick item = data[index];
                    string chartLabel = item.Ticker;
                    updateChartLabel(chartLabel);

                    // Set the color of the candlestick based on the price change. Updated to use new abstract and concrete classes
                    bullishRecognizer bullish = new bullishRecognizer();
                    bearishRecognizer bearish = new bearishRecognizer();
                    if (bullish.recognizePattern(item))
                    {
                        point.Color = Color.Green;
                    }
                    else if (bearish.recognizePattern(item))
                    {
                        point.Color = Color.Red;
                    }
                    else
                    {
                        point.Color = Color.Gray;
                    }
                    index++; 
                }
            }
            chart_price.ChartAreas[0].AxisY.Title = "Price";
        }

        // Populate the volume chart
        public void populateChartVolume(List<smartCandlestick> data)
        {
            // Bind data
            chart_volume.DataSource = data;
            chart_volume.Series["Volume"].XValueMember = "Date";
            chart_volume.Series["Volume"].YValueMembers = "Volume";
            chart_volume.DataBind();

            int index = 0; // Initialize index

            foreach (DataPoint point in chart_volume.Series["Volume"].Points)
            {
                if (index < data.Count)
                {
                    smartCandlestick item = data[index];

                    // Set the color of the candlestick based on the bearish or bullish
                    bullishRecognizer bullish = new bullishRecognizer();
                    bearishRecognizer bearish = new bearishRecognizer();
                    if (bullish.recognizePattern(item))
                    {
                        point.Color = Color.Green;
                    }
                    else if (bearish.recognizePattern(item))
                    {
                        point.Color = Color.Red;
                    }
                    else
                    {
                        point.Color = Color.Gray;
                    }

                    index++;
                }
            }

            chart_volume.ChartAreas[0].AxisY.Title = "Volume";
        }

        // Create a label for the charts
        private void updateChartLabel(string ticker) 
        {
            ticker_label.Text = ticker;
        }

        // Populate combobox drop-down with candlestick patterns found in the csv file
        public void populateComboBoxPatterns(List<smartCandlestick> data) 
        {
            comboBox_patterns.Items.Clear();
            HashSet<string> uniquePatterns = new HashSet<string>();
            List<recognizer> recognizers = new List<recognizer>
            {
                new bullishRecognizer(),
                new bearishRecognizer(),
                new dojiRecognizer(),
                new dragonflyRecognizer(),
                new gravestoneRecognizer(),
                new hammerRecognizer(),
                new invertedHammerRecognizer(),
                new marubozuRecognizer(),
                new neutralRecognizer(),
            };

            // Add patterns to a container of patterns
            foreach (var item in data) 
            {
                foreach (var recognizer in recognizers) 
                {
                    // Find if smartCandlestick patches pattern
                    // If they match, add the type of pattern to a container
                    bool match = recognizer.recognizePattern(item);
                    string comboboxItem = recognizer.getRecognizerType(match);
                    uniquePatterns.Add(comboboxItem);
                }
            }

            // Add container of patterns to combobox but do not include duplicates or empty strings
            foreach (var item in uniquePatterns) 
            {
                if (!string.IsNullOrEmpty(item)) 
                {
                    comboBox_patterns.Items.Add(item);
                }
            }
        }

        // Finds patterns of the candlesticks and creates annotations for them
        private void comboBox_patterns_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_patterns.SelectedItem != null) 
            {
                string selectedPattern = comboBox_patterns.SelectedItem.ToString();
                // chart_price.Annotations.Clear();
                List<recognizer> recognizers = new List<recognizer>
                {
                    new bullishRecognizer(),
                    new bearishRecognizer(),
                    new dojiRecognizer(),
                    new dragonflyRecognizer(),
                    new gravestoneRecognizer(),
                    new hammerRecognizer(),
                    new invertedHammerRecognizer(),
                    new marubozuRecognizer(),
                    new neutralRecognizer(),
                };

                recognizePatterns patternRecognizer = new recognizePatterns();
                List<List<int>> validPatterns = new List<List<int>>();
                foreach (var recognizer in recognizers)
                {
                    validPatterns.Add(patternRecognizer.findPatterns(data, recognizer, selectedPattern));
                }
                for (int i = 0; i < validPatterns.Count; i++)
                {
                    var indices = validPatterns[i];
                    var recognizer = recognizers[i];
                    makeAnnotation(data, indices, recognizer, selectedPattern, recognizer.patternColor);
                }
            }
        }

        // Start date for the date filter
        private void dateTimePicker_endDate_ValueChanged(object sender, EventArgs e)
        {
            // Check if allData is null or empty (no CSV file loaded)
            if (allData == null || allData.Count == 0)
            {
                MessageBox.Show("Please select a CSV file first.", "CSV File Not Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime startDate = dateTimePicker_startDate.Value.Date;
            DateTime endDate = dateTimePicker_endDate.Value.Date;
            var filteredData = allData.Where(data => data.Date >= startDate && data.Date <= endDate).ToList();

            //Populate chart here and update to filtered candlesticks
            populateChartDaily(filteredData);
            populateChartVolume(filteredData);
            populateComboBoxPatterns(filteredData);
        }

        // End date for the date filter
        private void dateTimePicker_startDate_ValueChanged(object sender, EventArgs e)
        {
            // Check if allData is null or empty (no CSV file loaded)
            if (allData == null || allData.Count == 0)
            {
                MessageBox.Show("Please select a CSV file first.", "CSV File Not Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime startDate = dateTimePicker_startDate.Value.Date;
            DateTime endDate = dateTimePicker_endDate.Value.Date;

            // Filter data based on the selected date range
            var filteredData = allData.Where(data => data.Date >= startDate && data.Date <= endDate).ToList();

            //Populate chart here and update to filtered candlesticks
            populateChartDaily(filteredData);
            populateChartVolume(filteredData);
            populateComboBoxPatterns(filteredData);
        }

        // Create the annotations for patterns inside the chart
        private void makeAnnotation(List<smartCandlestick> candlestickList, List<int> indices, recognizer recognizer, string pattern, Color color)
        {
            foreach (var index in indices)
            {
                var item = candlestickList[index];
                foreach (DataPoint dataPoint in chart_price.Series["Daily OHLC"].Points)
                {
                    DateTime xValueDate = DateTime.FromOADate(dataPoint.XValue);
                    string formattedXValue = xValueDate.ToShortDateString();
                    if (item.Date.ToShortDateString() == formattedXValue && recognizer.recognizePattern(item))
                    {
                        ArrowAnnotation arrowAnnotation = new ArrowAnnotation
                        {
                            Width = 2,
                            Height = -1,
                            LineWidth = 2,
                            AnchorDataPoint = dataPoint,
                            AnchorOffsetY = 0,
                            Alignment = ContentAlignment.TopCenter,
                            Font = new Font("Arial", 10),
                            LineColor = color
                        };
                        chart_price.Annotations.Add(arrowAnnotation);
                    }
                }
            }
        }

        // Clears all current annotations
        private void button_clear_Click(object sender, EventArgs e)
        {
            chart_price.Annotations.Clear();
            chart_volume.Annotations.Clear();
        }

        private void setLegend() 
        {
            label_bearish.ForeColor = Color.Red;
            label_bullish.ForeColor = Color.Green;
            label_doji.ForeColor = Color.Blue;
            label_dragonfly.ForeColor = Color.Indigo;
            label_gravestone.ForeColor = Color.Gray;
            label_hammer.ForeColor = Color.Khaki;
            label_invertedHammer.ForeColor = Color.Maroon;
            label_marubozu.ForeColor = Color.Magenta;
            label_neutral.ForeColor = Color.Black;
        }
    }
}

