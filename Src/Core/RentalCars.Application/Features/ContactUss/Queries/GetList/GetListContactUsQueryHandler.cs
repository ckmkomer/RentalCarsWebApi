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

namespace RentalCars.Application.Features.ContactUss.Queries.GetList
{
    public class GetListContactUsQueryHandler : IRequestHandler<GetListContactUsQuery, GetListResponse<GetListContactUsListItemDTO>>
    {
        private readonly IMapper _mapper;
        private readonly IContactUsRepository _contactUsRepository;

        public GetListContactUsQueryHandler(IMapper mapper, IContactUsRepository contactUsRepository)
        {
            _mapper = mapper;
            _contactUsRepository = contactUsRepository;
        }

        public async Task<GetListResponse<GetListContactUsListItemDTO>> Handle(GetListContactUsQuery request, CancellationToken cancellationToken)
        {
            Paginate<ContactUs> contactUs = await _contactUsRepository.GetListAsync(
                index: request.PageRequest.PageIndex,
                size: request.PageRequest.PageSize,
                cancellationToken: cancellationToken,
                withDeleted: true
                );

            GetListResponse<GetListContactUsListItemDTO> response = _mapper.Map<GetListResponse<GetListContactUsListItemDTO>>(contactUs);
            return response;
        }
    }
}
