using RentalCars.Application.Responses;

namespace RentalCars.Application.Features.Cars.Queries.GetById
{
    public class GetByIdCarResponse 
    {
        public string? Brand { get; set; }
        public string Model { get; set; }

        public Decimal DailyPrice { get; set; }
        public bool IsAvaliable { get; set; }
    }
}