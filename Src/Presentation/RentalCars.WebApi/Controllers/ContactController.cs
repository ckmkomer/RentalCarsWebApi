using MediatR;
using Microsoft.AspNetCore.Mvc;
using RentalCars.Application.Features.Abouts.Commands.Update;
using RentalCars.Application.Features.Abouts.Queries.GetList;
using RentalCars.Application.Features.Contacts.Commands.Create;
using RentalCars.Application.Features.Contacts.Commands.Delete;
using RentalCars.Application.Features.Contacts.Commands.Update;
using RentalCars.Application.Features.Contacts.Queries.GetById;
using RentalCars.Application.Features.Contacts.Queries.GetList;
using RentalCars.Application.Requests;
using RentalCars.Application.Responses;
using RentalCars.Application.Services.Repositories;

namespace RentalCars.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IMediator _mediator;


        public ContactController(IMediator mediator, IContactRepository contactRepository)
        {
            _mediator = mediator;
           
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateContactCommand createContactCommand)
        {
            CreateContactResponse response = await _mediator.Send(createContactCommand);

            return Ok(response);
        }

        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            GetListContactQuery getListContactQuery = new() { PageRequest = pageRequest };

            GetListResponse<GetListContactListItemDTO> response = await _mediator.Send(getListContactQuery);

            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            GetByIdContactQuery getByIdContact = new() { Id = id };

            GetByIdContactResponse response = await _mediator.Send(getByIdContact);

            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateContactCommand updateAboutCommand)
        {
            UpdateContactResponse response = await _mediator.Send(updateAboutCommand);

            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            DeleteContactResponse response = await _mediator.Send(new DeleteContactCommand { Id = id });

            return Ok(response);
        }
    }
}
