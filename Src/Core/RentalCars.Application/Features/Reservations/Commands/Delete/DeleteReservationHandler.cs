using AutoMapper;
using MediatR;
using RentalCars.Application.Features.Abouts.Commands.Delete;
using RentalCars.Application.Services.Repositories;
using RentalCars.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCars.Application.Features.Reservations.Commands.Delete
{
    public class DeleteReservationHandler : IRequestHandler<DeleteReservationCommand, DeleteReservationResponse>
    {
        private readonly IMapper _mapper;
        private readonly IReservationRepository _reservationRepository;

        public DeleteReservationHandler(IMapper mapper, IReservationRepository reservationRepository)
        {
            _mapper = mapper;
            _reservationRepository = reservationRepository;
        }

        public async Task<DeleteReservationResponse> Handle(DeleteReservationCommand request, CancellationToken cancellationToken)
        {
            Reservation? reservation = await _reservationRepository.GetAsync(predicate:x=>x.Id==request.Id,cancellationToken:cancellationToken);

            await _reservationRepository.DeleteAsync(reservation);

            DeleteReservationResponse response = _mapper.Map<DeleteReservationResponse>(reservation);

            return response;

        }
    }
}
