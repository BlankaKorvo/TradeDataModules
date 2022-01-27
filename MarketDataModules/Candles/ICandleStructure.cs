using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketDataModules.Candles
{
    public interface ICandleStructure
    { 
        public decimal Open { get; }
        public decimal Close { get; }
        public decimal High { get; }
        public decimal Low { get; }
        public decimal Volume { get; }
    }
}
