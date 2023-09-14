using AutoMapper;
using MediatR;
using RentalCars.Application.Features.Abouts.Commands.Update;
using RentalCars.Application.Features.Services.Queries.GetById;
using RentalCars.Application.Features.Testimonials.Commands.Update;
using RentalCars.Application.Services.Repositories;
using RentalCars.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCars.Application.Features.Testimonials.Queries.GetById
{
    public class GetByIdTestimonialHandler : IRequestHandler<GetByIdTestimonialQuery, GetByIdTestimonialResponse>
    {
        private readonly IMapper _mapper;
        private readonly ITestimonialRepository _testimonialRepository;

        public GetByIdTestimonialHandler(IMapper mapper, ITestimonialRepository testimonialRepository)
        {
            _mapper = mapper;
            _testimonialRepository = testimonialRepository;
        }

        public async Task<GetByIdTestimonialResponse> Handle(GetByIdTestimonialQuery request, CancellationToken cancellationToken)
        {
            Testimonial? testimonial = await _testimonialRepository.GetAsync(predicate:x=>x.Id == request.Id,cancellationToken:cancellationToken);

            GetByIdTestimonialResponse response = _mapper.Map<GetByIdTestimonialResponse>(testimonial);
            return response;
        }
    }
}
