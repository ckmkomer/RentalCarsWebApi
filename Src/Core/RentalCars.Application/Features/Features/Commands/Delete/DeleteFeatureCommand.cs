using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCars.Application.Features.Features.Commands.Delete
{
    public class DeleteFeatureCommand :IRequest<DeleteFeatureResponse>
    {

        public int Id { get; set; }
    }
}
