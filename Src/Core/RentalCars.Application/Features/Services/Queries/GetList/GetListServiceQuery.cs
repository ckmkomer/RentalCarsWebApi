using MediatR;
using RentalCars.Application.Features.Features.Queries.GetList;
using RentalCars.Application.Requests;
using RentalCars.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCars.Application.Features.Services.Queries.GetList
{
    public class GetListServiceQuery : IRequest<GetListResponse<GetListServiceListItemDTO>>
    {
        public PageRequest PageRequest { get; set; }
    }
}
