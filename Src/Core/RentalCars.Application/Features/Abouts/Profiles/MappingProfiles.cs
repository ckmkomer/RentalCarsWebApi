using AutoMapper;
using RentalCars.Application.Features.Abouts.Commands.Create;
using RentalCars.Application.Features.Abouts.Commands.Delete;
using RentalCars.Application.Features.Abouts.Commands.Update;
using RentalCars.Application.Features.Abouts.Queries.GetById;
using RentalCars.Application.Features.Abouts.Queries.GetList;
using RentalCars.Application.Paging;
using RentalCars.Application.Responses;
using RentalCars.Domain.Entities;

namespace RentalCars.Application.Features.Abouts.Profiles
{
    public class MappingProfiles : Profile
    {
        
         public MappingProfiles()
        {
            CreateMap<About,CreateAboutCommand>().ReverseMap();
            CreateMap<About,CreateAboutResponse>().ReverseMap();
            CreateMap<About,UpdateAboutCommand>().ReverseMap();
            CreateMap<About,UpdateAboutResponse>().ReverseMap();

            CreateMap<About, DeleteAboutCommand>().ReverseMap();
            CreateMap<About,DeleteAboutResponse>().ReverseMap();

            CreateMap<About, GetListAboutListItemDTO>().ReverseMap();
            CreateMap<About,GetByIdAboutResponse>().ReverseMap();
            CreateMap<Paginate<About>,GetListResponse<GetListAboutListItemDTO>>().ReverseMap();
        }
    }
}
