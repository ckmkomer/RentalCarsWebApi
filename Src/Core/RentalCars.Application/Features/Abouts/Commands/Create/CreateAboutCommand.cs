using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCars.Application.Features.Abouts.Commands.Create
{
    public class CreateAboutCommand :IRequest<CreateAboutResponse>
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Icon { get; set; }

        public string? IconDescription { get; set; }
    }
}
