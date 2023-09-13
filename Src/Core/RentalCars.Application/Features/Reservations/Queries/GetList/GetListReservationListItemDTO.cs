﻿    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCars.Application.Features.Reservations.Queries.GetList
{
    public class GetListReservationListItemDTO
    {
        public string? PickupLocation { get; set; }
        public string? DropLocation { get; set; }

        public DateTime Date { get; set; }
        public DateTime Time { get; set; }

        public string? Select { get; set; }

        public int CarID { get; set; }
    
    }
}
