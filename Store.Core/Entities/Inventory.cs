namespace Store.Core.Entities
{
    public class Inventory : BaseEntity
    {
        public Inventory() { }

        public Guid InventoryId { get; set; }
        public Guid ProductId { get; set; }
        public List<Product> Products { get; set; } = new();
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public DateTimeOffset LastUpdated { get; set; }
    }
}
