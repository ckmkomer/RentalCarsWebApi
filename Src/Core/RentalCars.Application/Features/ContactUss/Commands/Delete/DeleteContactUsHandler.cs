using AutoMapper;
using MediatR;
using RentalCars.Application.Services.Repositories;
using RentalCars.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCars.Application.Features.ContactUss.Commands.Delete
{
    public class DeleteContactUsHandler : IRequestHandler<DeleteContactUsCommand, DeleteContactUsResponse>
    {
        private readonly IMapper _mapper;
        private readonly IContactUsRepository _contactUsRepository;

        public DeleteContactUsHandler(IMapper mapper, IContactUsRepository contactUsRepository)
        {
            _mapper = mapper;
            _contactUsRepository = contactUsRepository;
        }

        public async Task<DeleteContactUsResponse> Handle(DeleteContactUsCommand request, CancellationToken cancellationToken)
        {
            ContactUs? contactUs = await _contactUsRepository.GetAsync(predicate:x=>x.Id == request.Id,cancellationToken:cancellationToken);

            await _contactUsRepository.DeleteAsync(contactUs);

            DeleteContactUsResponse response = _mapper.Map<DeleteContactUsResponse>(contactUs);
            return response;
        }
    }
}
