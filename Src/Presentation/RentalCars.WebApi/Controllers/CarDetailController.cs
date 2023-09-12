using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RentalCars.Application.Features.Abouts.Commands.Create;
using RentalCars.Application.Features.Abouts.Commands.Delete;
using RentalCars.Application.Features.Abouts.Commands.Update;
using RentalCars.Application.Features.Abouts.Queries.GetById;
using RentalCars.Application.Features.Abouts.Queries.GetList;
using RentalCars.Application.Features.CarDetails.Commands.Create;
using RentalCars.Application.Features.CarDetails.Commands.Delete;
using RentalCars.Application.Features.CarDetails.Commands.Update;
using RentalCars.Application.Features.CarDetails.Queries.GetById;
using RentalCars.Application.Features.CarDetails.Queries.GetList;
using RentalCars.Application.Requests;
using RentalCars.Application.Responses;
using RentalCars.Application.Services.Repositories;

namespace RentalCars.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarDetailController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly ICarDetailsRepository _carDetailsRepository;

        public CarDetailController(IMediator mediator, ICarDetailsRepository carDetailsRepository)
        {
            _mediator = mediator;
            _carDetailsRepository = carDetailsRepository;
        }


        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateCarDetailCommand createCarDetailCommand)
        {
            CreateCarDetailResponse response = await _mediator.Send(createCarDetailCommand);

            return Ok(response);
        }

        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            GetListCarDetailQuery carDetailQuery = new() { PageRequest = pageRequest };

            GetListResponse<GetListCarDetailListItemDTO> response = await _mediator.Send(carDetailQuery);

            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            GetByIdCarDetailQuery  carDetailQuery  = new() { Id = id };

           GetByIdCarDetailResponse response = await _mediator.Send(carDetailQuery);

            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateCarDetailCommand updateCarDetailCommand)
        {
            UpdateCarDetailResponse response = await _mediator.Send(updateCarDetailCommand);

            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            DeleteCarDetailResponse response = await _mediator.Send(new DeleteCarDetailCommand { Id = id });

            return Ok(response);
        }
    }
}
