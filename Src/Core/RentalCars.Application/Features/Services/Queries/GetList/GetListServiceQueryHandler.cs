using AutoMapper;
using MediatR;
using RentalCars.Application.Paging;
using RentalCars.Application.Responses;
using RentalCars.Application.Services.Repositories;
using RentalCars.Domain.Entities;

namespace RentalCars.Application.Features.Services.Queries.GetList
{
    public class GetListServiceQueryHandler : IRequestHandler<GetListServiceQuery, GetListResponse<GetListServiceListItemDTO>>
    {
        private readonly IMapper _mapper;
        private readonly IServiceRepository _serviceRepository;

        public GetListServiceQueryHandler(IMapper mapper, IServiceRepository serviceRepository)
        {
            _mapper = mapper;
            _serviceRepository = serviceRepository;
        }

        public async Task<GetListResponse<GetListServiceListItemDTO>> Handle(GetListServiceQuery request, CancellationToken cancellationToken)
        {
            Paginate<Service> service = await _serviceRepository.GetListAsync(
                index: request.PageRequest.PageIndex,
                size: request.PageRequest.PageSize,
                cancellationToken: cancellationToken,
                withDeleted: true
            );

            GetListResponse<GetListServiceListItemDTO> response = _mapper.Map<GetListResponse<GetListServiceListItemDTO>>(service);
            return response;

        }
    }
}
