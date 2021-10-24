using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Client : BaseEntity
    {
        public int ClientTypeId { get; set; }

        public ClientType ClientType { get; set; }

        public string FIO { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }

        public string Password { get; set; }
    }
}
