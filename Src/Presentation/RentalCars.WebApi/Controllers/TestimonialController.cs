using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RentalCars.Application.Features.Abouts.Commands.Create;
using RentalCars.Application.Features.Abouts.Commands.Delete;
using RentalCars.Application.Features.Abouts.Commands.Update;
using RentalCars.Application.Features.Abouts.Queries.GetById;
using RentalCars.Application.Features.Abouts.Queries.GetList;
using RentalCars.Application.Features.Testimonials.Commands.Create;
using RentalCars.Application.Features.Testimonials.Commands.Delete;
using RentalCars.Application.Features.Testimonials.Commands.Update;
using RentalCars.Application.Features.Testimonials.Queries.GetById;
using RentalCars.Application.Features.Testimonials.Queries.GetList;
using RentalCars.Application.Requests;
using RentalCars.Application.Responses;

namespace RentalCars.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialController : ControllerBase
    {
        private readonly IMediator _mediator;

        public TestimonialController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateTestimonialCommand createTestimonialCommand)
        {
            CreateTestimonialResponse response = await _mediator.Send(createTestimonialCommand);

            return Ok(response);
        }

        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            GetListTestimonialQuery getListAboutTestimonial = new() { PageRequest = pageRequest };

            GetListResponse<GetListTestimonialListItemDTO> response = await _mediator.Send(getListAboutTestimonial);

            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            GetByIdTestimonialQuery getByIdTestimonial = new() { Id = id };

            GetByIdTestimonialResponse response = await _mediator.Send(getByIdTestimonial);

            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateTestimonialCommand updateTestimonialCommand)
        {
            UpdateTestimonialResponse response = await _mediator.Send(updateTestimonialCommand);

            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            DeleteTestimonialResponse response = await _mediator.Send(new DeleteTestimonialCommand { Id = id });

            return Ok(response);
        }
    }
}
