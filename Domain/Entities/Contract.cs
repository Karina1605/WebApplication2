using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Contract : BaseEntity
    {
        public int BargainTypeId { get; set; }

        public BargainType BargainType { get; set; }

        public int RealEstateId { get; set; }

        public RealEstate RealEstate { get; set; }

        public int EmployeeId { get; set; }

        public Employee Employee { get; set; }

        public int ClientId { get; set; }

        public Client Client { get; set; }

        public DateTime SignDate { get; set; }

        public string BargainCost { get; set; }

        public DateTime FinishDate { get; set; }
    }
}
