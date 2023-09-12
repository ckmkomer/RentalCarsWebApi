using MediatR;
using RentalCars.Application.Requests;
using RentalCars.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCars.Application.Features.CarDetails.Queries.GetList
{
    public class GetListCarDetailQuery :IRequest<GetListResponse<GetListCarDetailListItemDTO>>
    {
        public PageRequest PageRequest { get; set; }
    }
}
