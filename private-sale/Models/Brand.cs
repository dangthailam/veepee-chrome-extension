using System;
using System.Collections.Generic;

namespace PrivateSale.Models
{
    public class Brand
    {
        public Guid Id { get; } = Guid.NewGuid();
        public string Name { get; }
        public string LogoUrl { get; }
        public HashSet<Sale> Sales { get; } = new HashSet<Sale>();

        private Brand()
        {

        }

        private Brand(string name, string logoUrl)
        {
            Name = name;
            LogoUrl = logoUrl;
        }

        public static Brand NewBrand(string name, string logoUrl)
        {
            return new Brand(name, logoUrl);
        }

        public bool AddSale(Sale sale)
        {
            return Sales.Add(sale);
        }
    }
}