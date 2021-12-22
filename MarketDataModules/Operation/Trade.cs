using System;
using System.Text.Json.Serialization;

namespace MarketDataModules.Operation
{
    public class Trade
    {
        public string TradeId { get; }
        public DateTime Date { get; }
        public decimal Price { get; }
        public int Quantity { get; }

        [JsonConstructor]
        public Trade(string tradeId, DateTime date, decimal price, int quantity)
        {
            TradeId = tradeId;
            Date = date;
            Price = price;
            Quantity = quantity;
        }
    }
}