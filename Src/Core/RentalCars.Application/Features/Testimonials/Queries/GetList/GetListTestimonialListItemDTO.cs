﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCars.Application.Features.Testimonials.Queries.GetList
{
  public class GetListTestimonialListItemDTO
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }

        public string? Image { get; set; }
    }
}
