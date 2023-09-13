using AutoMapper;
using RentalCars.Application.Features.Abouts.Commands.Create;
using RentalCars.Application.Features.Abouts.Commands.Delete;
using RentalCars.Application.Features.Abouts.Commands.Update;
using RentalCars.Application.Features.Abouts.Queries.GetById;
using RentalCars.Application.Features.Abouts.Queries.GetList;
using RentalCars.Application.Features.Features.Commands.Create;
using RentalCars.Application.Features.Features.Commands.Delete;
using RentalCars.Application.Features.Features.Commands.Update;
using RentalCars.Application.Features.Features.Queries.GetById;
using RentalCars.Application.Features.Features.Queries.GetList;
using RentalCars.Application.Paging;
using RentalCars.Application.Responses;
using RentalCars.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCars.Application.Features.Features.Profiles
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Feature, CreateFeatureCommand>().ReverseMap();
            CreateMap<Feature, CreateFeatureResponse>().ReverseMap();
            CreateMap<Feature, UpdateFeatureCommand>().ReverseMap();
            CreateMap<Feature, UpdateFeatureResponse>().ReverseMap();

            CreateMap<Feature, DeleteFeatureCommand>().ReverseMap();
            CreateMap<Feature, DeleteFeatureResponse>().ReverseMap();

            CreateMap<Feature, GetListFeatureListItemDTO>().ReverseMap();
            CreateMap<Feature, GetByIdFeatureResponse>().ReverseMap();
            CreateMap<Paginate<Feature>, GetListResponse<GetListFeatureListItemDTO>>().ReverseMap();
        }
    }
}
