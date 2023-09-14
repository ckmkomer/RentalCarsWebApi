using AutoMapper;
using MediatR;
using RentalCars.Application.Features.Services.Commands.Delete;
using RentalCars.Application.Services.Repositories;
using RentalCars.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCars.Application.Features.SocailMedias.Commands.Delete
{
    public class DeleteSocialMediaHandler : IRequestHandler<DeleteSocialMediaCommand, DeleteSocialMediaResponse>
    {
        private readonly IMapper _mapper;
        private readonly ISocialMediaRepository _socialMediaRepository;

        public DeleteSocialMediaHandler(IMapper mapper, ISocialMediaRepository socialMediaRepository)
        {
            _mapper = mapper;
            _socialMediaRepository = socialMediaRepository;
        }

        public async Task<DeleteSocialMediaResponse> Handle(DeleteSocialMediaCommand request, CancellationToken cancellationToken)
        {
            SocialMedia? socialMedia = await _socialMediaRepository.GetAsync(predicate:x=>x.Id == request.Id,cancellationToken:cancellationToken);

            await _socialMediaRepository.DeleteAsync(socialMedia);

            DeleteSocialMediaResponse response= _mapper.Map<DeleteSocialMediaResponse>(socialMedia);
            return response;
        }
    }
}
