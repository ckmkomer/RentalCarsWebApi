using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RentalCars.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCars.Persistence.EntityConfigurations
{
    public class CarConfiguration : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.ToTable("Cars").HasKey(b => b.Id);

            builder.Property(b => b.Id).HasColumnName("Id").IsRequired();
            builder.Property(b => b.Brand).HasColumnName("Brand").IsRequired();
            builder.Property(b => b.Model).HasColumnName("Model").IsRequired();
            builder.Property(b => b.DailyPrice).HasColumnName("DailyPrice").IsRequired();
            builder.Property(b => b.CreatedDate).HasColumnName("CreatedDate").IsRequired();
            builder.Property(b => b.ModifiedDate).HasColumnName("ModifiedDate");
            builder.Property(b => b.DeletedDate).HasColumnName("DeletedDate");

    

            builder.HasMany(b => b.Brands);
            builder.HasMany(b => b.CarDetails);
            builder.HasMany(b => b.Reservations);


            builder.HasQueryFilter(b => !b.DeletedDate.HasValue);
        }
    }
}
