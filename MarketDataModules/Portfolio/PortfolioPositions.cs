using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml;

namespace MarketDataModules.Portfolio
{
    public class PortfolioPositions
    {
        /// <summary>
        /// Gets or Sets Figi
        /// </summary>
        public string Figi { get; set; }

        /// <summary>
        /// Gets or Sets InstrumentType
        /// </summary>
        public string InstrumentType { get; set; }

        /// <summary>
        /// Gets or Sets Quantity
        /// </summary>
        public decimal Quantity { get; set; }

        /// <summary>
        /// Gets or Sets AveragePositionPrice
        /// </summary>
        public MoneyAmount AveragePositionPrice { get; set; }

        /// <summary>
        /// Gets or Sets ExpectedYield
        /// </summary>
        public decimal ExpectedYield { get; set; }

        /// <summary>
        /// Gets or Sets CurrentNkd
        /// </summary>
        public MoneyAmount CurrentNkd { get; set; }

        /// <summary>
        /// Gets or Sets AveragePositionPricePt
        /// </summary>
        public decimal AveragePositionPricePt { get; set; }

        /// <summary>
        /// Gets or Sets CurrentPrice
        /// </summary>
        public MoneyAmount CurrentPrice { get; set; }

        /// <summary>
        /// Gets or Sets AveragePositionPriceFifo
        /// </summary>
        public MoneyAmount AveragePositionPriceFifo { get; set; }

        /// <summary>
        /// Gets or Sets QuantityLots
        /// </summary>
        public decimal QuantityLots { get; set; }

        /// <summary>
        /// Gets or Sets Blocked
        /// </summary>
        public bool? Blocked { get; set; }

        /// <summary>
        /// Gets or Sets BlockedLots
        /// </summary>
        public decimal BlockedLots { get; set; }

        /// <summary>
        /// Gets or Sets PositionUid
        /// </summary>
        public string PositionUid { get; set; }

        /// <summary>
        /// Gets or Sets InstrumentUid
        /// </summary>
        public string InstrumentUid { get; set; }

        /// <summary>
        /// Gets or Sets VarMargin
        /// </summary>
        public MoneyAmount VarMargin { get; set; }

        /// <summary>
        /// Gets or Sets ExpectedYieldFifo
        /// </summary>
        public decimal ExpectedYieldFifo { get; set; }
    }
}
