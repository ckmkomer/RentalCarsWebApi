using MediatR;
using RentalCars.Application.Requests;
using RentalCars.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCars.Application.Features.Abouts.Queries.GetList
{
    public class GetListAboutQuery : IRequest<GetListResponse<GetListAboutListItemDTO>>
    {
        public PageRequest PageRequest { get; set; }
    }
}
