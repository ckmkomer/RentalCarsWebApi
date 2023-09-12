using AutoMapper;
using MediatR;
using RentalCars.Application.Services.Repositories;
using RentalCars.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCars.Application.Features.Contacts.Queries.GetById
{
    public class GetByIdContactHandler : IRequestHandler<GetByIdContactQuery, GetByIdContactResponse>
    {
        private readonly IMapper _mapper;
        private readonly IContactRepository _contactRepository;

        public GetByIdContactHandler(IMapper mapper, IContactRepository contactRepository)
        {
            _mapper = mapper;
            _contactRepository = contactRepository;
        }

        public async Task<GetByIdContactResponse> Handle(GetByIdContactQuery request, CancellationToken cancellationToken)
        {
            Contact? contact = await _contactRepository.GetAsync(predicate:x=>x.Id == request.Id,cancellationToken:cancellationToken);

            GetByIdContactResponse response = _mapper.Map<GetByIdContactResponse>(contact);
            return response;
        }
    }
}
