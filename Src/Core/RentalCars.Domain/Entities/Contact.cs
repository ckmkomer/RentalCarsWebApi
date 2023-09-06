using RentalCars.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCars.Domain.Entities
{
    public class Contact :BaseEntity

    {
        public string? Address { get; set; }

        public string? Email { get; set; }
        public string? Phone { get; set; }

       
    }
}
