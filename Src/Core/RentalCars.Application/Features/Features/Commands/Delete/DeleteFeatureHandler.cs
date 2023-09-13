using AutoMapper;
using MediatR;
using RentalCars.Application.Services.Repositories;
using RentalCars.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCars.Application.Features.Features.Commands.Delete
{
    public class DeleteFeatureHandler : IRequestHandler<DeleteFeatureCommand, DeleteFeatureResponse>
    {
        private readonly IMapper _mapper;
        private readonly IFeatureRepository _featureRepository;

        public DeleteFeatureHandler(IMapper mapper, IFeatureRepository featureRepository)
        {
            _mapper = mapper;
            _featureRepository = featureRepository;
        }

        public async Task<DeleteFeatureResponse> Handle(DeleteFeatureCommand request, CancellationToken cancellationToken)
        {
          Feature? feature = await _featureRepository.GetAsync(predicate:x=>x.Id == request.Id,cancellationToken:cancellationToken);

            await _featureRepository.DeleteAsync(feature);

            DeleteFeatureResponse response = _mapper.Map<DeleteFeatureResponse>(feature);

            return response;
        }
    }
}
