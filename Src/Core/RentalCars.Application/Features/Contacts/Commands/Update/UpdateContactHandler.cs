using AutoMapper;
using MediatR;
using RentalCars.Application.Services.Repositories;
using RentalCars.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCars.Application.Features.Contacts.Commands.Update
{
    public class UpdateContactHandler : IRequestHandler<UpdateContactCommand, UpdateContactResponse>
    {
        private readonly IMapper _mapper;
        private readonly IContactRepository _contactRepository;

        public UpdateContactHandler(IMapper mapper, IContactRepository contactRepository)
        {
            _mapper = mapper;
            _contactRepository = contactRepository;
        }

        public async Task<UpdateContactResponse> Handle(UpdateContactCommand request, CancellationToken cancellationToken)
        {
            Contact? contact = await _contactRepository.GetAsync(predicate:x=>x.Id == request.Id,cancellationToken:cancellationToken);

            await _contactRepository.UpdateAsync(contact);

            UpdateContactResponse response = _mapper.Map<UpdateContactResponse>(contact);
            return response;
        }
    }
}
