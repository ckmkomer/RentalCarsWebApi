using AutoMapper;
using MediatR;
using RentalCars.Application.Features.Services.Queries.GetList;
using RentalCars.Application.Paging;
using RentalCars.Application.Responses;
using RentalCars.Application.Services.Repositories;
using RentalCars.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCars.Application.Features.Testimonials.Queries.GetList
{
    public class GetListTestimonialQueryHandler : IRequestHandler<GetListTestimonialQuery, GetListResponse<GetListTestimonialListItemDTO>>
    {
        private readonly IMapper _mapper;
        private readonly ITestimonialRepository _testimonialRepository;

        public GetListTestimonialQueryHandler(IMapper mapper, ITestimonialRepository testimonialRepository)
        {
            _mapper = mapper;
            _testimonialRepository = testimonialRepository;
        }

        public async Task<GetListResponse<GetListTestimonialListItemDTO>> Handle(GetListTestimonialQuery request, CancellationToken cancellationToken)
        {
            Paginate<Testimonial> testimonial = await _testimonialRepository.GetListAsync(
                index: request.PageRequest.PageIndex,
                size: request.PageRequest.PageSize,
                cancellationToken: cancellationToken,
                withDeleted: true

                );

            GetListResponse<GetListTestimonialListItemDTO> response = _mapper.Map<GetListResponse<GetListTestimonialListItemDTO>>(testimonial);
            return response;
        }
    }
}
