using AutoMapper;
using MediatR;
using RentalCars.Application.Features.Features.Queries.GetById;
using RentalCars.Application.Services.Repositories;
using RentalCars.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCars.Application.Features.Services.Queries.GetById
{
    public class GetByIdServiceHandler : IRequestHandler<GetByIdServiceQuery, GetByIdServiceResponse>
    {
        private readonly IMapper _mapper;
        private readonly IServiceRepository _serviceRepository;

        public GetByIdServiceHandler(IMapper mapper, IServiceRepository serviceRepository)
        {
            _mapper = mapper;
            _serviceRepository = serviceRepository;
        }

        public async Task<GetByIdServiceResponse> Handle(GetByIdServiceQuery request, CancellationToken cancellationToken)
        {
            Service? service = await _serviceRepository.GetAsync(predicate:x=> x.Id == request.Id,cancellationToken:cancellationToken);

            GetByIdServiceResponse response = _mapper.Map<GetByIdServiceResponse>(service);
            return response;
        }



    }
}
