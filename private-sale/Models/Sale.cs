using System;
using System.Collections.Generic;
using System.Linq;

namespace PrivateSale.Models
{
    public class Sale : Entity
    {
        public SalePeriod SalePeriod { get; set; }
        public Brand Brand { get; }
        public IList<ProductLine> ProductLines { get; } = new List<ProductLine>();

        private Sale()
        {
            
        }

        private Sale(Brand brand, IList<ProductLine> productLines)
        {
            Brand = brand;
            ProductLines = productLines;
        }

        public static Sale NewSale(DateTime startAt, DateTime endAt, Brand brand, IList<ProductLine> productLines)
        {
            Sale sale = new Sale(brand, productLines);
            brand.AddSale(sale);
            SalePeriod.NewSalePeriod(startAt, endAt, sale);
            return sale;
        }
    }
}