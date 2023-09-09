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
    public class ContactRepository : EfRepositoryBase<Contact, BaseDbContext>, IContactRepository
    {
        public ContactRepository(BaseDbContext context) : base(context)
        {
        }
    }
}
