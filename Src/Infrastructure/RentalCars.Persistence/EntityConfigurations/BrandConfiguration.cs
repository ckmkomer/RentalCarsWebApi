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
    public  class BrandConfiguration : IEntityTypeConfiguration<Brand>
    {
        
          public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.ToTable("Brand").HasKey(b => b.Id);

            builder.Property(b => b.Id).HasColumnName("Id").IsRequired();
            builder.Property(b => b.Image).HasColumnName("Image").IsRequired();
           
            builder.Property(b => b.CreatedDate).HasColumnName("CreatedDate").IsRequired();
            builder.Property(b => b.ModifiedDate).HasColumnName("ModifiedDate");
            builder.Property(b => b.DeletedDate).HasColumnName("DeletedDate");

           


            builder.HasQueryFilter(b => !b.DeletedDate.HasValue);
        }
    }
}
