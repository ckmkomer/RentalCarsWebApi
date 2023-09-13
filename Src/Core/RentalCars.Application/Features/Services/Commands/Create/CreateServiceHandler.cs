using AutoMapper;
using MediatR;
using RentalCars.Application.Services.Repositories;
using RentalCars.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCars.Application.Features.Services.Commands.Create
{
    public class CreateServiceHandler : IRequestHandler<CreateServiceCommand, CreateServiceResponse>
    {
        private readonly IMapper _mapper;
        private readonly IServiceRepository _serviceRepository;

        public CreateServiceHandler(IMapper mapper, IServiceRepository serviceRepository)
        {
            _mapper = mapper;
           _serviceRepository = serviceRepository;
        }

        public async Task<CreateServiceResponse> Handle(CreateServiceCommand request, CancellationToken cancellationToken)
        {
            Service service = _mapper.Map<Service>(request);
            var result = await _serviceRepository.AddAsync(service);

            CreateServiceResponse response = _mapper.Map<CreateServiceResponse>(result);
            return response;

        }
    }
}
