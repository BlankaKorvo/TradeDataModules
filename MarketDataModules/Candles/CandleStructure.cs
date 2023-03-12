using System;

namespace MarketDataModules.Candles
{
    public record CandleStructure
    {
        public decimal Open { get; }
        public decimal Close { get; }
        public decimal High { get; }
        public decimal Low { get; }
        public decimal Volume { get; }
        public DateTime Time { get; }
        public bool IsComplete { get; } 

        public CandleStructure(
            decimal open,
            decimal close,
            decimal high,
            decimal low,
            decimal volume,
            DateTime time,
            bool isComplete)
        {
            Open = open;
            Close = close;
            High = high;
            Low = low;
            Volume = volume;
            Time = time;
            IsComplete = isComplete;
        }
    }
}
