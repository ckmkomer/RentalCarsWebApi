using AutoMapper;
using MediatR;
using RentalCars.Application.Features.Abouts.Queries.GetById;
using RentalCars.Application.Paging;
using RentalCars.Application.Services.Repositories;
using RentalCars.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCars.Application.Features.Reservations.Queries.GetById
{
    public class GetByIdReservationHandler : IRequestHandler<GetByIdReservationQuery, GetByIdReservationResponse>
    {
        private readonly IMapper _mapper;
        private readonly IReservationRepository _reservationRepository;

        public GetByIdReservationHandler(IMapper mapper, IReservationRepository reservationRepository)
        {
            _mapper = mapper;
            _reservationRepository = reservationRepository;
        }

        public async Task<GetByIdReservationResponse> Handle(GetByIdReservationQuery request, CancellationToken cancellationToken)
        {
            Reservation? reservation = await _reservationRepository.GetAsync(predicate: x => x.Id == request.Id, cancellationToken: cancellationToken);

            GetByIdReservationResponse response = _mapper.Map<GetByIdReservationResponse>(reservation);
            return response;

        }
    }
}
