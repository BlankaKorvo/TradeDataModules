using MarketDataModules.Candles;

namespace MarketDataModules.Instruments
{
    public record Instrument
    {
        public string Figi { get; set; }
        public string Ticker { get; set; }
        public string Isin { get; set; }
        public string TinkoffUid { get; set; }
        public string ClassCode { get; set; }
        //public decimal? MinPriceIncrement { get; set; }
        public int Lot { get; set; }
        public Currency Currency { get; set; }
        public string Name { get; set; }
        public InstrumentType Type { get; set; }
        public bool ShortEnabledFlag { get; set; }
        public string Exchange {  get; set; }
        public string RealExchange { get; set; }
    }
}
