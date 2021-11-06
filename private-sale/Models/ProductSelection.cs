using System;

namespace PrivateSale.Models {
    public class ProductSelection {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public bool OnStock { get; set; }
    }
}