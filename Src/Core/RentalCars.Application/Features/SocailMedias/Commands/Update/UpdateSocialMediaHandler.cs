using AutoMapper;
using MediatR;
using RentalCars.Application.Services.Repositories;
using RentalCars.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCars.Application.Features.SocailMedias.Commands.Update
{
    public class UpdateSocialMediaHandler : IRequestHandler<UpdateSocialMediaCommand, UpdateSocialMediaResponse>
    {
        private readonly IMapper _mapper;

        private readonly ISocialMediaRepository _socialMediaRepository;

        public UpdateSocialMediaHandler(IMapper mapper, ISocialMediaRepository socialMediaRepository)
        {
            _mapper = mapper;
            _socialMediaRepository = socialMediaRepository;
        }

        public async Task<UpdateSocialMediaResponse> Handle(UpdateSocialMediaCommand request, CancellationToken cancellationToken)
        {
          SocialMedia? socialMedia = await _socialMediaRepository.GetAsync(predicate:x=>x.Id == request.Id,cancellationToken:cancellationToken);

            socialMedia = _mapper.Map(request,socialMedia);

            await _socialMediaRepository.UpdateAsync(socialMedia);

            UpdateSocialMediaResponse response = _mapper.Map<UpdateSocialMediaResponse>(socialMedia);
            return response;
        }
    }
}
