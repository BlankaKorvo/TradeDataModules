using MarketDataModules.Instruments;
using System.Collections.Generic;

namespace MarketDataModules.Portfolio
{
    public interface IPortfolio
    {
        public List<Portfolio.Position> Positions { get; }
        public interface IPosition
        {
            public string Name { get; }
            public string Figi { get; }
            public string Ticker { get; }
            public InstrumentType InstrumentType { get; }
            public decimal Balance { get; }
            public MoneyAmount ExpectedYield { get; }
            public int Lots { get; }
        }
    }


    
}
