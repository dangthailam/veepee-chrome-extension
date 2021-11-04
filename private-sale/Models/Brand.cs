namespace PrivateSale.Models {
    public class Brand {
        public int Id { get; }
        public string Name { get; }
        public string LogoUrl { get; }
        public IList<Product> Products { get; }

        public Brand()
        {
            
        }
    }
}