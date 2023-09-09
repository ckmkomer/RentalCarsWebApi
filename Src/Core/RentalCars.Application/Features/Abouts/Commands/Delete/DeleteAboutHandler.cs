using AutoMapper;
using MediatR;
using RentalCars.Application.Services.Repositories;
using RentalCars.Domain.Entities;

namespace RentalCars.Application.Features.Abouts.Commands.Delete
{
    public class DeleteAboutHandler : IRequestHandler<DeleteAboutCommand, DeleteAboutResponse>
    {
        private readonly IMapper _mapper;
        private readonly IAboutRepository _aboutRepository;

        public DeleteAboutHandler(IMapper mapper, IAboutRepository aboutRepository)
        {
            _mapper = mapper;
            _aboutRepository = aboutRepository;
        }

        public async Task<DeleteAboutResponse> Handle(DeleteAboutCommand request, CancellationToken cancellationToken)
        {
            About? about = await _aboutRepository.GetAsync(predicate: b => b.Id == request.Id, cancellationToken: cancellationToken);

            await _aboutRepository.DeleteAsync(about);
            

            DeleteAboutResponse response = _mapper.Map<DeleteAboutResponse>(about);

            return response;
        }
    }
}
