using AutoMapper;
using MediatR;
using RentalCars.Application.Services.Repositories;
using RentalCars.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCars.Application.Features.Cars.Queries.GetById
{
    public class GetByIdCarHandler : IRequestHandler<GetByIdCarQuery, GetByIdCarResponse>
    {
        private readonly IMapper _mapper;
        private readonly ICarRepository _carRepository;

        public GetByIdCarHandler(IMapper mapper, ICarRepository carRepository)
        {
            _mapper = mapper;
            _carRepository = carRepository;
        }

        public async Task<GetByIdCarResponse> Handle(GetByIdCarQuery request, CancellationToken cancellationToken)
        {
            Car? car = await _carRepository.GetAsync(predicate:x=>x.Id == request.Id, cancellationToken:cancellationToken);

            GetByIdCarResponse response = _mapper.Map<GetByIdCarResponse>(car);
            return response;
        }
    }
}
