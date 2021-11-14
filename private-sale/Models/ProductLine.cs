using System;
using System.Collections.Generic;

namespace PrivateSale.Models
{
    public class ProductLine : Entity
    {
        public ProductInformation ProductInformation { get; }
        public decimal OriginalPrice { get; }
        public decimal FinalPrice { get; }
        public decimal Discount { get; }
        public IList<ProductSelection> Selections { get; }
        public IList<string> ImageUrls { get; }


    }
}