using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCars.Application.Features.Testimonials.Commands.Create
{
   public class CreateTestimonialCommand :IRequest<CreateTestimonialResponse>
    {
        public string? Name { get; set; }
        public string? Description { get; set; }

        public string? Image { get; set; }
    }
}
