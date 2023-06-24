using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using projeto_02.Models;
using projeto_02.Models.Enum;

namespace projeto_02.Database.Configurations
{
  public class UsuarioConfigurations : IEntityTypeConfiguration<Usuario>
  {
    public void Configure(EntityTypeBuilder<Usuario> builder)
    {
      builder.HasKey(u => u.Id);

      builder.Property(u => u.NomeCommpleto)
          .HasMaxLength(Pessoa.NomeMaxLength)
          .IsRequired();

      builder.Property(u => u.Genero)
          .HasMaxLength(Pessoa.GeneroMaxLength)
          .IsRequired();

      builder.Property(u => u.DataNascimento)
          .IsRequired();

      builder.Property(u => u.CpfCnpj)
          .HasMaxLength(Pessoa.CpfCnpjMaxLength)
          .IsRequired();

      builder.Property(u => u.Telefone)
          .HasMaxLength(Pessoa.TelefoneMaxLength)
          .IsRequired();

      builder.Property(u => u.Email)
          .HasMaxLength(Usuario.EmailMaxLength)
          .IsRequired();

      builder.Property(u => u.TipoUsuario)
          .HasConversion<int>()
          .IsRequired();

      builder.Property(u => u.Status)
          .HasConversion<int>()
          .IsRequired();
    }
  }
}