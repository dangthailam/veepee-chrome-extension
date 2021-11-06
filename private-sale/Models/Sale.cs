using System;
using System.Collections.Generic;

namespace PrivateSale.Models
{
    public class Sale
    {
        public Guid Id { get; set; }
        public DateTime StartAt { get; set; }
        public DateTime EndAt { get; set; }
        public Brand Brand { get; set; }
        public IList<ProductLine> ProductLines { get; set; }
    }
}