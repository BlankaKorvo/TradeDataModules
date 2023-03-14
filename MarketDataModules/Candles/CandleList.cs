using System.Collections.Generic;

namespace MarketDataModules.Candles
{
    public record CandleList
    {
        public string Figi { get; }
        public CandleInterval Interval { get; }
        public List<CandleStructure> Candles { get; }

        public CandleList(string figi, CandleInterval interval, List<CandleStructure> candles)
        {
            Figi = figi;
            Interval = interval;
            Candles = candles;
        }
    }
}