using RentalCars.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCars.Application.Services.Repositories
{
    public interface ICarDetailsRepository: IAsyncRepository<CarDetails>
    {

    }
}
