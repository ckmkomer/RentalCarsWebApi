using MediatR;
using RentalCars.Application.Features.Services.Commands.Delete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCars.Application.Features.Testimonials.Commands.Delete
{
   public class DeleteTestimonialCommand : IRequest<DeleteTestimonialResponse>
    {
        public int Id { get; set; }
    }
}
