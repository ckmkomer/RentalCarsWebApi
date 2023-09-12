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

namespace RentalCars.Application.Features.Contacts.Commands.Create
{
    public class CreateContactHandler : IRequestHandler<CreateContactCommand, CreateContactResponse>
    {
        private readonly IMapper _mapper;
        private readonly IContactRepository _contactRepository;

        public async Task<CreateContactResponse> Handle(CreateContactCommand request, CancellationToken cancellationToken)
        {
            Contact? contact = _mapper.Map<Contact>(request);
            var result = await _contactRepository.AddAsync(contact);

            CreateContactResponse response = _mapper.Map<CreateContactResponse>(result);

            return response;
            
        }
    }
}
