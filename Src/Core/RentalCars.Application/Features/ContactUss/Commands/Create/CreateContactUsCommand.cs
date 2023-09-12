using MediatR;
using RentalCars.Application.Features.Abouts.Commands.Create;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCars.Application.Features.ContactUss.Commands.Create
{
  public class CreateContactUsCommand : IRequest<CreateContactUsResponse>
    {
        public string? Fullname { get; set; }

        public string? Email { get; set; }

        public string Subject { get; set; }
        public string? Message { get; set; }
    }
}
