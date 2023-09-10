using AutoMapper;
using MediatR;
using RentalCars.Application.Features.Abouts.Commands.Update;
using RentalCars.Application.Services.Repositories;
using RentalCars.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCars.Application.Features.Cars.Commands.Update
{
    public class UpdateCarHandler : IRequestHandler<UpdateCarCommand, UpdateCarResponse>
    {
        private readonly IMapper _mapper;
        private readonly ICarRepository _carRepository;

        public UpdateCarHandler(IMapper mapper, ICarRepository carRepository)
        {
            _mapper = mapper;
            _carRepository = carRepository;
        }

        public async Task<UpdateCarResponse> Handle(UpdateCarCommand request, CancellationToken cancellationToken)
        {
           Car? car = await _carRepository.GetAsync(predicate:x=>x.Id==request.Id,cancellationToken:cancellationToken);

            car = _mapper.Map(request, car);
            await _carRepository.UpdateAsync(car);
            
            UpdateCarResponse response = _mapper.Map<UpdateCarResponse>(car);
            return response;
        }
    }
}
