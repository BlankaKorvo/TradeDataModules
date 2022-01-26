using System.Collections.Generic;

namespace MarketDataModules.Candles
{
    public interface ICandlesList
    {
        public string Figi { get; }
        public CandleInterval Interval { get; }
        public List<CandleStructure> Candles { get; }
    }
}
