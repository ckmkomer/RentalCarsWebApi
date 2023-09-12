using AutoMapper;
using MediatR;
using RentalCars.Application.Services.Repositories;
using RentalCars.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCars.Application.Features.Features.Commands.Create
{
    public class CreateFeatureHandler : IRequestHandler<CreateFeatureCommand, CreateFeatureResponse>
    {
        private readonly IMapper _mapper;
        private readonly IFeatureRepository _featureRepository;

        public CreateFeatureHandler(IMapper mapper, IFeatureRepository featureRepository)
        {
            _mapper = mapper;
            _featureRepository = featureRepository;
        }

        public async Task<CreateFeatureResponse> Handle(CreateFeatureCommand request, CancellationToken cancellationToken)
        {
            Feature feature = _mapper.Map<Feature>(request);
            var result = await _featureRepository.AddAsync(feature);

            CreateFeatureResponse response = _mapper.Map<CreateFeatureResponse>(result);
            return response;
        }
    }
}
