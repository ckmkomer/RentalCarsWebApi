using AutoMapper;
using RentalCars.Application.Features.CarDetails.Commands.Create;
using RentalCars.Application.Features.CarDetails.Commands.Delete;
using RentalCars.Application.Features.CarDetails.Commands.Update;
using RentalCars.Application.Features.CarDetails.Queries.GetById;
using RentalCars.Application.Features.CarDetails.Queries.GetList;
using RentalCars.Application.Paging;
using RentalCars.Application.Responses;
using RentalCars.Domain.Entities;

namespace RentalCars.Application.Features.CarDetails.Profiles
{
    public class MappingProfiles : Profile
    {
       public MappingProfiles()
        {
            CreateMap<CarDetail, CreateCarDetailCommand>().ReverseMap();
            CreateMap<CarDetail, CreateCarDetailResponse>().ReverseMap();
            CreateMap<CarDetail, UpdateCarDetailCommand>().ReverseMap();
            CreateMap<CarDetail, UpdateCarDetailResponse>().ReverseMap();

            CreateMap<CarDetail, DeleteCarDetailCommand>().ReverseMap();
            CreateMap<CarDetail, DeleteCarDetailResponse>().ReverseMap();

            CreateMap<CarDetail, GetListCarDetailListItemDTO>().ReverseMap();
            CreateMap<CarDetail, GetByIdCarDetailResponse>().ReverseMap();
            CreateMap<Paginate<CarDetail>, GetListResponse<GetListCarDetailListItemDTO>>().ReverseMap();
        }
    }
}
