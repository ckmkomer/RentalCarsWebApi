using AutoMapper;
using MediatR;
using RentalCars.Application.Features.Cars.Commands.Delete;
using RentalCars.Application.Services.Repositories;
using RentalCars.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCars.Application.Features.Services.Commands.Delete
{
    public class DeleteServiceHandler : IRequestHandler<DeleteServiceCommand, DeleteServiceResponse>
    {
        private readonly IMapper _mapper;
        private readonly IServiceRepository _serviceRepository;

        public DeleteServiceHandler(IMapper mapper, IServiceRepository serviceRepository)
        {
            _mapper = mapper;
            _serviceRepository = serviceRepository;
        }

        public async Task<DeleteServiceResponse> Handle(DeleteServiceCommand request, CancellationToken cancellationToken)
        {
            Service? service = await _serviceRepository.GetAsync(predicate: x => x.Id == request.Id, cancellationToken: cancellationToken);

            await _serviceRepository.DeleteAsync(service);

            DeleteServiceResponse response =_mapper.Map<DeleteServiceResponse>(service);
            return response;
        }
    }
}
