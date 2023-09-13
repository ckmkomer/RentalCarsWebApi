using AutoMapper;
using MediatR;
using RentalCars.Application.Services.Repositories;
using RentalCars.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCars.Application.Features.Services.Commands.Update
{
    
    public class UpdateServiceHandler : IRequestHandler<UpdateServiceCommand, UpdateServiceResponse>
    {

        private readonly IMapper _mapper;
        private readonly IServiceRepository _serviceRepository;

        public UpdateServiceHandler(IMapper mapper, IServiceRepository serviceRepository)
        {
            _mapper = mapper;
            _serviceRepository = serviceRepository;
        }

        public async Task<UpdateServiceResponse> Handle(UpdateServiceCommand request, CancellationToken cancellationToken)
        {
            Service? service = await _serviceRepository.GetAsync(predicate: x => x.Id == request.Id, cancellationToken: cancellationToken);

            service = _mapper.Map(request, service);
            await _serviceRepository.UpdateAsync(service);

            UpdateServiceResponse response = _mapper.Map<UpdateServiceResponse>(service);
            return response;
        }
    }
}
