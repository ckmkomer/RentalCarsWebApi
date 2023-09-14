using AutoMapper;
using MediatR;
using RentalCars.Application.Features.Services.Queries.GetById;
using RentalCars.Application.Services.Repositories;
using RentalCars.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCars.Application.Features.SocailMedias.Queries.GetById
{
    public class GetByIdSocialMediaHandler : IRequestHandler<GetByIdSocialMediaQuery, GetByIdSocialMediaResponse>
    {
        private readonly IMapper _mapper;
        private readonly ISocialMediaRepository _socialMediaRepository;

        public GetByIdSocialMediaHandler(IMapper mapper, ISocialMediaRepository socialMediaRepository)
        {
            _mapper = mapper;
            _socialMediaRepository = socialMediaRepository;
        }

        public async Task<GetByIdSocialMediaResponse> Handle(GetByIdSocialMediaQuery request, CancellationToken cancellationToken)
        {
           SocialMedia? socialMedia = await _socialMediaRepository.GetAsync(predicate:x=>x.Id == request.Id,cancellationToken:cancellationToken);

            GetByIdSocialMediaResponse response = _mapper.Map<GetByIdSocialMediaResponse>(socialMedia);
            return response;
        }
    }
}
