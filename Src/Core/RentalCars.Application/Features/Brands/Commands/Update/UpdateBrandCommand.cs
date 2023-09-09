using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCars.Application.Features.Brands.Commands.Update
{
   public class UpdateBrandCommand :IRequest<UpdateBrandResponse>
    {
        public int Id { get; set; }

        public string? Image { get; set; }
    }
}
