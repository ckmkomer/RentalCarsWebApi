using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RentalCars.Application.Features.Abouts.Commands.Create;
using RentalCars.Application.Features.Abouts.Commands.Delete;
using RentalCars.Application.Features.Abouts.Commands.Update;
using RentalCars.Application.Features.Abouts.Queries.GetById;
using RentalCars.Application.Features.Abouts.Queries.GetList;
using RentalCars.Application.Features.SocailMedias.Commands.Create;
using RentalCars.Application.Features.SocailMedias.Commands.Delete;
using RentalCars.Application.Features.SocailMedias.Commands.Update;
using RentalCars.Application.Features.SocailMedias.Queries.GetById;
using RentalCars.Application.Features.SocailMedias.Queries.GetList;
using RentalCars.Application.Requests;
using RentalCars.Application.Responses;
using RentalCars.Application.Services.Repositories;

namespace RentalCars.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SocialMediaController : ControllerBase
    {
        private readonly IMediator _mediator;

        public SocialMediaController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateSocialMediaCommand createSocialMediaCommand)
        {
            CreateSocialMediaResponse response = await _mediator.Send(createSocialMediaCommand);

            return Ok(response);
        }

        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            GetListSocialMediaQuery getListSocialMediaQuery = new() { PageRequest = pageRequest };

            GetListResponse<GetListSocialMediaListItemDTO> response = await _mediator.Send(getListSocialMediaQuery);

            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            GetByIdSocialMediaQuery getByIdSocialMedia = new() { Id = id };

            GetByIdSocialMediaResponse response = await _mediator.Send(getByIdSocialMedia);

            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateSocialMediaCommand updateSocialMediaCommand)
        {
            UpdateSocialMediaResponse response = await _mediator.Send(updateSocialMediaCommand);

            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            DeleteSocialMediaResponse response = await _mediator.Send(new DeleteSocialMediaCommand { Id = id });

            return Ok(response);
        }
    }
}
