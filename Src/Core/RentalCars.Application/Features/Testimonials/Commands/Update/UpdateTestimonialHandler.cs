using AutoMapper;
using MediatR;
using RentalCars.Application.Features.Services.Commands.Update;
using RentalCars.Application.Services.Repositories;
using RentalCars.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCars.Application.Features.Testimonials.Commands.Update
{
    public class UpdateTestimonialHandler : IRequestHandler<UpdateTestimonialCommand, UpdateTestimonialResponse>
    {
        private readonly IMapper _mapper;
        private readonly ITestimonialRepository _testimonialRepository;

        public UpdateTestimonialHandler(IMapper mapper, ITestimonialRepository testimonialRepository)
        {
            _mapper = mapper;
            _testimonialRepository = testimonialRepository;
        }

        public async Task<UpdateTestimonialResponse> Handle(UpdateTestimonialCommand request, CancellationToken cancellationToken)
        {
           Testimonial? testimonial = await _testimonialRepository.GetAsync(predicate:x=>x.Id == request.Id,cancellationToken:cancellationToken);

            testimonial = _mapper.Map(request, testimonial);
            await _testimonialRepository.UpdateAsync(testimonial);

            UpdateTestimonialResponse response = _mapper.Map<UpdateTestimonialResponse>(testimonial);
            return response;
        }
    }
}
