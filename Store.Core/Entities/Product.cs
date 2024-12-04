namespace Store.Core.Entities
{
    public class Product : BaseEntity
    {
        public Guid ProductId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal UnitPrice { get; set; }

        public Guid CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
