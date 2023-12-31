﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCars.Application.Features.Features.Queries.GetById
{
 public class GetByIdFeatureQuery:IRequest<GetByIdFeatureResponse>
    {
        public int Id { get; set; }
    }
}
