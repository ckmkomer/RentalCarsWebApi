using MediatR;
using RentalCars.Application.Features.Abouts.Queries.GetList;
using RentalCars.Application.Requests;
using RentalCars.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCars.Application.Features.Contacts.Queries.GetList
{
    public class GetListContactQuery : IRequest<GetListResponse<GetListContactListItemDTO>>
    {
        public PageRequest PageRequest { get; set; }
    }
}
