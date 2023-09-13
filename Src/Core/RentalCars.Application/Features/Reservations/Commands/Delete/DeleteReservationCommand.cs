using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCars.Application.Features.Reservations.Commands.Delete
{
    public class DeleteReservationCommand : IRequest<DeleteReservationResponse>
    {
        public int Id { get; set; }
    }
}
