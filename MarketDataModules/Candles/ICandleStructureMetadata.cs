using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketDataModules.Candles
{
    internal interface ICandleStructureMetadata
    {
        public DateTime Time { get; }
        public CandleInterval Interval { get; }
        public string Figi { get; }
    }
}
