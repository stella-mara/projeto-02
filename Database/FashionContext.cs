using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using projeto_02.Models;
using Microsoft.EntityFrameworkCore;

namespace projeto_02.Database
{
        public class FashionContext : DbContext
    {
        public FashionContext(DbContextOptions<FashionContext> options)
            : base(options)
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            var assembly = GetType().Assembly;
            modelBuilder.ApplyConfigurationsFromAssembly(assembly);
        }
    }
    }