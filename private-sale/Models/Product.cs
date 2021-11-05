using System.Collections.Generic;

namespace PrivateSale.Models {
    public class Product {
        public int Id { get; }
        public string Name { get; }
        public decimal OriginalPrice { get; }
        public decimal FinalPrice { get; }
        public decimal Discount { get; }
        public int Quantity { get; }
        public bool IsAvailable { get; }
        public IList<string> ImageUrls { get; }

        public Product()
        {
            
        }
    }
}