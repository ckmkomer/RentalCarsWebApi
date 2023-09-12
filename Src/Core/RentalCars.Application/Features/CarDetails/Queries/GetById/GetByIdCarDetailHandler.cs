using AutoMapper;
using MediatR;
using RentalCars.Application.Services.Repositories;
using RentalCars.Domain.Entities;

namespace RentalCars.Application.Features.CarDetails.Queries.GetById
{
    public class GetByIdCarDetailHandler : IRequestHandler<GetByIdCarDetailQuery, GetByIdCarDetailResponse>
    {
        private readonly IMapper _mapper;
        private readonly ICarDetailsRepository _carDetailsRepository;

        public GetByIdCarDetailHandler(IMapper mapper, ICarDetailsRepository carDetailsRepository)
        {
            _mapper = mapper;
            _carDetailsRepository = carDetailsRepository;
        }

        public async Task<GetByIdCarDetailResponse> Handle(GetByIdCarDetailQuery request, CancellationToken cancellationToken)
        {
           CarDetail? carDetail = await _carDetailsRepository.GetAsync(predicate:x=>x.Id == request.Id,cancellationToken:cancellationToken);

            GetByIdCarDetailResponse response = _mapper.Map<GetByIdCarDetailResponse>(carDetail);
            return response;

        }
    }
}
