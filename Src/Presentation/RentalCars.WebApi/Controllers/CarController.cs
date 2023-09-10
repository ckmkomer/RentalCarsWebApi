using MediatR;
using Microsoft.AspNetCore.Mvc;
using RentalCars.Application.Features.Cars.Commands.Create;
using RentalCars.Application.Features.Cars.Commands.Delete;
using RentalCars.Application.Features.Cars.Commands.Update;
using RentalCars.Application.Features.Cars.Queries.GetById;
using RentalCars.Application.Features.Cars.Queries.GetList;
using RentalCars.Application.Requests;
using RentalCars.Application.Responses;

namespace RentalCars.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CarController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateCarCommand createCarCommand)
        {
            CreateCarResponse response = await _mediator.Send(createCarCommand);

            return Ok(response);
        }

        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            GetListCarQuery getListCarQuery = new() { PageRequest = pageRequest };

            GetListResponse<GetListCarListItemDTO> response = await _mediator.Send(getListCarQuery);

            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            GetByIdCarQuery getByIdCar = new() { Id = id };

            GetByIdCarResponse response = await _mediator.Send(getByIdCar);

            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateCarCommand updateCarCommand)
        {
            UpdateCarResponse response = await _mediator.Send(updateCarCommand);

            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            DeleteCarResponse response = await _mediator.Send(new DeleteCarCommand { Id = id });

            return Ok(response);
        }
    }
}
