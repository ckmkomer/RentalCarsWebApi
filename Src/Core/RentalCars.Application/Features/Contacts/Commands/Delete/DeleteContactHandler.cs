using AutoMapper;
using MediatR;
using RentalCars.Application.Services.Repositories;
using RentalCars.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCars.Application.Features.Contacts.Commands.Delete
{
    public class DeleteContactHandler : IRequestHandler<DeleteContactCommand, DeleteContactResponse>
    {
        private readonly IMapper _mapper;
        private readonly IContactRepository _contactRepository;

        public DeleteContactHandler(IMapper mapper, IContactRepository contactRepository)
        {
            _mapper = mapper;
            _contactRepository = contactRepository;
        }

        public async Task<DeleteContactResponse> Handle(DeleteContactCommand request, CancellationToken cancellationToken)
        {
            Contact? contact = await _contactRepository.GetAsync(predicate:x=>x.Id == request.Id,cancellationToken:cancellationToken);

            await _contactRepository.DeleteAsync(contact);

            DeleteContactResponse response = _mapper.Map<DeleteContactResponse>(contact);
            return response;
        }
    }
}
