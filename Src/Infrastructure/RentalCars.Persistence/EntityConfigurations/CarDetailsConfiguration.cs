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
    internal class CarDetailsConfiguration : IEntityTypeConfiguration<CarDetails>
    {
        public void Configure(EntityTypeBuilder<CarDetails> builder)
        {
            builder.ToTable("CarDetails").HasKey(b => b.Id);

            builder.Property(b => b.Id).HasColumnName("Id").IsRequired();
            builder.Property(b => b.Brand).HasColumnName("Brand").IsRequired();
            builder.Property(b => b.Model).HasColumnName("Model").IsRequired();
            builder.Property(b => b.DailyPrice).HasColumnName("DailyPrice").IsRequired();
            builder.Property(b => b.Description).HasColumnName("Description").IsRequired();
            builder.Property(b => b.Fuel).HasColumnName("Fuel").IsRequired();
            builder.Property(b => b.Gear).HasColumnName("Gear").IsRequired();
            builder.Property(b => b.CreatedDate).HasColumnName("CreatedDate").IsRequired();
            builder.Property(b => b.ModifiedDate).HasColumnName("ModifiedDate");
            builder.Property(b => b.DeletedDate).HasColumnName("DeletedDate");

            

           




            builder.HasQueryFilter(b => !b.DeletedDate.HasValue);
        }
    }
}
