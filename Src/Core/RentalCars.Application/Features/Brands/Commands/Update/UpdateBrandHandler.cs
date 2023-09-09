using AutoMapper;
using MediatR;
using MediatR.Pipeline;
using RentalCars.Application.Services.Repositories;
using RentalCars.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCars.Application.Features.Brands.Commands.Update
{
    public class UpdateBrandHandler : IRequestHandler<UpdateBrandCommand, UpdateBrandResponse>
    {
        private readonly IMapper _mapper;
        private readonly IBrandRepository _brandRepository;

        public UpdateBrandHandler(IMapper mapper, IBrandRepository brandRepository)
        {
            _mapper = mapper;
            _brandRepository = brandRepository;
        }

        public async Task<UpdateBrandResponse> Handle(UpdateBrandCommand request, CancellationToken cancellationToken)
        {
            Brand? brand = await _brandRepository.GetAsync(predicate:x=>x.Id== request.Id,cancellationToken:cancellationToken);

            brand = _mapper.Map (request, brand);
            await _brandRepository.UpdateAsync(brand);

            UpdateBrandResponse response = _mapper.Map<UpdateBrandResponse>(brand);

            return response;
        }
    }
}
