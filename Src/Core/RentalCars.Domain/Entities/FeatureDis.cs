﻿using RentalCars.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCars.Domain.Entities
{
    public class FeatureDis :BaseEntity
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Description2 { get; set; }
        public string? Description3 { get; set;}

        public string? Image { get; set;}
    }
}
