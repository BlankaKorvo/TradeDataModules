using System;

namespace MarketDataModules.Candles
{
    public record CandleStructure
    {
        public decimal Open { get; }
        public decimal Close { get; }
        public decimal High { get; }
        public decimal Low { get; }
        public long Volume { get; }
        public DateTime Time { get; }
        public bool IsComplete { get; } 

        public CandleStructure(
            decimal open,
            decimal close,
            decimal high,
            decimal low,
            long volume,
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
    public record CandleStructureNotSave
    {
        public decimal Open { get; set; }
        public decimal Close { get; set; }
        public decimal High { get; set; }
        public decimal Low { get; set; }
        public long Volume { get; set; }
        public DateTime Time { get; set; }
        public bool IsComplete { get; set; }

    }
}
