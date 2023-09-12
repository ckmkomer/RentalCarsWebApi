using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RentalCars.Application.Features.Abouts.Commands.Create;
using RentalCars.Application.Features.Abouts.Commands.Delete;
using RentalCars.Application.Features.Abouts.Commands.Update;
using RentalCars.Application.Features.Abouts.Queries.GetById;
using RentalCars.Application.Features.Abouts.Queries.GetList;
using RentalCars.Application.Features.ContactUss.Commands.Create;
using RentalCars.Application.Features.ContactUss.Commands.Delete;
using RentalCars.Application.Features.ContactUss.Commands.Update;
using RentalCars.Application.Features.ContactUss.Queries.GetById;
using RentalCars.Application.Features.ContactUss.Queries.GetList;
using RentalCars.Application.Requests;
using RentalCars.Application.Responses;

namespace RentalCars.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactUsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ContactUsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateContactUsCommand createContactUsCommand)
        {
            CreateContactUsResponse response = await _mediator.Send(createContactUsCommand);

            return Ok(response);
        }

        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            GetListContactUsQuery getListContactUsQuery = new() { PageRequest = pageRequest };

            GetListResponse<GetListContactUsListItemDTO> response = await _mediator.Send(getListContactUsQuery);

            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            GetByIdContactUsQuery getByIdAbout = new() { Id = id };

            GetByIdContactUsResponse response = await _mediator.Send(getByIdAbout);

            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateContactUsCommand updateContactUsCommand)
        {
            UpdateContactUsResponse response = await _mediator.Send(updateContactUsCommand);

            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            DeleteContactUsResponse response = await _mediator.Send(new DeleteContactUsCommand { Id = id });

            return Ok(response);
        }
    }
}
