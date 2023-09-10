using AutoMapper;
using MediatR;
using RentalCars.Application.Features.Abouts.Queries.GetList;
using RentalCars.Application.Paging;
using RentalCars.Application.Responses;
using RentalCars.Application.Services.Repositories;
using RentalCars.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCars.Application.Features.Cars.Queries.GetList
{
    public class GetListCarQueryHandler : IRequestHandler<GetListCarQuery, GetListResponse<GetListCarListItemDTO>>
    {
        private readonly IMapper _mapper;
        private readonly ICarRepository _carRepository;

        public GetListCarQueryHandler(IMapper mapper, ICarRepository carRepository)
        {
            _mapper = mapper;
            _carRepository = carRepository;
        }

        public async Task<GetListResponse<GetListCarListItemDTO>> Handle(GetListCarQuery request, CancellationToken cancellationToken)
        {
            Paginate<Car> cars = await _carRepository.GetListAsync(
                index: request.PageRequest.PageIndex,
                size: request.PageRequest.PageSize,
                cancellationToken: cancellationToken,
                withDeleted: true
                );
            GetListResponse<GetListCarListItemDTO> response = _mapper.Map<GetListResponse<GetListCarListItemDTO>>(cars);
            return response;
        }
    }
}
