using AutoMapper;
using MediatR;
using RentalCars.Application.Features.Brands.Queries.GetById;
using RentalCars.Application.Paging;
using RentalCars.Application.Responses;
using RentalCars.Application.Services.Repositories;
using RentalCars.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCars.Application.Features.Brands.Queries.GetList
{
    public class GetListBrandQueryHandler : IRequestHandler<GetListBrandQuery, GetListResponse<GetListBrandListItemDTO>>
    {
        private readonly IMapper _mapper;
        private readonly IBrandRepository _brandRepository;

        public GetListBrandQueryHandler(IMapper mapper, IBrandRepository brandRepository)
        {
            _mapper = mapper;
            _brandRepository = brandRepository;
        }

        public async Task<GetListResponse<GetListBrandListItemDTO>> Handle(GetListBrandQuery request, CancellationToken cancellationToken)
        {

            Paginate<Brand> brands = await _brandRepository.GetListAsync(
                index: request.PageRequest.PageIndex,
                size: request.PageRequest.PageIndex,
              cancellationToken: cancellationToken,
              withDeleted: true
                );

            GetListResponse<GetListBrandListItemDTO> response = _mapper.Map<GetListResponse<GetListBrandListItemDTO>>(brands);

            return response;
              
        }
    }
}
