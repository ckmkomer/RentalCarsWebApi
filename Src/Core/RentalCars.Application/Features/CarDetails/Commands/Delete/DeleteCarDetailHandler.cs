using AutoMapper;
using MediatR;
using RentalCars.Application.Features.Abouts.Commands.Delete;
using RentalCars.Application.Services.Repositories;
using RentalCars.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCars.Application.Features.CarDetails.Commands.Delete
{
    public class DeleteCarDetailHandler : IRequestHandler<DeleteCarDetailCommand, DeleteCarDetailResponse>
    {
        private readonly IMapper _mapper;
        private readonly  ICarDetailsRepository _carDetailsRepository;

        public DeleteCarDetailHandler(IMapper mapper, ICarDetailsRepository carDetailsRepository)
        {
            _mapper = mapper;
            _carDetailsRepository = carDetailsRepository;
        }

        public async Task<DeleteCarDetailResponse> Handle(DeleteCarDetailCommand request, CancellationToken cancellationToken)
        {
            CarDetail? carDetail = await _carDetailsRepository.GetAsync(predicate:x=>x.Id== request.Id,cancellationToken:cancellationToken);

            await _carDetailsRepository.DeleteAsync(carDetail);

            DeleteCarDetailResponse response = _mapper.Map<DeleteCarDetailResponse>(carDetail);
            return response;
        }
    }
}
