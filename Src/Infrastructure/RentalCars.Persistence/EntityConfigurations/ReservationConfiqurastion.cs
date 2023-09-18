//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;
//using RentalCars.Domain.Entities;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace RentalCars.Persistence.EntityConfigurations
//{
//    internal class ReservationConfiqurastion : IEntityTypeConfiguration<Reservation>
//    {
//        public void Configure(EntityTypeBuilder<Reservation> builder)
//        {
//            builder.ToTable("Reservations").HasKey(b => b.Id);

//            builder.Property(b => b.Id).HasColumnName("Id").IsRequired();
//            builder.Property(b => b.Date).HasColumnName("Date").IsRequired();
//            builder.Property(b => b.DropLocation).HasColumnName("DropLocation").IsRequired();
//            builder.Property(b => b.Select).HasColumnName("Select").IsRequired();
//            builder.Property(b => b.PickupLocation).HasColumnName("PickupLocation").IsRequired();
//            builder.Property(b => b.Car).HasColumnName("Car").IsRequired();
//            builder.Property(b => b.Time).HasColumnName("Time").IsRequired();
//            builder.Property(b => b.CarID).HasColumnName("CarID").IsRequired();
            
//            builder.Property(b => b.CreatedDate).HasColumnName("CreatedDate").IsRequired();
//            builder.Property(b => b.ModifiedDate).HasColumnName("ModifiedDate");
//            builder.Property(b => b.DeletedDate).HasColumnName("DeletedDate");




//            builder.HasQueryFilter(b => !b.DeletedDate.HasValue);
//        }
//    }
//}
