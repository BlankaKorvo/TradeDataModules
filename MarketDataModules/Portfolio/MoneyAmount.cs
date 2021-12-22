using MarketDataModules.Candles;

namespace MarketDataModules.Portfolio
{
    public class MoneyAmount
    {
        public Currency Currency { get; }
        public decimal Value { get; }

        public MoneyAmount(Currency currency, decimal value)
        {
            Currency = currency;
            Value = value;
        }

    }
}
