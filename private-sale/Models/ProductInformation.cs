using System;

namespace PrivateSale.Models
{
    public class ProductInformation
    {
        public Guid Id { get; }
        public string Name { get; }
        public Brand Brand { get; }

        private ProductInformation()
        {

        }
    }
}