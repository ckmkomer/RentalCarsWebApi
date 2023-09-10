using AutoMapper;
using MediatR;
using RentalCars.Application.Services.Repositories;
using RentalCars.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCars.Application.Features.Cars.Commands.Delete
{
    public class DeleteCarHandler : IRequestHandler<DeleteCarCommand, DeleteCarResponse>
    {
        private readonly IMapper _mapper;
        private readonly ICarRepository _carRepository;

        public DeleteCarHandler(IMapper mapper, ICarRepository carRepository)
        {
            _mapper = mapper;
            _carRepository = carRepository;
        }

        public async Task<DeleteCarResponse> Handle(DeleteCarCommand request, CancellationToken cancellationToken)
        {
            Car? car = await _carRepository.GetAsync(predicate: x=>x.Id == request.Id,cancellationToken:cancellationToken);
            await _carRepository.DeleteAsync(car);

            DeleteCarResponse response = _mapper.Map<DeleteCarResponse>(car);
            return response;
        }
    }
}
