using AutoMapper;
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

namespace RentalCars.Application.Features.Abouts.Queries.GetList
{
    public class GetListAboutQueryHandler : IRequestHandler<GetListAboutQuery, GetListResponse<GetListAboutListItemDTO>>
    {
        private readonly IMapper _mapper;
        private readonly IAboutRepository _aboutRepository;

        public GetListAboutQueryHandler(IMapper mapper, IAboutRepository aboutRepository)
        {
            _mapper = mapper;
            _aboutRepository = aboutRepository;
        }

        public async Task<GetListResponse<GetListAboutListItemDTO>> Handle(GetListAboutQuery request, CancellationToken cancellationToken)
        {
            Paginate<About> abouts = await _aboutRepository.GetListAsync(
                index: request.PageRequest.PageIndex,
                size: request.PageRequest.PageSize,
                cancellationToken: cancellationToken,
                withDeleted: true

                );

            GetListResponse<GetListAboutListItemDTO> response = _mapper.Map<GetListResponse<GetListAboutListItemDTO>>(abouts);
            return response;
        }

       
    }
}
