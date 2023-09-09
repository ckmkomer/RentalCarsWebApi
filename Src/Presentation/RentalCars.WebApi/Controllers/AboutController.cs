using MediatR;
using Microsoft.AspNetCore.Mvc;
using RentalCars.Application.Features.Abouts.Commands.Create;
using RentalCars.Application.Features.Abouts.Commands.Delete;
using RentalCars.Application.Features.Abouts.Commands.Update;
using RentalCars.Application.Features.Abouts.Queries.GetById;
using RentalCars.Application.Features.Abouts.Queries.GetList;
using RentalCars.Application.Requests;
using RentalCars.Application.Responses;

namespace RentalCars.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AboutController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateAboutCommand createAboutCommand)
        {
            CreateAboutResponse response = await _mediator.Send(createAboutCommand);

            return Ok(response);
        }

        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
          GetListAboutQuery  getListAboutQuery  = new() { PageRequest = pageRequest };

            GetListResponse<GetListAboutListItemDTO> response = await _mediator.Send(getListAboutQuery);

            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
          GetByIdAboutQuery getByIdAbout = new() { Id = id };

          GetByIdAboutResponse response = await _mediator.Send(getByIdAbout);

            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody]UpdateAboutCommand updateAboutCommand)
        {
            UpdateAboutResponse response = await _mediator.Send(updateAboutCommand);

            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            DeleteAboutResponse response = await _mediator.Send(new DeleteAboutCommand { Id = id });

            return Ok(response);
        }
    }
}
