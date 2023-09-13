using MediatR;
using Microsoft.AspNetCore.Mvc;
using RentalCars.Application.Features.Cars.Queries.GetById;
using RentalCars.Application.Features.Reservations.Commands.Delete;
using RentalCars.Application.Features.Reservations.Queries.GetList;
using RentalCars.Application.Requests;
using RentalCars.Application.Responses;

namespace RentalCars.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ReservationController(IMediator mediator)
        {
            _mediator = mediator;
        }

        

        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            GetListReservationQuery getListCarQuery = new() { PageRequest = pageRequest };

            GetListResponse<GetListReservationListItemDTO> response = await _mediator.Send(getListCarQuery);

            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            GetByIdCarQuery getByIdCar = new() { Id = id };

            GetByIdCarResponse response = await _mediator.Send(getByIdCar);

            return Ok(response);
        }

       

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            DeleteReservationResponse response = await _mediator.Send(new DeleteReservationCommand { Id = id });

            return Ok(response);
        }
    }
}
