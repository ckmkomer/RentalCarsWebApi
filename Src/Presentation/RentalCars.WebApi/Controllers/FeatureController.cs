using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RentalCars.Application.Features.Abouts.Commands.Create;
using RentalCars.Application.Features.Abouts.Commands.Delete;
using RentalCars.Application.Features.Abouts.Commands.Update;
using RentalCars.Application.Features.Abouts.Queries.GetById;
using RentalCars.Application.Features.Abouts.Queries.GetList;
using RentalCars.Application.Features.Features.Commands.Create;
using RentalCars.Application.Features.Features.Commands.Delete;
using RentalCars.Application.Features.Features.Commands.Update;
using RentalCars.Application.Features.Features.Queries.GetById;
using RentalCars.Application.Features.Features.Queries.GetList;
using RentalCars.Application.Requests;
using RentalCars.Application.Responses;

namespace RentalCars.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeatureController : ControllerBase
    {
        private readonly IMediator _mediator;

        public FeatureController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateFeatureCommand createFeatureCommand)
        {
            CreateFeatureResponse response = await _mediator.Send(createFeatureCommand);

            return Ok(response);
        }

        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            GetListFeatureQuery getListFeatureQuery = new() { PageRequest = pageRequest };

            GetListResponse<GetListFeatureListItemDTO> response = await _mediator.Send(getListFeatureQuery);

            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            GetByIdFeatureQuery getByIdFeature = new() { Id = id };

            GetByIdFeatureResponse response = await _mediator.Send(getByIdFeature);

            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateFeatureCommand updateFeatureCommand)
        {
            UpdateFeatureResponse response = await _mediator.Send(updateFeatureCommand);

            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            DeleteFeatureResponse response = await _mediator.Send(new DeleteFeatureCommand { Id = id });

            return Ok(response);
        }
    }
}
