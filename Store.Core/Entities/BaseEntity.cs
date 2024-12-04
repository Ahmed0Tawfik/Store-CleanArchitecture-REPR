namespace Store.Core.Entities
{
    public class BaseEntity
    {
        public Guid Id { get; set; }
        public Guid CreatedBy { get; set; }
        public Guid ModifiedBy { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset UpdatedAt { get; set; }

    }
}
