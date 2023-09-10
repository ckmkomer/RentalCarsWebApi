using AutoMapper;
using MediatR;
using RentalCars.Application.Features.Abouts.Commands.Create;
using RentalCars.Application.Services.Repositories;
using RentalCars.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCars.Application.Features.Cars.Commands.Create
{
    public class CreateCarHandler : IRequestHandler<CreateCarCommand, CreateCarResponse>
    {
        private readonly IMapper _mapper;
        private readonly ICarRepository _carRepository;

        public CreateCarHandler(IMapper mapper, ICarRepository carRepository)
        {
            _mapper = mapper;
            _carRepository = carRepository;
        }

        public async Task<CreateCarResponse> Handle(CreateCarCommand request, CancellationToken cancellationToken)
        {
           Car car = _mapper.Map<Car>(request);
            var result =  await _carRepository.AddAsync(car);
            CreateCarResponse response = _mapper.Map<CreateCarResponse>(result);

          
            return response;
        }
    }
}
