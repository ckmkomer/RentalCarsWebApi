using RentalCars.Application.Services.Repositories;
using RentalCars.Domain.Entities;
using RentalCars.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCars.Persistence.Repositories
{
    public class ContactUsRepository : EfRepositoryBase<ContactUs, BaseDbContext>, IContactUsRepository
    {
        public ContactUsRepository(BaseDbContext context) : base(context)
        {
        }
    }
}
