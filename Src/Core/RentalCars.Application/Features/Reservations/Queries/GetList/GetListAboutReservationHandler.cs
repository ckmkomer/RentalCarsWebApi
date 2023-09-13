using AutoMapper;
using MediatR;
using RentalCars.Application.Features.Abouts.Queries.GetList;
using RentalCars.Application.Paging;
using RentalCars.Application.Responses;
using RentalCars.Application.Services.Repositories;
using RentalCars.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCars.Application.Features.Reservations.Queries.GetList
{
    public class GetListAboutReservationHandler : IRequestHandler<GetListReservationQuery, GetListResponse<GetListReservationListItemDTO>>
    {
        private readonly IMapper _mapper;
        private readonly IReservationRepository _reservationRepository;

        public GetListAboutReservationHandler(IMapper mapper, IReservationRepository reservationRepository)
        {
            _mapper = mapper;
            _reservationRepository = reservationRepository;
        }

        public async Task<GetListResponse<GetListReservationListItemDTO>> Handle(GetListReservationQuery request, CancellationToken cancellationToken)
        {
            Paginate<Reservation> reservation = await _reservationRepository.GetListAsync(
                index: request.PageRequest.PageIndex,
                size: request.PageRequest.PageSize,
                cancellationToken: cancellationToken,
                withDeleted: true
                );

            GetListResponse<GetListReservationListItemDTO> response = _mapper.Map<GetListResponse<GetListReservationListItemDTO>>(reservation);
            return response;
        }
    }
}
