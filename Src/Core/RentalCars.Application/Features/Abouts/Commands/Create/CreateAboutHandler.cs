using AutoMapper;
using MediatR;
using RentalCars.Application.Services.Repositories;
using RentalCars.Domain.Entities;
using Serilog;

namespace RentalCars.Application.Features.Abouts.Commands.Create
{
    public class CreateAboutHandler : IRequestHandler<CreateAboutCommand, CreateAboutResponse>
    {
        
        private readonly IAboutRepository _aboutRepository;
        private readonly IMapper _mapper;



        public CreateAboutHandler(IAboutRepository aboutRepository, IMapper mapper)
        {
            _aboutRepository = aboutRepository;
            _mapper = mapper;
        }

        public async Task<CreateAboutResponse> Handle(CreateAboutCommand request, CancellationToken cancellationToken)
        {

            About about = _mapper.Map<About>(request);

            var result = await _aboutRepository.AddAsync(about);


            CreateAboutResponse response = _mapper.Map<CreateAboutResponse>(result);

            Log.Information("Yeni bir About eklendi: ID {AboutId}", response.Id);
            return response;

        }
    }
}
