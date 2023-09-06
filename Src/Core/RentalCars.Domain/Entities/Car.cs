using RentalCars.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCars.Domain.Entities
{
    public class Car: BaseEntity
    {
        public string? Brand { get; set; }
        public string Model { get; set; }

        public Decimal DailyPrice { get; set; }
        public bool IsAvaliable { get; set;}

    }
}
