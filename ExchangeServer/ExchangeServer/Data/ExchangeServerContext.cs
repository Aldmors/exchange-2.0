using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ExchangeServer.Models;

namespace ExchangeServer.Data
{
    public class ExchangeServerContext : DbContext
    {
        public ExchangeServerContext (DbContextOptions<ExchangeServerContext> options)
            : base(options)
        {
        }

        public DbSet<ExchangeServer.Models.Document> Document { get; set; } = default!;
        public DbSet<ExchangeServer.Models.Group> Group { get; set; } = default!;
        public DbSet<ExchangeServer.Models.Label> Label { get; set; } = default!;
        public DbSet<ExchangeServer.Models.Shipment> Shipment { get; set; } = default!;
        public DbSet<ExchangeServer.Models.User> User { get; set; } = default!;
    }
}
