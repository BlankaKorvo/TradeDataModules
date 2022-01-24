
namespace MarketDataModules.Trading
{
    public class TransactionModel : TransactionModelBase
    {
        public int Quantity { get; set; } //кол-во акций
    }

    public class TransactionModelBase
    {
        public string Figi { get; set; }
        public decimal Price { get; set; }
        public TradingOperationType TradeOperation { get; set; }
    }

}

