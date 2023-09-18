using AutoMapper;
using MediatR;
using Microsoft.Extensions.Caching.Memory;
using RentalCars.Application.Features.Brands.Queries.GetById;
using RentalCars.Application.Paging;
using RentalCars.Application.Responses;
using RentalCars.Application.Services.Repositories;
using RentalCars.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RentalCars.Application.Features.Brands.Queries.GetList
{
    public class GetListBrandQueryHandler : IRequestHandler<GetListBrandQuery, GetListResponse<GetListBrandListItemDTO>>
    {
        private readonly IMapper _mapper;
        private readonly IBrandRepository _brandRepository;
        private IMemoryCache _memoryCache;

        public GetListBrandQueryHandler(IMapper mapper, IBrandRepository brandRepository, IMemoryCache memoryCache)
        {
            _mapper = mapper;
            _brandRepository = brandRepository;
            _memoryCache = memoryCache;
        }

        public async Task<GetListResponse<GetListBrandListItemDTO>> Handle(GetListBrandQuery request, CancellationToken cancellationToken)
        {
            
            var cacheKey = "BrandList";

            
            if (_memoryCache.TryGetValue(cacheKey, out GetListResponse<GetListBrandListItemDTO> cachedResponse))
            {
                return cachedResponse;
            }

           
            Paginate<Brand> brands = await _brandRepository.GetListAsync(
                index: request.PageRequest.PageIndex,
                size: request.PageRequest.PageSize, 
                cancellationToken: cancellationToken,
                withDeleted: true
            );

            GetListResponse<GetListBrandListItemDTO> response = _mapper.Map<GetListResponse<GetListBrandListItemDTO>>(brands);

            
            _memoryCache.Set(cacheKey, response, TimeSpan.FromHours(1));

            return response;
        }
    }
}
