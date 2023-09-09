namespace RentalCars.Application.Features.Abouts.Commands.Update
{
    public class UpdateAboutResponse
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string? Icon { get; set; }

        public string? IconDescription { get; set; }
    }
}