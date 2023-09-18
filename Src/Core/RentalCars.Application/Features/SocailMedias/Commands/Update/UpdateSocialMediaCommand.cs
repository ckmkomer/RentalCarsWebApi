﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCars.Application.Features.SocailMedias.Commands.Update
{
    public class UpdateSocialMediaCommand :IRequest<UpdateSocialMediaResponse>
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Icon { get; set; }

        public string? Url { get; set; }
    }
}