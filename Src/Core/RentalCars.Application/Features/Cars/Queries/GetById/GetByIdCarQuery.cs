using MediatR;

namespace RentalCars.Application.Features.Cars.Queries.GetById
{
    public class GetByIdCarQuery :IRequest<GetByIdCarResponse>
    {
        public int Id { get; set; }
    }
}