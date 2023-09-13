using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCars.Application.Features.Services.Commands.Update
{
    public class UpdateServiceCommand : IRequest<UpdateServiceResponse>
    {
        public int  Id { get; set; }
        public string? Icon { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
    }
}
