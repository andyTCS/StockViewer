using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project2_stockDisplay
{
    // Recognize all patterns in the data set
    public class recognizePatterns
    {
        // Pass in the list of smart candlesticks and a recognizer and the selected pattern. Adds the index of candlestick if it matches pattern x
        public List<int> findPatterns(List<smartCandlestick> data, recognizer recognize, string pattern) 
        {
            List<int> result = new List<int>();
            for (int i = 0; i < data.Count; i++) 
            {
                if (recognize.getRecognizerType(recognize.recognizePattern(data[i])) == pattern && recognize.getRecognizerType(recognize.recognizePattern(data[i])) != "") 
                {
                    if (recognize.recognizePattern(data[i]))
                    {
                        result.Add(i);
                    }
                }
            }
            return result;
        }
    }
}
