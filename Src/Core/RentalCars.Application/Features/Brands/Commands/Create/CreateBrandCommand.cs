using MediatR;
using RentalCars.Application.Features.Abouts.Commands.Create;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCars.Application.Features.Brands.Commands.Create
{
   public class CreateBrandCommand : IRequest<CreateBrandResponse>
    {
        public string? Image { get; set; }
    }
}
