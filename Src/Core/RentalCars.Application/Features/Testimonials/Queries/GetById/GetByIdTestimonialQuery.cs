using MediatR;
using RentalCars.Application.Features.Services.Queries.GetById;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCars.Application.Features.Testimonials.Queries.GetById
{
   public class GetByIdTestimonialQuery : IRequest<GetByIdTestimonialResponse>
    {
        public int Id { get; set; }
    }
}
