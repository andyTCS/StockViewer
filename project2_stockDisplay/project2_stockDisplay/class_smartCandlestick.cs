using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace project2_stockDisplay
{
    // Derived smart candlestick class that inherits properties from the base candlestick class
    public class smartCandlestick : candlestick
    {
        public double Range { get; set; }
        public double BodyRange { get; set; }
        public double TopPrice { get; set; }
        public double BottomPrice { get; set; }
        public double TopTail { get; set; }
        public double BottomTail { get; set; } 
    }
}
