using RentalCars.Domain.Common;

namespace RentalCars.Domain.Entities
{
    public class CarDetail :BaseEntity
    {
        public string Title{ get; set; }
        public string Description { get; set; }
        public string? Image { get; set; }
        public string? Brand { get; set; }

        public string? Model { get; set; }

        public string? Gear { get; set; }

        public string? Fuel { get; set; }

        
        public Decimal? DailyPrice { get; set; }

        public int CarID { get; set; }
        public Car Car { get; set; }


    }
}
