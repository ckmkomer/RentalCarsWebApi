using AutoMapper;
using MediatR;
using RentalCars.Application.Services.Repositories;
using RentalCars.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCars.Application.Features.Abouts.Queries.GetById
{
    internal class GetByIdAboutHandler : IRequestHandler<GetByIdAboutQuery, GetByIdAboutResponse>
    {
        private readonly IMapper _mapper;
        private readonly IAboutRepository _aboutRepository;

        public GetByIdAboutHandler(IMapper mapper, IAboutRepository aboutRepository)
        {
            _mapper = mapper;
            _aboutRepository = aboutRepository;
        }

        public async Task<GetByIdAboutResponse> Handle(GetByIdAboutQuery request, CancellationToken cancellationToken)
        {
            About? about= await _aboutRepository.GetAsync(predicate:b=>b.Id==request.Id, cancellationToken:cancellationToken);

            GetByIdAboutResponse response = _mapper.Map<GetByIdAboutResponse>(about);
            return response;
        }
    }
}
