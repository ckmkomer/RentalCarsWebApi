using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCars.Application.Features.CarDetails.Commands.Delete
{
    public class DeleteCarDetailCommand :IRequest<DeleteCarDetailResponse>
    {
        public int Id { get; set; }
    }
}
