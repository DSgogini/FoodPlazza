using FoodPlazza.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodPlazza.DAL.Data
{
    public class FoodPlazzaDbContext : DbContext
    {
        public FoodPlazzaDbContext(DbContextOptions contextOptions) : base(contextOptions)
        {

        }

        public DbSet<Product> Product { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
