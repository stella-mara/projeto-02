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
    public DbSet<Pessoa> Pessoas { get; set; }
    public DbSet<Colecao> Colecoes { get; set; }
    public DbSet<Modelo> Modelos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      base.OnModelCreating(modelBuilder);
      var assembly = GetType().Assembly;
      modelBuilder.ApplyConfigurationsFromAssembly(assembly);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      // Configurar a string de conexão com o banco de dados
      optionsBuilder.UseSqlServer("labclothingcollectionbd");
    }
  }
}
