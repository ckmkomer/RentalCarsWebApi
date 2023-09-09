using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCars.Application.Features.Abouts.Queries.GetList
{
    public class GetListAboutListItemDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string? Icon { get; set; }

        public string? IconDescription { get; set; }
    }
}
