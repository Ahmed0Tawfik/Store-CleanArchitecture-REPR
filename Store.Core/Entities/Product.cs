using System.Transactions;

namespace Store.Core.Entities
{
    public class Product : BaseEntity
    {
        public Guid ProductId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal UnitPrice { get; set; }

        // Category Relationship
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        // Inventory Relationship
        public int InventoryId { get; set; }
        public Inventory Inventory { get; set; } = new();

        // relation with order details
        public List<OrderDetail> OrderDetails { get; set; } = new();

        public Product(string name,
                       string description,
                       decimal unitPrice)
        {
            ProductId = Guid.NewGuid();
            Name = name;
            Description = description;
            UnitPrice = unitPrice;
            CreatedBy = new();
            CreatedAt = DateTimeOffset.Now;
            ModifiedBy = new();
            ModifiedAt = DateTimeOffset.Now;
        }

        public void SetCategory(Category category) =>
            Category = category;

        public void SetInventory(Inventory inventory) =>
            Inventory = inventory;

       

        //public void UpdateProduct(ProductsOperationsContract product)
        //{
        //    ModifiedOn = DateTimeOffset.Now;
        //    Name = string.IsNullOrEmpty(product.Name) ? this.Name : product.Name;
        //    Description = string.IsNullOrEmpty(product.Description) ? this.Description : product.Description;
        //    UnitPrice = product.UnitPrice == 0 ? this.UnitPrice : product.UnitPrice;
        //    Weight = product.Weight == 0 ? this.Weight : product.Weight;
        //    Length = product.Length == 0 ? this.Length : product.Length;
        //    Width = product.Width == 0 ? this.Width : product.Width;
        //    Height = product.Height == 0 ? this.Height : product.Height;
        //    TaxCost = product.TaxCost == 0 ? this.TaxCost : product.TaxCost;
        //    ProfitPerUnit = product.ProfitPerUnit == 0 ? this.ProfitPerUnit : product.ProfitPerUnit;
        //    ProductionCost = product.ProductionCost == 0 ? this.ProductionCost : product.ProductionCost;
        //}

    }
}
