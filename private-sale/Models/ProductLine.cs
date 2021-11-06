using System;
using System.Collections.Generic;

namespace PrivateSale.Models
{
    public class ProductLine
    {
        public Guid Id { get; set; }
        public ProductInformation ProductInformation { get; set; }
        public decimal OriginalPrice { get; }
        public decimal FinalPrice { get; }
        public decimal Discount { get; }
        public IList<ProductSelection> Selections { get; set; }
        public IList<string> ImageUrls { get; }
    }
}