using System;
using System.Collections.Generic;

namespace MarketDataModules.Orderbooks
{
    public record Orderbook// : IOrderbook
    {
        public string Id { get; set; }
        public int Depth { get; }
        public List<Order> Bids { get; }
        public List<Order> Asks { get; }
        public decimal LastPrice { get; }
        public decimal ClosePrice { get; }
        public decimal LimitUp { get; }
        public decimal LimitDown { get; }
        public DateTime LastPriceTime { get; }
        public DateTime ClosePriceTime { get; }
        public DateTime? OrderbookTime { get; }

        public Orderbook(
            string id,
            int depth,
            List<Order> bids,
            List<Order> asks,
            decimal lastPrice,
            decimal closePrice,
            decimal limitUp,
            decimal limitDown,
            DateTime lastPriceTime,
            DateTime closePriceTime,
            DateTime? orderbookTime)
        {
            Id = id;
            Depth = depth;
            Bids = bids;
            Asks = asks;
            LastPrice = lastPrice;
            ClosePrice = closePrice;
            LimitUp = limitUp;
            LimitDown = limitDown;
            LastPriceTime = lastPriceTime;
            ClosePriceTime = closePriceTime;
            OrderbookTime = orderbookTime;
        }
    }
}
