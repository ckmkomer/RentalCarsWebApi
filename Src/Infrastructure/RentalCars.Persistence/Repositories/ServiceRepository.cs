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
    public class ServiceRepository : EfRepositoryBase<Service, BaseDbContext>, IServiceRepository
    {
        public ServiceRepository(BaseDbContext context) : base(context)
        {
        }
    }
}
