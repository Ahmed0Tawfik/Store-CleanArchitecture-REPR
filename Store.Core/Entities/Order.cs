using Store.Core.Enums;

namespace Store.Core.Entities
{
    public class Order : BaseEntity
    {
        public Guid OrderId { get; set; }
        public Guid CustomerId { get; set; }
        public DateTimeOffset OrderDate { get; set; }
        public decimal Total { get; set; }
        public OrderStatus Status { get; set; }

        //Details Relationship
        public List<OrderDetail> OrderDetails { get; set; } = new();


        public Order() { } // ctor for ef core
        public Order(Guid customerId,
                     decimal total,
                     OrderStatus status,
                     DateTimeOffset expectedDeliveryDate
                     )
        {
            OrderId = Guid.NewGuid();
            CustomerId = customerId;
            Total = total;
            Status = status;
            CreatedBy = new();
            CreatedAt = DateTimeOffset.Now;
            ModifiedBy = new();
            ModifiedAt = DateTimeOffset.Now;
        }

        //public void UpdateOrder(OrdersOperationsContract order)
        //{
        //    ModifiedOn = DateTimeOffset.Now;
        //    TotalAmount = order.TotalAmount == 0 ? this.TotalAmount : order.TotalAmount;
        //    Status = order.Status == 0 ? this.Status : order.Status;
        //    OrderType = order.OrderType == 0 ? this.OrderType : order.OrderType;
        //    ReceivedDate = order.ReceivedDate == default ? this.ReceivedDate : order.ReceivedDate;
        //    ExpectedDeliveryDate = order.ExpectedDeliveryDate == default ? this.ExpectedDeliveryDate : order.ExpectedDeliveryDate;
        //}

        public void AddOrderDetails(OrderDetail orderDetail) =>
            OrderDetails.Add(orderDetail);
    }

}

