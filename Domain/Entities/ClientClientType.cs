using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    class ClientClientType
    {
        public int ClientId { get; set; }

        public Client Client { get; set; }

        public int ClientTypeId { get; set; }

        public ClientType ClientType { get; set; }
    }
}
