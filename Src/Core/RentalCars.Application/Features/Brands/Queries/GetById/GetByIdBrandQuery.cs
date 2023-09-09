using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCars.Application.Features.Brands.Queries.GetById
{
    public  class GetByIdBrandQuery :IRequest<GetByIdBrandResponse>
    {
        public int Id { get; set; }
    }
}
