using MediatR;
using RentalCars.Application.Features.Abouts.Queries.GetList;
using RentalCars.Application.Requests;
using RentalCars.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCars.Application.Features.ContactUss.Queries.GetList
{
    public class GetListContactUsQuery : IRequest<GetListResponse<GetListContactUsListItemDTO>>
    {
        public PageRequest PageRequest { get; set; }
    }
}
