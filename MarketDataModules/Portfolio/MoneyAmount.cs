using MarketDataModules.Candles;

namespace MarketDataModules.Portfolio
{
    public record struct MoneyAmount
    {
        public Currency Currency { get; }
        public decimal Value { get; }

        /// <summary>
        /// Стоимость в валюте
        /// </summary>
        /// <param name="currency"></param> Валюта
        /// <param name="value"></param> Стоимость
        public MoneyAmount(Currency currency, decimal value)
        {
            Currency = currency;
            Value = value;
        }

    }
}
