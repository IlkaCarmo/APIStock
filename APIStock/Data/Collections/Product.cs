namespace APIStock.Data.Collections
{
    public class Product
    {
        public Product(string? name, string? description, double price, string? category, string? supplier, DateTime created_at, DateTime updated_at)
        {
            Name = name;
            Description = description;
            Price = price;
            this.category = category;
            this.supplier = supplier;
            Created_at = created_at;
            Updated_at = updated_at;
        }

        public string? Name { get; set; }
        public string? Description { get; set; }
        public double Price { get; set; }
        public string? category { get; set; }
        public string? supplier { get; set; }
        public DateTime Created_at { get; set; }
        public DateTime Updated_at { get; set; }
    }
}
