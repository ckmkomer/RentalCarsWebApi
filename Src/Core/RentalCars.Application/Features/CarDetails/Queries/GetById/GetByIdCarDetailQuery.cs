﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCars.Application.Features.CarDetails.Queries.GetById
{
    public class GetByIdCarDetailQuery : IRequest<GetByIdCarDetailResponse>
    {
        public int Id { get; set; }
    }
}
