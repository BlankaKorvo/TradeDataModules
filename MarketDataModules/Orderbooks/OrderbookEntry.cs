namespace MarketDataModules.Orderbooks
{ 
    public record OrderbookEntry
    {
        public int Quantity { get; }
        public decimal Price { get; }

        public OrderbookEntry(int quantity, decimal price)
        {
            Quantity = quantity;
            Price = price;
        }
    }
}