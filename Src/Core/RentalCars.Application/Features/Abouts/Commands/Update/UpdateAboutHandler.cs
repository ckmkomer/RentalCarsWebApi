using AutoMapper;
using MediatR;
using RentalCars.Application.Services.Repositories;
using RentalCars.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCars.Application.Features.Abouts.Commands.Update
{
    public class UpdateAboutHandler : IRequestHandler<UpdateAboutCommand, UpdateAboutResponse>
    {
        private readonly IMapper _mapper;
        private readonly IAboutRepository _aboutRepository;

        public UpdateAboutHandler(IMapper mapper, IAboutRepository aboutRepository)
        {
            _mapper = mapper;
            _aboutRepository = aboutRepository;
        }

        public async Task<UpdateAboutResponse> Handle(UpdateAboutCommand request, CancellationToken cancellationToken)
        {
            About? about = await _aboutRepository.GetAsync(predicate: b => b.Id == request.Id, cancellationToken: cancellationToken);

            about =_mapper.Map(request, about);
            await _aboutRepository.UpdateAsync(about);

            UpdateAboutResponse response = _mapper.Map<UpdateAboutResponse>(about);
            return response;
        }
    }
}
