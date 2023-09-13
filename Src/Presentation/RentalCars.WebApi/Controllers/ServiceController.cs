using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RentalCars.Application.Features.Brands.Commands.Create;
using RentalCars.Application.Features.Brands.Commands.Delete;
using RentalCars.Application.Features.Brands.Commands.Update;
using RentalCars.Application.Features.Brands.Queries.GetById;
using RentalCars.Application.Features.Brands.Queries.GetList;
using RentalCars.Application.Features.Services.Commands.Create;
using RentalCars.Application.Features.Services.Commands.Delete;
using RentalCars.Application.Features.Services.Commands.Update;
using RentalCars.Application.Features.Services.Queries.GetById;
using RentalCars.Application.Features.Services.Queries.GetList;
using RentalCars.Application.Requests;
using RentalCars.Application.Responses;

namespace RentalCars.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ServiceController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateServiceCommand createServiceCommand)
        {
            CreateServiceResponse response = await _mediator.Send(createServiceCommand);

            return Ok(response);
        }

        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            GetListServiceQuery getListServiceQuery = new() { PageRequest = pageRequest };

            GetListResponse<GetListServiceListItemDTO> response = await _mediator.Send(getListServiceQuery);

            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            GetByIdServiceQuery getByIdService = new() { Id = id };

            GetByIdServiceResponse response = await _mediator.Send(getByIdService);

            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateServiceCommand updateServiceCommand)
        {
            UpdateServiceResponse response = await _mediator.Send(updateServiceCommand);

            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            DeleteServiceResponse response = await _mediator.Send(new DeleteServiceCommand { Id = id });

            return Ok(response);
        }
    }
}
