using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCars.Application.Features.Abouts.Queries.GetById
{
   public class GetByIdAboutQuery : IRequest<GetByIdAboutResponse>
    {
        public int Id { get; set; }
    }
}
