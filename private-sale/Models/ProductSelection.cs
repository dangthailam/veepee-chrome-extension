using System;

namespace PrivateSale.Models
{
    public class ProductSelection : Entity
    {
        public string Name { get; private set; }
        public int Quantity { get; private set; }
        public string StockStatus { get; private set; }

        private ProductSelection() { }

        public ProductSelection(string name, int quantity, string stockStatus)
        {
            Name = name;
            Quantity = quantity;
            StockStatus = stockStatus;
        }
    }
}