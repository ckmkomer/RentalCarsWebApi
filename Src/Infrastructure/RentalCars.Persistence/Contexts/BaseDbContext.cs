using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using RentalCars.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RentalCars.Persistence.Contexts
{
  public class BaseDbContext : DbContext
    {


        public DbSet<About> Abouts { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<CarDetails> CarDetails  { get; set; }

        public DbSet<Brand> Brands { get; set; }

        public DbSet<Contact> Contacts  { get; set; }
        public DbSet<ContactUs> ContactUs  { get; set; }
        public DbSet<Feature> Features   { get; set; }

        public DbSet<FeatureDis> FeatureDis  { get; set; }
        public DbSet<Reservation> Reservations  { get; set; }

        public DbSet<Service> Services  { get; set; }

        public DbSet<SocialMedia> SocailMedias  { get; set; }
        public DbSet<Testimonial> Testimonials  { get; set; }

        public BaseDbContext(DbContextOptions<BaseDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

           
        }
        //protected IConfiguration Configuration { get; set; }

        //public DbSet<About> Abouts { get; set; }

        //public BaseDbContext(DbContextOptions dbContextOptions, IConfiguration configuration) : base(dbContextOptions)
        //{
        //    Configuration = configuration;
        //    Database.EnsureCreated();
        //}

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        //}
    }
}
