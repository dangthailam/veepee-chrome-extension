using System;
using System.Collections.Generic;

namespace PrivateSale.Models
{
    public class Sale : Entity
    {
        public SalePeriod SalePeriod { get; set; }
        public Brand Brand { get; }
        public IList<ProductLine> ProductLines { get; }

        private Sale()
        {

        }

        private Sale(Brand brand)
        {
            Brand = brand;
        }

        public static Sale NewSale(DateTime startAt, DateTime endAt, Brand brand)
        {
            Sale sale = new Sale(brand);
            brand.AddSale(sale);
            SalePeriod.NewSalePeriod(startAt, endAt, sale);
            return sale;
        }
    }
}