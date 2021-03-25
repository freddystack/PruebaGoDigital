using FluentApi.Models;
using FluentApi.Seeders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FluentApi.Config
{
    public class DbModelContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public DbModelContext(DbContextOptions<DbModelContext> options) : base(options) {}

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            new ProductConfiguration(modelbuilder.Entity<Product>());
            modelbuilder.Seed();
            base.OnModelCreating(modelbuilder);
        }

    }
}
