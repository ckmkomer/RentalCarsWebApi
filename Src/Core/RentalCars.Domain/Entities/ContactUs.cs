using RentalCars.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCars.Domain.Entities
{
    public class ContactUs:BaseEntity   
    {
        public string? Fullname { get; set; }

        public string? Email { get; set; }

        public string Subject { get; set; }
        public string? Message { get; set; }
    }
}
