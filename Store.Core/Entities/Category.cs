namespace Store.Core.Entities
{
    public class Category : BaseEntity
    {
        public Guid CategoryId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        // Product Relationship
        public List<Product> Products { get; set; } = new();

        public Category() { } // For EF Core

        public Category(string name, string description)
        {
            CategoryId = Guid.NewGuid();
            Name = name;
            Description = description;
            CreatedBy = Guid.Empty;
            CreatedAt = DateTimeOffset.UtcNow;
            ModifiedBy = Guid.Empty;
            ModifiedAt = DateTimeOffset.UtcNow;
        }

        public void Update(string name, string description, Guid modifiedby)
        {
            Name = name;
            Description = description;
            ModifiedBy = modifiedby;
            ModifiedAt = DateTimeOffset.UtcNow;
        }
    }
}
