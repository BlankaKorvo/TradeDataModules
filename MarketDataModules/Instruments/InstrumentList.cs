using System.Collections.Generic;

namespace MarketDataModules.Instruments
{
    public record InstrumentList
    {
        public int Count { get; set; }
        public List<Instrument> Instruments { get; set; }


    }
}