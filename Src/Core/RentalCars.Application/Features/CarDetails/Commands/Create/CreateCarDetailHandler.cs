using AutoMapper;
using MediatR;
using RentalCars.Application.Services.Repositories;
using RentalCars.Domain.Entities;

namespace RentalCars.Application.Features.CarDetails.Commands.Create
{
    public class CreateCarDetailHandler : IRequestHandler<CreateCarDetailCommand, CreateCarDetailResponse>
    {
        private readonly IMapper _mapper;
        private readonly ICarDetailsRepository _carDetailsRepository;

        public CreateCarDetailHandler(IMapper mapper, ICarDetailsRepository carDetailsRepository)
        {
            _mapper = mapper;
            _carDetailsRepository = carDetailsRepository;
        }

        public async Task<CreateCarDetailResponse> Handle(CreateCarDetailCommand request, CancellationToken cancellationToken)
        {
            CarDetail carDetail = _mapper.Map<CarDetail>(request);
            var result = await _carDetailsRepository.AddAsync(carDetail);

            CreateCarDetailResponse response = _mapper.Map<CreateCarDetailResponse>(result);
            return response;

        }
    }
}
