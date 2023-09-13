using AutoMapper;
using MediatR;
using RentalCars.Application.Services.Repositories;
using RentalCars.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCars.Application.Features.Features.Commands.Update
{
    public class UpdateFeatureHandler : IRequestHandler<UpdateFeatureCommand, UpdateFeatureResponse>
    {
        private readonly IMapper _mapper;
        private readonly IFeatureRepository _featureRepository;

        public UpdateFeatureHandler(IMapper mapper, IFeatureRepository featureRepository)
        {
            _mapper = mapper;
            _featureRepository = featureRepository;
        }

        public async Task<UpdateFeatureResponse> Handle(UpdateFeatureCommand request, CancellationToken cancellationToken)
        {
            Feature? feature = await _featureRepository.GetAsync(x=>x.Id == request.Id,cancellationToken:cancellationToken);

           feature = _mapper.Map(request,feature);
            await _featureRepository.UpdateAsync(feature);

            UpdateFeatureResponse response = _mapper.Map<UpdateFeatureResponse>(feature);
            return response;
        }
    }
}
