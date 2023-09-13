using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCars.Application.Features.Services.Commands.Delete
{
    public class DeleteServiceCommand :IRequest<DeleteServiceResponse>
    {
        public int Id { get; set; }
    }
}
