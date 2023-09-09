using AutoMapper;
using RentalCars.Application.Features.Brands.Commands.Create;
using RentalCars.Application.Features.Brands.Commands.Delete;
using RentalCars.Application.Features.Brands.Commands.Update;
using RentalCars.Application.Features.Brands.Queries.GetById;
using RentalCars.Application.Features.Brands.Queries.GetList;
using RentalCars.Application.Paging;
using RentalCars.Application.Responses;
using RentalCars.Domain.Entities;

namespace RentalCars.Application.Features.Brands.Profiles
{
    public class MappingProfiles : Profile
    {
       public MappingProfiles()
        {
            CreateMap<Brand, CreateBrandCommand>().ReverseMap();
            CreateMap<Brand, CreateBrandResponse>().ReverseMap();

            CreateMap<Brand, UpdateBrandCommand>().ReverseMap();
            CreateMap<Brand, UpdateBrandResponse>().ReverseMap();

            CreateMap<Brand, DeleteBrandCommand>().ReverseMap();
            CreateMap<Brand, DeleteBrandResponse>().ReverseMap();

            CreateMap<Brand, GetListBrandListItemDTO>().ReverseMap();
            CreateMap<Brand, GetByIdBrandResponse>().ReverseMap();
            CreateMap<Paginate<Brand>, GetListResponse<GetListBrandListItemDTO>>().ReverseMap();
        }
    }
}
