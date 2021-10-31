using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Client : BaseEntity
    {
        public Client()
        {
            ClientTypes = new List<ClientType>();
        }
        public string FIO { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }

        public string Password { get; set; }

        public ICollection<ClientType> ClientTypes { get; set; }
    }
}
