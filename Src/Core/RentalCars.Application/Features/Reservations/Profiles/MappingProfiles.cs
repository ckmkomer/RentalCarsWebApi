using AutoMapper;
using RentalCars.Application.Features.Abouts.Commands.Create;
using RentalCars.Application.Features.Abouts.Commands.Delete;
using RentalCars.Application.Features.Abouts.Commands.Update;
using RentalCars.Application.Features.Abouts.Queries.GetById;
using RentalCars.Application.Features.Abouts.Queries.GetList;
using RentalCars.Application.Features.Reservations.Commands.Delete;
using RentalCars.Application.Features.Reservations.Queries.GetById;
using RentalCars.Application.Features.Reservations.Queries.GetList;
using RentalCars.Application.Paging;
using RentalCars.Application.Responses;
using RentalCars.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCars.Application.Features.Reservations.Profiles
{
    public class MappingProfiles : Profile
    {
       public MappingProfiles()
        {
            

            CreateMap<Reservation, DeleteReservationCommand>().ReverseMap();
            CreateMap<Reservation, DeleteReservationResponse>().ReverseMap();

            CreateMap<Reservation, GetListReservationListItemDTO>().ReverseMap();
            CreateMap<Reservation, GetByIdReservationResponse>().ReverseMap();
            CreateMap<Paginate<Reservation>, GetListResponse<GetListReservationListItemDTO>>().ReverseMap();
        }
    }
}
