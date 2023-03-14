namespace MarketDataModules.Orderbooks
{ 
    public record Order
    {
        public decimal Price { get; }
        public int Quantity { get; }

        public Order(decimal price,int quantity)
        {
            Price = price;
            Quantity = quantity;

        }
    }
}