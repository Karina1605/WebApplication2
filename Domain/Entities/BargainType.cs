using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class BargainType : BaseEntity
    {
        public string Name { get; set; }

        ICollection<Contract> Contracts { get; set; }
    }
}
