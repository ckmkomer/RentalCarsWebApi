using AutoMapper;
using RentalCars.Application.Features.Features.Commands.Create;
using RentalCars.Application.Features.Features.Commands.Delete;
using RentalCars.Application.Features.Features.Commands.Update;
using RentalCars.Application.Features.Features.Queries.GetById;
using RentalCars.Application.Features.Features.Queries.GetList;
using RentalCars.Application.Features.Services.Commands.Create;
using RentalCars.Application.Features.Services.Commands.Delete;
using RentalCars.Application.Features.Services.Commands.Update;
using RentalCars.Application.Features.Services.Queries.GetById;
using RentalCars.Application.Features.Services.Queries.GetList;
using RentalCars.Application.Paging;
using RentalCars.Application.Responses;
using RentalCars.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCars.Application.Features.Services.Profiles
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Service, CreateServiceCommand>().ReverseMap();
            CreateMap<Service, CreateServiceResponse>().ReverseMap();
            CreateMap<Service, UpdateServiceCommand>().ReverseMap();
            CreateMap<Service, UpdateServiceResponse>().ReverseMap();

            CreateMap<Service, DeleteServiceCommand>().ReverseMap();
            CreateMap<Service, DeleteServiceResponse>().ReverseMap();

            CreateMap<Service, GetListServiceListItemDTO>().ReverseMap();
            CreateMap<Service, GetByIdServiceResponse>().ReverseMap();
            CreateMap<Paginate<Service>, GetListResponse<GetListServiceListItemDTO>>().ReverseMap();
        }
    }
}
