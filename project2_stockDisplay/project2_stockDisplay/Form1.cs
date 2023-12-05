using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project2_stockDisplay
{
    public partial class Form1 : Form
    {
        // Creates form 1
        public Form1()
        {
            InitializeComponent();
        }
        private List<smartCandlestick> allData;
        private Form2 form2;
        //Load data from selected file
        private void loadCSVData(string filepath) 
        {
            try
            {
                //List of candlesticks
                var candlestickData = new List<smartCandlestick>();
                using (var reader = new StreamReader(filepath))
                {
                    // Skip first line containing csv titles
                    reader.ReadLine();
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(',');

                        string dateString = string.Empty;
                        string monthDay = string.Empty;
                        string year = string.Empty;
                        monthDay = values[2];
                        year = values[3];
                        dateString = monthDay + "," + year;
                        dateString = dateString.Replace("\"", "");
                        DateTime dateTime;

                        //Date format may be MM DD, YYYY
                        if (DateTime.TryParseExact(dateString, "MMM dd, yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dateTime))
                        {
                            Console.WriteLine(dateTime);
                        }
                        //Date format may be MM D, YYYY
                        else if (DateTime.TryParseExact(dateString, "MMM d, yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dateTime))
                        {
                            Console.WriteLine(dateTime);
                        }
                        else
                        {
                            string errorMsg = "The date " + dateString + " does not match the format MM DD YYYY/MM D YYYY";
                            MessageBox.Show(errorMsg, "Date error");
                        }
                        var data = new smartCandlestick
                        {
                            Ticker = values[0],
                            Period = values[1],
                            Date = dateTime,
                            Open = double.Parse(values[4]),
                            High = double.Parse(values[5]),
                            Low = double.Parse(values[6]),
                            Close = double.Parse(values[7]),
                            Volume = int.Parse(values[8])
                        };
                        candlestickData.Add(data);
                        //Chart labeling here?
                    }
                    //Open other form and Populate charts here
                    allData = candlestickData;
                    form2 = new Form2(allData); 
                    form2.Show();
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Error loading data" + ex.Message, "Error");
            }
        }

        //Enable user to multiselect CSV files
        private void button_loadCSV_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV Files| *.csv|Day|*Day.csv|Week|*Week.csv|Month|*Month.csv";
            openFileDialog.Multiselect = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK) 
            {
                foreach (string filename in openFileDialog.FileNames)
                {
                    loadCSVData(filename);
                }
                
            }
        }

        //Filter start date
        public void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            // Check if allData is null or empty (no CSV file loaded)
            if (allData == null || allData.Count == 0)
            {
                MessageBox.Show("Please select a CSV file first.", "CSV File Not Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Exit the event handler
            }

            DateTime startDate = dateTimePicker_startDate.Value.Date;
            DateTime endDate = dateTimePicker_endDate.Value.Date;
            var filteredData = allData.Where(data => data.Date >= startDate && data.Date <= endDate).ToList();

            //Populate chart here and update to filtered candlesticks
            form2.populateChartDaily(filteredData);
            form2.populateChartVolume(filteredData);
            form2.populateComboBoxPatterns(filteredData);
        }

        //Filter end date
        public void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            // Check if allData is null or empty (no CSV file loaded)
            if (allData == null || allData.Count == 0)
            {
                MessageBox.Show("Please select a CSV file first.", "CSV File Not Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Exit the event handler
            }

            DateTime startDate = dateTimePicker_startDate.Value.Date;
            DateTime endDate = dateTimePicker_endDate.Value.Date;

            // Filter data based on the selected date range
            var filteredData = allData.Where(data => data.Date >= startDate && data.Date <= endDate).ToList();

            //Populate chart here and update to filtered candlesticks
            form2.populateChartDaily(filteredData);
            form2.populateChartVolume(filteredData);
            form2.populateComboBoxPatterns(filteredData);
        }
    }
}
