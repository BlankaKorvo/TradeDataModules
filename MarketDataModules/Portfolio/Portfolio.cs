using MarketDataModules.Instruments;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Xml.Linq;
using System.Xml;

namespace MarketDataModules.Portfolio
{
    public record Portfolio
    {
        /// <summary>
        /// Gets or Sets TotalAmountShares
        /// </summary>
        public MoneyAmount TotalAmountShares { get; set; }

        /// <summary>
        /// Gets or Sets TotalAmountBonds
        /// </summary>
        public MoneyAmount TotalAmountBonds { get; set; }

        /// <summary>
        /// Gets or Sets TotalAmountEtf
        /// </summary>
        public MoneyAmount TotalAmountEtf { get; set; }

        /// <summary>
        /// Gets or Sets TotalAmountCurrencies
        /// </summary>
        public MoneyAmount TotalAmountCurrencies { get; set; }

        /// <summary>
        /// Gets or Sets TotalAmountFutures
        /// </summary>
        public MoneyAmount TotalAmountFutures { get; set; }

        /// <summary>
        /// Gets or Sets ExpectedYield
        /// </summary>
        public decimal ExpectedYield { get; set; }

        /// <summary>
        /// Gets or Sets Positions
        /// </summary>
        public List<PortfolioPositionList> Positions { get; set; }

        /// <summary>
        /// Gets or Sets AccountId
        /// </summary>
        public string AccountId { get; set; }

        /// <summary>
        /// Gets or Sets TotalAmountOptions
        /// </summary>
        public MoneyAmount TotalAmountOptions { get; set; }

        /// <summary>
        /// Gets or Sets TotalAmountSp
        /// </summary>
        public MoneyAmount TotalAmountSp { get; set; }

        /// <summary>
        /// Gets or Sets TotalAmountPortfolio
        /// </summary>
        public MoneyAmount TotalAmountPortfolio { get; set; }

        /// <summary>
        /// Gets or Sets VirtualPositions
        /// </summary>
        public List<PortfolioPositionList> VirtualPositions { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V1PortfolioResponse {\n");
            sb.Append("  TotalAmountShares: ").Append(TotalAmountShares).Append("\n");
            sb.Append("  TotalAmountBonds: ").Append(TotalAmountBonds).Append("\n");
            sb.Append("  TotalAmountEtf: ").Append(TotalAmountEtf).Append("\n");
            sb.Append("  TotalAmountCurrencies: ").Append(TotalAmountCurrencies).Append("\n");
            sb.Append("  TotalAmountFutures: ").Append(TotalAmountFutures).Append("\n");
            sb.Append("  ExpectedYield: ").Append(ExpectedYield).Append("\n");
            sb.Append("  Positions: ").Append(Positions).Append("\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  TotalAmountOptions: ").Append(TotalAmountOptions).Append("\n");
            sb.Append("  TotalAmountSp: ").Append(TotalAmountSp).Append("\n");
            sb.Append("  TotalAmountPortfolio: ").Append(TotalAmountPortfolio).Append("\n");
            sb.Append("  VirtualPositions: ").Append(VirtualPositions).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
