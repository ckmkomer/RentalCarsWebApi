using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCars.Application.Features.Services.Commands.Create
{
    public class CreateServiceCommand : IRequest<CreateServiceResponse>
    {
        public string? Icon { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
    }
}
