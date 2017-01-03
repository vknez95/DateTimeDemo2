using System;

namespace DateTimeDemo2
{
    class StockPrice
    {
        public decimal Price { get; private set; }
        public DateTime ValidFrom { get; private set; }

        public StockPrice(decimal price)
        {
            this.Price = price;
            this.ValidFrom = DateTime.UtcNow;
        }
    }
}