using AutoMapper;
using RentalCars.Application.Features.Brands.Commands.Create;
using RentalCars.Application.Features.Brands.Commands.Delete;
using RentalCars.Application.Features.Brands.Commands.Update;
using RentalCars.Application.Features.Brands.Queries.GetById;
using RentalCars.Application.Features.Brands.Queries.GetList;
using RentalCars.Application.Features.Cars.Commands.Create;
using RentalCars.Application.Features.Cars.Commands.Delete;
using RentalCars.Application.Features.Cars.Commands.Update;
using RentalCars.Application.Features.Cars.Queries.GetById;
using RentalCars.Application.Features.Cars.Queries.GetList;
using RentalCars.Application.Paging;
using RentalCars.Application.Responses;
using RentalCars.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCars.Application.Features.Cars.Profiles
{
    internal class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Car, CreateCarCommand>().ReverseMap();
            CreateMap<Car, CreateCarResponse>().ReverseMap();

            CreateMap<Car, UpdateCarCommand>().ReverseMap();
            CreateMap<Car, UpdateCarResponse>().ReverseMap();

            CreateMap<Car, DeleteCarCommand>().ReverseMap();
            CreateMap<Car, DeleteCarResponse>().ReverseMap();

            CreateMap<Car, GetListCarListItemDTO>().ReverseMap();
            CreateMap<Car, GetByIdCarResponse>().ReverseMap();
                CreateMap<Paginate<Car>, GetListResponse<GetListCarListItemDTO>>().ReverseMap();
        }
    }
}
