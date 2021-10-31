using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class RealEstate : BaseEntity
    {
        public double Space { get; set; }

        public double Price { get; set; }

        public string Address { get; set; }

        public string Description { get; set; }

        ICollection<Contract> Contracts { get; set; }
    }
}
