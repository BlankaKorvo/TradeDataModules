namespace MarketDataModules.Trading
{
    public enum TradingOperationType
    {
        Buy,
        Sell
    }
    public enum TradeTarget
    {
        notTrading,
        trading,
        toLong,
        fromLong,
        toShort,
        fromShort
    }
}