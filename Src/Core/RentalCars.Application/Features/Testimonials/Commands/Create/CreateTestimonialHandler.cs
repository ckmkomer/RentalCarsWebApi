using AutoMapper;
using MediatR;
using RentalCars.Application.Features.Services.Commands.Create;
using RentalCars.Application.Features.SocailMedias.Commands.Create;
using RentalCars.Application.Services.Repositories;
using RentalCars.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCars.Application.Features.Testimonials.Commands.Create
{
    public class CreateTestimonialHandler : IRequestHandler<CreateTestimonialCommand, CreateTestimonialResponse>
    {
        private readonly IMapper _mapper;
        private readonly ITestimonialRepository _testimonialRepository;

        public CreateTestimonialHandler(IMapper mapper, ITestimonialRepository testimonialRepository)
        {
            _mapper = mapper;
            _testimonialRepository = testimonialRepository;
        }

        public async Task<CreateTestimonialResponse> Handle(CreateTestimonialCommand request, CancellationToken cancellationToken)
        {
          Testimonial  testimonial = _mapper.Map<Testimonial>(request);

            var result = await _testimonialRepository.AddAsync(testimonial);

            CreateTestimonialResponse response = _mapper.Map<CreateTestimonialResponse>(result);

            return response;

        }
    }
}
