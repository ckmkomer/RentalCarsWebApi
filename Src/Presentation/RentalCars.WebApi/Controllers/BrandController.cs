using MediatR;
using Microsoft.AspNetCore.Mvc;
using RentalCars.Application.Features.Brands.Commands.Create;
using RentalCars.Application.Features.Brands.Commands.Delete;
using RentalCars.Application.Features.Brands.Commands.Update;
using RentalCars.Application.Features.Brands.Queries.GetById;
using RentalCars.Application.Features.Brands.Queries.GetList;
using RentalCars.Application.Requests;
using RentalCars.Application.Responses;

namespace RentalCars.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandController : ControllerBase
    {
        private readonly IMediator _mediator;

        public BrandController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody]   CreateBrandCommand createBrandCommand  )
        {
            CreateBrandResponse response = await _mediator.Send(createBrandCommand);

            return Ok(response);
        }

        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            GetListBrandQuery getListBrandQuery = new() { PageRequest = pageRequest };

            GetListResponse<GetListBrandListItemDTO> response = await _mediator.Send(getListBrandQuery);

            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            GetByIdBrandQuery getByIdBrand = new() { Id = id };

            GetByIdBrandResponse response = await _mediator.Send(getByIdBrand);

            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody]  UpdateBrandCommand updateBrandCommand )
        {
            UpdateBrandResponse response = await _mediator.Send(updateBrandCommand);

            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            DeleteBrandResponse response = await _mediator.Send(new DeleteBrandCommand { Id = id });

            return Ok(response);
        }
    }
}
