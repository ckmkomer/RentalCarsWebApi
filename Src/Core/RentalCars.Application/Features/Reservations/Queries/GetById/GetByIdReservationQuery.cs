using MediatR;
using RentalCars.Application.Features.Abouts.Queries.GetById;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCars.Application.Features.Reservations.Queries.GetById
{
  public class GetByIdReservationQuery : IRequest<GetByIdReservationResponse>
    {
        public  int Id { get; set; }
    }
}
