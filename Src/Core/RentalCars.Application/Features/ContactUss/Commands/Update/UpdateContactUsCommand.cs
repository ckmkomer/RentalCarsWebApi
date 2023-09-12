using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCars.Application.Features.ContactUss.Commands.Update
{
   public class UpdateContactUsCommand :IRequest<UpdateContactUsResponse>
    {
        public int Id { get; set; }
        public string? Fullname { get; set; }

        public string? Email { get; set; }

        public string Subject { get; set; }
        public string? Message { get; set; }
    }
}
