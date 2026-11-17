using Demo.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Data
{
    public class DemoDbContext : DbContext
    {
        public DemoDbContext(DbContextOptions options) : base(options)
        {
        }

        public DemoDbContext()
        {
        }

        public DbSet<Client> Clients { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
