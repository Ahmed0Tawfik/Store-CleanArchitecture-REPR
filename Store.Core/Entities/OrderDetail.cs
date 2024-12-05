namespace Store.Core.Entities
{
    public class OrderDetail : BaseEntity
    {
        public OrderDetail() { }
        public Guid OrderDetailId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        //relation with orders
        public int OrderId { get; set; }
        public Order Order { get; set; } = new();

        //relation with products
        public int ProductId { get; set; }
        public Product Product { get; set; } = null!;

        public OrderDetail(int quantity, decimal totalPrice)
        {
            OrderDetailId = Guid.NewGuid();
            Quantity = quantity;
            Price = totalPrice;
            CreatedBy = new();
            CreatedAt = DateTimeOffset.Now;
            ModifiedBy = new();
            ModifiedAt = DateTimeOffset.Now;
        }

        //public void UpdateOrderDetail(OrderDetailsOperationsContract orderDetail)
        //{
        //    ModifiedOn = DateTimeOffset.Now;
        //    Quantity = orderDetail.Quantity == 0 ? this.Quantity : orderDetail.Quantity;
        //    TotalPrice = orderDetail.TotalPrice == 0 ? this.TotalPrice : orderDetail.TotalPrice;
        //}

        public void SetProduct(Product product) =>
            Product = product;

        public void SetOrder(Order order) =>
            Order = order;

    }
}
