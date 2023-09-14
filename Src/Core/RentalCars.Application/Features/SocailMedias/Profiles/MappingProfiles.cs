using AutoMapper;
using RentalCars.Application.Features.Services.Commands.Create;
using RentalCars.Application.Features.Services.Commands.Delete;
using RentalCars.Application.Features.Services.Commands.Update;
using RentalCars.Application.Features.Services.Queries.GetById;
using RentalCars.Application.Features.Services.Queries.GetList;
using RentalCars.Application.Features.SocailMedias.Commands.Create;
using RentalCars.Application.Features.SocailMedias.Commands.Delete;
using RentalCars.Application.Features.SocailMedias.Commands.Update;
using RentalCars.Application.Features.SocailMedias.Queries.GetById;
using RentalCars.Application.Features.SocailMedias.Queries.GetList;
using RentalCars.Application.Paging;
using RentalCars.Application.Responses;
using RentalCars.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCars.Application.Features.SocailMedias.Profiles
{
    internal class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<SocialMedia, CreateSocialMediaCommand>().ReverseMap();
            CreateMap<SocialMedia, CreateSocialMediaResponse>().ReverseMap();
            CreateMap<SocialMedia, UpdateSocialMediaCommand>().ReverseMap();
            CreateMap<SocialMedia, UpdateSocialMediaResponse>().ReverseMap();

            CreateMap<SocialMedia, DeleteSocialMediaCommand>().ReverseMap();
            CreateMap<SocialMedia, DeleteSocialMediaResponse>().ReverseMap();

            CreateMap<SocialMedia, GetListSocialMediaListItemDTO>().ReverseMap();
            CreateMap<SocialMedia, GetByIdSocialMediaResponse>().ReverseMap();
            CreateMap<Paginate<SocialMedia>, GetListResponse<GetListSocialMediaListItemDTO>>().ReverseMap();
        }
    }
}
