using System;
using System.Collections.Generic;

namespace PrivateSale.ViewModels {
    public class ProductLineViewModel {
        public string Name { get; set; }
        public IList<string> ImageUrls { get; set; }
        public string BrandName { get; set; }
        public string BrandLogoUrl { get; set; }
        public decimal OriginalPrice { get; set; }
        public decimal FinalPrice { get; set; }
        public decimal SalePercentage { get; set; }
        public DateTime StartAt { get; set; }
        public DateTime EndAt { get; set; }
        public IList<ProductSelectionViewModel> Selections { get; set; }
    }
}