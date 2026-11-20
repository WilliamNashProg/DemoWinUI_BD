using Demo.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Data
{
    public class DemoDbContext : DbContext
    {
        // Constructure 1 : Pour l'injection de dépendances
        public DemoDbContext(DbContextOptions<DemoDbContext> options) : base(options) { }

        // CONSTRUCTEUR 2 : Sans paramètre (obligatoire pour les migrations EF Core)
        public DemoDbContext() : base() { }

        public DbSet<Client> Clients { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // Chemin : C:\Users\<nom>\Demo\demo.db
                string dbPath = Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.UserProfile),
                    "Demo", "demo.db");

                // Crée le fichier si nécessaire
                Directory.CreateDirectory(Path.GetDirectoryName(dbPath)!);

                // Configure SQLite avec le chemin
                optionsBuilder.UseSqlite($"Data Source={dbPath}");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
