using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCars.Application.Features.Services.Queries.GetById
{
    public class GetByIdServiceQuery :IRequest<GetByIdServiceResponse>
    {
        public int Id { get; set; }
    }
}
