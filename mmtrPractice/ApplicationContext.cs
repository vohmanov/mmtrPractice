using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using Microsoft.EntityFrameworkCore;
using mmtrPractice.Models;

namespace mmtrPractice
{
    class ApplicationContext : DbContext
    {
        public DbSet<Order> Orders { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<WorkType> WorkTypes { get; set; }
        public ApplicationContext()
        {
        }

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=test_db1;Username=postgres;Password=admin123");
                optionsBuilder.EnableSensitiveDataLogging();
            }
        }
    }
}
