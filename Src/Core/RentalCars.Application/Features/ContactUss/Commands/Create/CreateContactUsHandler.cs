using AutoMapper;
using MediatR;
using RentalCars.Application.Features.Abouts.Commands.Create;
using RentalCars.Application.Services.Repositories;
using RentalCars.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCars.Application.Features.ContactUss.Commands.Create
{
    public class CreateContactUsHandler : IRequestHandler<CreateContactUsCommand, CreateContactUsResponse>
    {
        private readonly IMapper _mapper;
        private readonly IContactUsRepository _contactUsRepository;

        public CreateContactUsHandler(IMapper mapper, IContactUsRepository contactUsRepository)
        {
            _mapper = mapper;
            _contactUsRepository = contactUsRepository;
        }

        public async Task<CreateContactUsResponse> Handle(CreateContactUsCommand request, CancellationToken cancellationToken)
        {
            ContactUs contactUs = _mapper.Map<ContactUs>(request);

            var result = await _contactUsRepository.AddAsync(contactUs);

            CreateContactUsResponse response = _mapper.Map<CreateContactUsResponse>(result);
            return response;
        }
    }
}
