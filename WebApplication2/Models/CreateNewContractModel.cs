using Domain.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class CreateNewContractModel
    {
        public IEnumerable<SelectListItem> Clients { get; set; }

        public IEnumerable<SelectListItem> BargainTypes { get; set; }

        public IEnumerable<SelectListItem> RealEstates { get; set; }

        public Contract Contract { get; set; }
    }
}
