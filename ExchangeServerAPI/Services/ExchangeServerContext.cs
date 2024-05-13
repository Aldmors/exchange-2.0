using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ExchangeServerAPI.Models;

namespace ExchangeServerAPI
{
    public class ExchangeServerContext : DbContext
    {
        public ExchangeServerContext (DbContextOptions<ExchangeServerContext> options)
            : base(options)
        {
        }

        public DbSet<ExchangeServerAPI.Models.Document> Document { get; set; }
        public DbSet<ExchangeServerAPI.Models.Group> Group { get; set; }
        public DbSet<ExchangeServerAPI.Models.Label> Label { get; set; }
        // public DbSet<ExchangeServerAPI.Models.Shipment> Shipment { get; set; }
        public DbSet<ExchangeServerAPI.Models.User> User { get; set; }
    }
}
