using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCars.Application.Features.Cars.Commands.Delete
{
   public class DeleteCarCommand :IRequest<DeleteCarResponse>
    {
        public int Id { get; set; } 
    }
}
