using AutoMapper;
using MediatR;
using RentalCars.Application.Features.Abouts.Queries.GetById;
using RentalCars.Application.Services.Repositories;
using RentalCars.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCars.Application.Features.ContactUss.Queries.GetById
{
    public class GetByIdContactUsHandler : IRequestHandler<GetByIdContactUsQuery, GetByIdContactUsResponse>
    {
        private readonly IMapper _mapper;
        private readonly IContactUsRepository _contactUsRepository;

        public GetByIdContactUsHandler(IMapper mapper, IContactUsRepository contactUsRepository)
        {
            _mapper = mapper;
            _contactUsRepository = contactUsRepository;
        }

        public async Task<GetByIdContactUsResponse> Handle(GetByIdContactUsQuery request, CancellationToken cancellationToken)
        {
            ContactUs? contactUs = await _contactUsRepository.GetAsync(predicate:x=>x.Id == request.Id,cancellationToken:cancellationToken);

            GetByIdContactUsResponse response = _mapper.Map<GetByIdContactUsResponse>(contactUs);
            return response;
        }
    }
}
