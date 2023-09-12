using AutoMapper;
using RentalCars.Application.Features.Abouts.Commands.Create;
using RentalCars.Application.Features.Abouts.Commands.Delete;
using RentalCars.Application.Features.Abouts.Commands.Update;
using RentalCars.Application.Features.Abouts.Queries.GetById;
using RentalCars.Application.Features.Abouts.Queries.GetList;
using RentalCars.Application.Features.ContactUss.Commands.Create;
using RentalCars.Application.Features.ContactUss.Commands.Delete;
using RentalCars.Application.Features.ContactUss.Commands.Update;
using RentalCars.Application.Features.ContactUss.Queries.GetById;
using RentalCars.Application.Features.ContactUss.Queries.GetList;
using RentalCars.Application.Paging;
using RentalCars.Application.Responses;
using RentalCars.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCars.Application.Features.ContactUss.Profiles
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<ContactUs, CreateContactUsCommand>().ReverseMap();
            CreateMap<ContactUs, CreateContactUsResponse>().ReverseMap();
            CreateMap<ContactUs, UpdateContactUsCommand>().ReverseMap();
            CreateMap<ContactUs, UpdateContactUsResponse>().ReverseMap();

            CreateMap<ContactUs, DeleteContactUsCommand>().ReverseMap();
            CreateMap<ContactUs, DeleteContactUsResponse>().ReverseMap();

            CreateMap<ContactUs, GetListContactUsListItemDTO>().ReverseMap();
            CreateMap<ContactUs, GetByIdContactUsResponse>().ReverseMap();
            CreateMap<Paginate<ContactUs>, GetListResponse<GetListContactUsListItemDTO>>().ReverseMap();
        }
    }
}
