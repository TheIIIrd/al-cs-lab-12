using Microsoft.EntityFrameworkCore;
using laboratory_12.Models;
using System.Collections.Generic;
namespace laboratory_12.Data
{


    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }
    }
}
