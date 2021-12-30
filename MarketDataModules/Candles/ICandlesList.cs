using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketDataModules.Candles
{
    public interface ICandlesList
    {
        public string Figi { get; }
        public CandleInterval Interval { get; }
        public List<CandleStructure> Candles { get; }
    }
}
