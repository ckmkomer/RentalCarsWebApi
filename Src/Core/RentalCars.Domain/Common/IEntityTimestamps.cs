namespace RentalCars.Domain.Common
{
    public interface IEntityTimestamps
    {
        DateTime CreatedDate { get; set; }

        DateTime? ModifiedDate { get; set; }

        DateTime? DeletedDate { get; set; }
    }
}
