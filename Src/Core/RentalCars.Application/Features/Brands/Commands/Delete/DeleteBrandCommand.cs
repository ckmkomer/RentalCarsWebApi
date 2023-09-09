using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCars.Application.Features.Brands.Commands.Delete
{
   public class DeleteBrandCommand :IRequest<DeleteBrandResponse>
    {
        public int Id { get; set; }
    }
}
