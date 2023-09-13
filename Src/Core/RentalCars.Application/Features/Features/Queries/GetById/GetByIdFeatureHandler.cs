using AutoMapper;
using MediatR;
using RentalCars.Application.Features.Features.Commands.Update;
using RentalCars.Application.Services.Repositories;
using RentalCars.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCars.Application.Features.Features.Queries.GetById
{
    public class GetByIdFeatureHandler : IRequestHandler<GetByIdFeatureQuery, GetByIdFeatureResponse>
    {
        private readonly IMapper _mapper;
        private readonly IFeatureRepository _featureRepository;

        public GetByIdFeatureHandler(IMapper mapper, IFeatureRepository featureRepository)
        {
            _mapper = mapper;
            _featureRepository = featureRepository;
        }

        public async Task<GetByIdFeatureResponse> Handle(GetByIdFeatureQuery request, CancellationToken cancellationToken)
        {
            Feature? feature = await _featureRepository.GetAsync(predicate:x=>x.Id == request.Id,cancellationToken:cancellationToken);

            GetByIdFeatureResponse response = _mapper.Map<GetByIdFeatureResponse>(feature);
            return response;
        }
    }
}
