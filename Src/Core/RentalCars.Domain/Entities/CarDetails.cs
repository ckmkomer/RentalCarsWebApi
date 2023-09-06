﻿using RentalCars.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCars.Domain.Entities
{
    public class CarDetails :BaseEntity
    {
        public string Title{ get; set; }
        public string Description { get; set; }
        public string? Image { get; set; }
        public string? Brand { get; set; }

        public string? Model { get; set; }

        public string? Gear { get; set; }

        public string? Fuel { get; set; }

        
        public Decimal? DailyPrice { get; set; }


    }
}