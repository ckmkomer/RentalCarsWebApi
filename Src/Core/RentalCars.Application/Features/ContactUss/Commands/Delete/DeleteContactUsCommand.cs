using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCars.Application.Features.ContactUss.Commands.Delete
{
    public class DeleteContactUsCommand :IRequest<DeleteContactUsResponse>
    
    {
        public int Id { get; set; }
    }
}
