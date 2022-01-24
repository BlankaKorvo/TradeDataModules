using MarketDataModules.Candles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketDataModules.Instruments
{
    public interface IInstrumentList
    {
        public List<Instrument> Instruments { get; }
    }

    public interface IInstrument
    {
        public string Figi { get; }
        public string Ticker { get; }
        /// <summary>
        /// Шаг цены
        /// </summary>
        public decimal MinPriceIncrement { get; }
        public int Lot { get; }
        public Currency Currency { get; }
        public string Name { get; }
    }


}
