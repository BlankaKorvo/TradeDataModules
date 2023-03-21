using MarketDataModules.Candles;

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
        stand,
        toLong,
        fromLong,
        toShort,
        fromShort
    }
    public enum OperationState
    {
        Long,
        Short,
        NoState
    }
} 