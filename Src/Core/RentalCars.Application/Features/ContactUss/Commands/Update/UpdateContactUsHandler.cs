using AutoMapper;
using MediatR;
using RentalCars.Application.Features.Abouts.Commands.Update;
using RentalCars.Application.Features.ContactUss.Commands.Create;
using RentalCars.Application.Services.Repositories;
using RentalCars.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCars.Application.Features.ContactUss.Commands.Update
{
    public class UpdateContactUsHandler : IRequestHandler<UpdateContactUsCommand, UpdateContactUsResponse>
    {
        private readonly IMapper _mapper;
        private readonly IContactUsRepository _contactUsRepository;

        public UpdateContactUsHandler(IMapper mapper, IContactUsRepository contactUsRepository)
        {
            _mapper = mapper;
            _contactUsRepository = contactUsRepository;
        }

        public async Task<UpdateContactUsResponse> Handle(UpdateContactUsCommand request, CancellationToken cancellationToken)
        {
           ContactUs? contactUs = await _contactUsRepository.GetAsync(predicate:x=>x.Id== request.Id,cancellationToken:cancellationToken);

            contactUs = _mapper.Map(request, contactUs);
            await _contactUsRepository.UpdateAsync(contactUs);

            UpdateContactUsResponse response = _mapper.Map<UpdateContactUsResponse>(contactUs);

            return response;
        }
    }
}
