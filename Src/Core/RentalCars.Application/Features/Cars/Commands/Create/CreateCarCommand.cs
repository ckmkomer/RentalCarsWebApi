using MediatR;
using RentalCars.Application.Features.Abouts.Commands.Create;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCars.Application.Features.Cars.Commands.Create
{
    public class CreateCarCommand : IRequest<CreateCarResponse>
    {
        public string? Brand { get; set; }
        public string Model { get; set; }

        public Decimal DailyPrice { get; set; }
        public bool IsAvaliable { get; set; }
    }
}
