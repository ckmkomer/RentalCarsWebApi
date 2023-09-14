using AutoMapper;
using RentalCars.Application.Features.Services.Commands.Create;
using RentalCars.Application.Features.Services.Commands.Delete;
using RentalCars.Application.Features.Services.Commands.Update;
using RentalCars.Application.Features.Services.Queries.GetById;
using RentalCars.Application.Features.Services.Queries.GetList;
using RentalCars.Application.Features.Testimonials.Commands.Create;
using RentalCars.Application.Features.Testimonials.Commands.Delete;
using RentalCars.Application.Features.Testimonials.Commands.Update;
using RentalCars.Application.Features.Testimonials.Queries.GetById;
using RentalCars.Application.Features.Testimonials.Queries.GetList;
using RentalCars.Application.Paging;
using RentalCars.Application.Responses;
using RentalCars.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCars.Application.Features.Testimonials.Profiles
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Testimonial, CreateTestimonialCommand>().ReverseMap();
            CreateMap<Testimonial, CreateTestimonialResponse>().ReverseMap();
            CreateMap<Testimonial, UpdateTestimonialCommand>().ReverseMap();
            CreateMap<Testimonial, UpdateTestimonialResponse>().ReverseMap();

            CreateMap<Testimonial, DeleteTestimonialCommand>().ReverseMap();
            CreateMap<Testimonial, DeleteTestimonialResponse>().ReverseMap();

            CreateMap<Testimonial, GetListTestimonialListItemDTO>().ReverseMap();
            CreateMap<Testimonial, GetByIdTestimonialResponse>().ReverseMap();
            CreateMap<Paginate<Testimonial>, GetListResponse<GetListTestimonialListItemDTO>>().ReverseMap();
        }
    }
}
