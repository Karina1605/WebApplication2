using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Employee : BaseEntity
    { 
        public string FIO { get; set; }

        public string Position { get; set; }

        public string Phone { get; set; }

        public DateTime HiringDate { get; set; }
    }
}
