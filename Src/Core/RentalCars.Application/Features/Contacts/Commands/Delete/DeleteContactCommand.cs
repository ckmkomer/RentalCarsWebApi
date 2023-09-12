using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCars.Application.Features.Contacts.Commands.Delete
{
    public class DeleteContactCommand :IRequest<DeleteContactResponse>
    {
        public int Id { get; set; }
    }
}
