using AutoMapper;
using MediatR;
using Microsoft.Extensions.Caching.Memory;
using RentalCars.Application.Services.Repositories;
using RentalCars.Domain.Entities;
using Serilog;

namespace RentalCars.Application.Features.Brands.Commands.Create
{
    public class CreateBrandHandler : IRequestHandler<CreateBrandCommand, CreateBrandResponse>
    {
        private readonly IMapper _mapper;
        private readonly IBrandRepository _brandRepository;
        private readonly IMemoryCache _memoryCache;

        public CreateBrandHandler(IMapper mapper, IBrandRepository brandRepository, IMemoryCache memoryCache)
        {
            _mapper = mapper;
            _brandRepository = brandRepository;
            _memoryCache = memoryCache;
        }

        public async Task<CreateBrandResponse> Handle(CreateBrandCommand request, CancellationToken cancellationToken)
        {
           
            Brand brand = _mapper.Map<Brand>(request);

            
            var result = await _brandRepository.AddAsync(brand);

            
            if (result != null)
            {
                var cacheKey = "BrandList"; // Önbellekteki ilgili verinin anahtarı
                var cacheEntryOptions = new MemoryCacheEntryOptions()
                    .SetSlidingExpiration(TimeSpan.FromSeconds(60))
                    .SetAbsoluteExpiration(TimeSpan.FromSeconds(3600))
                    .SetPriority(CacheItemPriority.Normal);

                // Önbelleğe ekleme
                _memoryCache.Set(cacheKey, result, cacheEntryOptions);

                // Marka eklemesi başarılı olduğunda loglama
                Log.Information("Yeni marka eklenmiştir: {@Brand}", brand);
            }

            CreateBrandResponse response = _mapper.Map<CreateBrandResponse>(result);

            return response;
        }

    }
}
