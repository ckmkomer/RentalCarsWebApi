using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RentalCars.Application.Services.Repositories;
using RentalCars.Persistence.Contexts;
using RentalCars.Persistence.Repositories;

namespace RentalCars.Persistence
{
    public static class PersistenceServiceRegistration
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<BaseDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("DbCon")));

            services.AddScoped<IAboutRepository, AboutRepository>();
            services.AddScoped<IBrandRepository, BrandRepository>();
            services.AddScoped<ICarRepository, CarRepository>();
            services.AddScoped<ICarDetailsRepository, CarDetailsRepository>();
            services.AddScoped<IContactRepository, ContactRepository>();
            services.AddScoped<IContactUsRepository, ContactUsRepository>();
            services.AddScoped<IFeatureRepository, FeatureRepository>();
            services.AddScoped<IServiceRepository, ServiceRepository>();
            services.AddScoped<IReservationRepository, ReservationRepository>();


            return services;
        }
    }
}
