using System.Collections.Generic;

namespace MarketDataModules.Instruments
{
    public record InstrumentList : IInstrumentList
    {
        public int Total { get; }
        public List<Instrument> Instruments { get; }

        public InstrumentList(int total, List<Instrument> instruments)
        {
            Total = total;
            Instruments = instruments;
        }
    }
}