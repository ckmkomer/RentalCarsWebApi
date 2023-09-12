using AutoMapper;
using MediatR;
using RentalCars.Application.Features.Abouts.Commands.Update;
using RentalCars.Application.Services.Repositories;
using RentalCars.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCars.Application.Features.CarDetails.Commands.Update
{
    public class UpdateCarDetailHandler : IRequestHandler<UpdateCarDetailCommand, UpdateCarDetailResponse>
    {
        private readonly IMapper _mapper;
        private readonly ICarDetailsRepository _carDetailsRepository;

        public UpdateCarDetailHandler(IMapper mapper, ICarDetailsRepository carDetailsRepository)
        {
            _mapper = mapper;
            _carDetailsRepository = carDetailsRepository;
        }

        public async Task<UpdateCarDetailResponse> Handle(UpdateCarDetailCommand request, CancellationToken cancellationToken)
        {
            CarDetail? carDetail = await _carDetailsRepository.GetAsync(predicate: x => x.Id == request.Id, cancellationToken: cancellationToken);

            await _carDetailsRepository.UpdateAsync(carDetail);

            UpdateCarDetailResponse response = _mapper.Map<UpdateCarDetailResponse>(carDetail);
            return response;
        }
    }
}
