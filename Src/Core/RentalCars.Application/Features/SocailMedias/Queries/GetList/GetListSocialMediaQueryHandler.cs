using AutoMapper;
using MediatR;
using RentalCars.Application.Features.Services.Queries.GetList;
using RentalCars.Application.Paging;
using RentalCars.Application.Responses;
using RentalCars.Application.Services.Repositories;
using RentalCars.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCars.Application.Features.SocailMedias.Queries.GetList
{
    public class GetListSocialMediaQueryHandler : IRequestHandler<GetListSocialMediaQuery, GetListResponse<GetListSocialMediaListItemDTO>>
     {
        private readonly IMapper _mapper;
        private ISocialMediaRepository _socialMediaRepository;

        public GetListSocialMediaQueryHandler(IMapper mapper, ISocialMediaRepository socialMediaRepository)
        {
            _mapper = mapper;
            _socialMediaRepository = socialMediaRepository;
        }

        public async Task<GetListResponse<GetListSocialMediaListItemDTO>> Handle(GetListSocialMediaQuery request, CancellationToken cancellationToken)
        {
            Paginate<SocialMedia> socialMedia = await _socialMediaRepository.GetListAsync(
                index: request.PageRequest.PageIndex,
                size: request.PageRequest.PageSize,
                cancellationToken: cancellationToken,
                withDeleted: true
                );

            GetListResponse<GetListSocialMediaListItemDTO> response = _mapper.Map<GetListResponse<GetListSocialMediaListItemDTO>>(socialMedia);
            return response;
        }
    }
}
