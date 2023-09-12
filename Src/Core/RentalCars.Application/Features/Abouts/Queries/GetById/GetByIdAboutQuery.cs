using MediatR;
using RentalCars.Application.Features.ContactUss.Queries.GetById;

namespace RentalCars.Application.Features.Abouts.Queries.GetById
{
    public class GetByIdAboutQuery : IRequest<GetByIdAboutResponse>
    {
        public int Id { get; set; }
    }
}
