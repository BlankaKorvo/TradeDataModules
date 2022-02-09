using System.Collections.Generic;

namespace MarketDataModules.Candles
{
    public record struct CandlesList : ICandlesList
    {
        public string Figi { get; }
        public CandleInterval Interval { get; }
        public List<CandleStructure> Candles { get; }

        public CandlesList(string figi, CandleInterval interval, List<CandleStructure> candles)
        {
            Figi = figi;
            Interval = interval;
            Candles = candles;
        }
    }
}