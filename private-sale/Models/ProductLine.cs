using System;
using System.Collections.Generic;

namespace PrivateSale.Models
{
    public class ProductLine : Entity
    {
        public string Name { get; }
        public decimal OriginalPrice { get; }
        public decimal FinalPrice { get; }
        public decimal Discount { get; }
        public IList<ProductSelection> Selections { get; }
        public IList<string> ImageUrls { get; }

        private ProductLine() { }

        private ProductLine(string productName, decimal originalPrice, decimal finalPrice,
            decimal discount, IList<ProductSelection> selections, IList<string> imageUrls)
        {
            Name = productName;
            OriginalPrice = originalPrice;
            FinalPrice = finalPrice;
            Discount = discount;
            Selections = selections;
            ImageUrls = imageUrls;
        }

        public static ProductLine NewProductLine(
            string productName, decimal originalPrice, decimal finalPrice,
            decimal discount, IList<ProductSelection> selections, IList<string> imageUrls)
        {
            return new ProductLine(productName, originalPrice, finalPrice, discount, selections, imageUrls);
        }
    }
}