using AutoMapper;
using MediatR;
using RentalCars.Application.Paging;
using RentalCars.Application.Responses;
using RentalCars.Application.Services.Repositories;
using RentalCars.Domain.Entities;

namespace RentalCars.Application.Features.Features.Queries.GetList
{
    public class GetListFeatureQueryHandler : IRequestHandler<GetListFeatureQuery, GetListResponse<GetListFeatureListItemDTO>>
    {
        private readonly IMapper _mapper;
        private readonly IFeatureRepository _featureRepository;

        public GetListFeatureQueryHandler(IMapper mapper, IFeatureRepository featureRepository)
        {
            _mapper = mapper;
            _featureRepository = featureRepository;
        }

        public async Task<GetListResponse<GetListFeatureListItemDTO>> Handle(GetListFeatureQuery request, CancellationToken cancellationToken)
        {
            Paginate<Feature> features = await _featureRepository.GetListAsync(
                index: request.PageRequest.PageIndex,
                size: request.PageRequest.PageSize,
                cancellationToken: cancellationToken,
                withDeleted: true

                );

            GetListResponse<GetListFeatureListItemDTO> response = _mapper.Map<GetListResponse<GetListFeatureListItemDTO>>(features);
            return response;
        }
    }
}

