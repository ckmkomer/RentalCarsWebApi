using Azure.Core;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCars.Application.Features.SocailMedias.Commands.Delete
{
    public class DeleteSocialMediaCommand : IRequest<DeleteSocialMediaResponse>
    {
        public int Id { get; set; }
    }
}
