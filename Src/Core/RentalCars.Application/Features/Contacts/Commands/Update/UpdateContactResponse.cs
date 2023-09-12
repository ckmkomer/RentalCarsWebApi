using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCars.Application.Features.Contacts.Commands.Update
{
    public class UpdateContactResponse
    {
        public string? Address { get; set; }

        public string? Email { get; set; }
        public string? Phone { get; set; }

    }
}
