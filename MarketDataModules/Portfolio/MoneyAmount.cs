using MarketDataModules.Candles;

namespace MarketDataModules.Portfolio
{
    public record MoneyAmount
    {
        public Currency Currency { get; }
        public decimal Value { get; set; }

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
