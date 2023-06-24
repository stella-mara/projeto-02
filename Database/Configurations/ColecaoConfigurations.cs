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
  public class ColecaoConfigurations : IEntityTypeConfiguration<Colecao>
  {
    public void Configure(EntityTypeBuilder<Colecao> builder)
    {
      builder.HasKey(u => u.Id);

      builder.Property(u => u.NomeColecao)
          .HasMaxLength(Colecao.NomeColecaoMaxLength)
          .IsRequired();

      builder.Property(u => u.IdResponsavel)
          .HasConversion<int>()
          .IsRequired();

      builder.Property(u => u.Marca)
      .HasMaxLength(Colecao.MarcaMaxLength)
          .IsRequired();

      builder.Property(u => u.Orcamento)
          .HasMaxLength(Colecao.OrcamentoMaxLength)
          .IsRequired();

      builder.Property(u => u.AnoLancamento)
    .IsRequired();

      builder.Property(u => u.Estacao)
          .HasConversion<int>()
          .IsRequired();

      builder.Property(u => u.EstadoSistema)
          .HasConversion<int>()
          .IsRequired();
    }
  }
}