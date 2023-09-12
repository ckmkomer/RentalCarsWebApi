using AutoMapper;
using Azure.Core;
using MediatR;
using RentalCars.Application.Paging;
using RentalCars.Application.Responses;
using RentalCars.Application.Services.Repositories;
using RentalCars.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCars.Application.Features.CarDetails.Queries.GetList
{
    public class GetListCarDetailQueryHandler : IRequestHandler<GetListCarDetailQuery, GetListResponse<GetListCarDetailListItemDTO>>
    {
        private readonly IMapper _mapper;
        private readonly ICarDetailsRepository _carDetailsRepository;
        private int withDeleted;
        private object GetListReponse;

        public GetListCarDetailQueryHandler(IMapper mapper, ICarDetailsRepository carDetailsRepository)
        {
            _mapper = mapper;
            _carDetailsRepository = carDetailsRepository;
        }

        public async Task<GetListResponse<GetListCarDetailListItemDTO>> Handle(GetListCarDetailQuery request, CancellationToken cancellationToken)
        {
            Paginate<CarDetail> carDetails = await _carDetailsRepository.GetListAsync(
                index: request.PageRequest.PageIndex,
                size:request.PageRequest.PageSize,
                cancellationToken:cancellationToken,
                withDeleted:true
                );

            GetListResponse<GetListCarDetailListItemDTO> response = _mapper.Map<GetListResponse<GetListCarDetailListItemDTO>>(carDetails);

            return response;
        }
    }
}
