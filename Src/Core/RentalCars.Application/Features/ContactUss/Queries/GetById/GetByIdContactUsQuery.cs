using MediatR;
using RentalCars.Application.Features.Abouts.Queries.GetById;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCars.Application.Features.ContactUss.Queries.GetById
{
    public class GetByIdContactUsQuery : IRequest<GetByIdContactUsResponse>
    {
        public int Id { get; set; }
    }
}
