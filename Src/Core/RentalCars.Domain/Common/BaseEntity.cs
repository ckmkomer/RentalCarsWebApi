namespace RentalCars.Domain.Common
{
    public class BaseEntity : IEntityTimestamps
    {
        public int Id { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public DateTime? DeletedDate { get; set; }
    }
}
