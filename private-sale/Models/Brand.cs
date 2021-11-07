using System;
using System.Collections.Generic;

namespace PrivateSale.Models
{
    public class Brand
    {
        public Guid Id { get; }
        public string Name { get; }
        public string LogoUrl { get; }
        public IList<Sale> Sales { get; }

        public Brand()
        {

        }
    }
}