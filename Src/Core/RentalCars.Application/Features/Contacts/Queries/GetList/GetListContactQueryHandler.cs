using AutoMapper;
using MediatR;
using RentalCars.Application.Features.Abouts.Queries.GetList;
using RentalCars.Application.Paging;
using RentalCars.Application.Responses;
using RentalCars.Application.Services.Repositories;
using RentalCars.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCars.Application.Features.Contacts.Queries.GetList
{
    public class GetListContactQueryHandler : IRequestHandler<GetListContactQuery, GetListResponse<GetListContactListItemDTO>>
    {
        private readonly IMapper _mapper;
        private readonly IContactRepository _contactRepository;

        public GetListContactQueryHandler(IMapper mapper, IContactRepository contactRepository)
        {
            _mapper = mapper;
            _contactRepository = contactRepository;
        }

        public async Task<GetListResponse<GetListContactListItemDTO>> Handle(GetListContactQuery request, CancellationToken cancellationToken)
        {
            Paginate<Contact> contacts = await _contactRepository.GetListAsync(

                index: request.PageRequest.PageIndex,
                size: request.PageRequest.PageSize,
                cancellationToken: cancellationToken,
                withDeleted: true

                );

            GetListResponse<GetListContactListItemDTO> response = _mapper.Map<GetListResponse<GetListContactListItemDTO>>(contacts);
            return response;
        }
    }
}
