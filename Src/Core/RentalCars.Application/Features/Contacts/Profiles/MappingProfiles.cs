using AutoMapper;
using RentalCars.Application.Features.Abouts.Commands.Create;
using RentalCars.Application.Features.Abouts.Commands.Delete;
using RentalCars.Application.Features.Abouts.Commands.Update;
using RentalCars.Application.Features.Abouts.Queries.GetById;
using RentalCars.Application.Features.Abouts.Queries.GetList;
using RentalCars.Application.Features.Contacts.Commands.Create;
using RentalCars.Application.Features.Contacts.Commands.Delete;
using RentalCars.Application.Features.Contacts.Commands.Update;
using RentalCars.Application.Features.Contacts.Queries.GetById;
using RentalCars.Application.Features.Contacts.Queries.GetList;
using RentalCars.Application.Paging;
using RentalCars.Application.Responses;
using RentalCars.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCars.Application.Features.Contacts.Profiles
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {

            CreateMap<Contact, CreateContactCommand>().ReverseMap();
            CreateMap<Contact, CreateContactResponse>().ReverseMap();
            CreateMap<Contact, UpdateContactCommand>().ReverseMap();
            CreateMap<Contact, UpdateContactResponse>().ReverseMap();

            CreateMap<Contact, DeleteContactCommand>().ReverseMap();
            CreateMap<Contact, DeleteContactResponse>().ReverseMap();

            CreateMap<Contact, GetListContactListItemDTO>().ReverseMap();
            CreateMap<Contact, GetByIdContactResponse>().ReverseMap();
            CreateMap<Paginate<Contact>, GetListResponse<GetListContactListItemDTO>>().ReverseMap();
        }
    }
}
