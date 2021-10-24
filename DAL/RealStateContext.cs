using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public class RealStateContext : DbContext
    {
        public DbSet<BargainType> BargainTypes { get; set; }

        public DbSet<Client> Clients { get; set; }

        public DbSet<ClientType> ClientTypes { get; set; }

        public DbSet<Contract> Contracts { get; set; }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<RealEstate> RealEstates { get; set; }

        public RealStateContext(DbContextOptions<RealStateContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

    }
}
