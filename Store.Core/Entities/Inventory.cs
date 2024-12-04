using System.Xml.Linq;

namespace Store.Core.Entities
{
    public class Inventory : BaseEntity
    {
        public Inventory() { }

        public Guid InventoryId { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }
        public DateTimeOffset LastUpdated { get; set; }

        // Product relationship
        public List<Product> Products { get; set; } = new();

        public Inventory(int quantity,
                         int reorderlevel,
                         string location,
                         DateTimeOffset lastUpdated,
                         string name)
        {
            InventoryId = Guid.NewGuid();
            Quantity = quantity;
            LastUpdated = lastUpdated;
            CreatedBy = new();
            CreatedAt = DateTimeOffset.Now;
            ModifiedBy = new();
            ModifiedAt = DateTimeOffset.Now;
        }


        //public void UpdateInventory(InventoriesOperationsContract inventory)
        //{
        //    ModifiedOn = DateTimeOffset.Now;
        //    LastUpdated = DateTimeOffset.Now;
        //    Quantity = inventory.Quantity == 0 ? this.Quantity : inventory.Quantity;
        //    Reorderlevel = inventory.Reorderlevel == 0 ? this.Reorderlevel : inventory.Reorderlevel;
        //    Location = string.IsNullOrEmpty(inventory.Location) ? this.Location : inventory.Location;
        //    Name = string.IsNullOrEmpty(inventory.Name) ? this.Name : inventory.Name;
        //}
    }
}
