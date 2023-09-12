using MediatR;
using RentalCars.Application.Features.Abouts.Queries.GetById;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCars.Application.Features.Contacts.Queries.GetById
{
    public class GetByIdContactQuery : IRequest<GetByIdContactResponse>
    {
        public int Id { get; set; }
    }
}
