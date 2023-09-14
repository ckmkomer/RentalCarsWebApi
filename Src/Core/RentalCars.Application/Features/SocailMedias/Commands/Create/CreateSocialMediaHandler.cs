using AutoMapper;
using MediatR;
using RentalCars.Application.Services.Repositories;
using RentalCars.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCars.Application.Features.SocailMedias.Commands.Create
{
    public class CreateSocialMediaHandler : IRequestHandler<CreateSocialMediaCommand, CreateSocialMediaResponse>
    {
        private readonly IMapper _mapper;
        private readonly ISocialMediaRepository _socialMediaRepository;

        public CreateSocialMediaHandler(IMapper mapper, ISocialMediaRepository socialMediaRepository)
        {
            _mapper = mapper;
            _socialMediaRepository = socialMediaRepository;
        }

        public async Task<CreateSocialMediaResponse> Handle(CreateSocialMediaCommand request, CancellationToken cancellationToken)
        {
           SocialMedia socialMedia = _mapper.Map<SocialMedia>(request);

            var result = await _socialMediaRepository.AddAsync(socialMedia);

            CreateSocialMediaResponse response = _mapper.Map<CreateSocialMediaResponse>(result);
            return response;
                
        }
    }
}
