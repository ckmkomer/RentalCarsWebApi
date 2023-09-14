using AutoMapper;
using MediatR;
using RentalCars.Application.Features.Testimonials.Commands.Create;
using RentalCars.Application.Services.Repositories;
using RentalCars.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCars.Application.Features.Testimonials.Commands.Delete
{
    public class DeleteTestimonialHandler : IRequestHandler<DeleteTestimonialCommand, DeleteTestimonialResponse>
    {
        private readonly IMapper _mapper;
        private ITestimonialRepository _testimonialRepository;

        public DeleteTestimonialHandler(IMapper mapper, ITestimonialRepository testimonialRepository)
        {
            _mapper = mapper;
            _testimonialRepository = testimonialRepository;
        }

        public async Task<DeleteTestimonialResponse> Handle(DeleteTestimonialCommand request, CancellationToken cancellationToken)
        {
            Testimonial? testimonial = await _testimonialRepository.GetAsync(predicate:x=>x.Id == request.Id,cancellationToken:cancellationToken);


            await _testimonialRepository.DeleteAsync(testimonial);

            DeleteTestimonialResponse response = _mapper.Map<DeleteTestimonialResponse>(testimonial);
            return response;
        }
    }
}
