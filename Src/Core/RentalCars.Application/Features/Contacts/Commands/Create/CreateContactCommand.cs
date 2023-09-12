using MediatR;
using RentalCars.Application.Features.Abouts.Commands.Create;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCars.Application.Features.Contacts.Commands.Create
{
   public class CreateContactCommand :IRequest<CreateContactResponse>
    {
        public string? Address { get; set; }

        public string? Email { get; set; }
        public string? Phone { get; set; }

    }
}
