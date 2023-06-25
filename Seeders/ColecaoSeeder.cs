using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using projeto_02.Database;
using projeto_02.Models;
using projeto_02.Models.Enum;


namespace projeto_02.Seeders
{
   public interface IColecoesSeeder
   {
       void SeedColecoes();
   }

   public class ColecoesSeeder : IColecoesSeeder
   {
       private readonly FashionContext _context;

       public ColecoesSeeder(FashionContext context)
       {
           _context = context;
       }

       public void SeedColecoes()
       {
           if (!_context.Colecoes.Any())
           {
               var colecoes = new List<Colecao>
                   {
                new Colecao
                {
                    NomeColecao = "Colecao 1",
                    IdResponsavel = 1,
                    Marca = "Marca 1",
                    Orcamento = 10000.50,
                    AnoLancamento = new DateTime(2022, 1, 1),
                    Estacao = Estacao.Verao,
                    EstadoSistema = EstadoSistema.Ativo
                },
                new Colecao
                {
                    NomeColecao = "Colecao 2",
                    IdResponsavel = 2,
                    Marca = "Marca 2",
                    Orcamento = 15000.75,
                    AnoLancamento = new DateTime(2022, 3, 15),
                    Estacao = Estacao.Outono,
                    EstadoSistema = EstadoSistema.Ativo
                },
                new Colecao
                {
                    NomeColecao = "Colecao 3",
                    IdResponsavel = 3,
                    Marca = "Marca 3",
                    Orcamento = 20000.0,
                    AnoLancamento = new DateTime(2022, 6, 30),
                    Estacao = Estacao.Inverno,
                    EstadoSistema = EstadoSistema.Ativo
                },
                new Colecao
                {
                    NomeColecao = "Colecao 4",
                    IdResponsavel = 4,
                    Marca = "Marca 4",
                    Orcamento = 12000.25,
                    AnoLancamento = new DateTime(2022, 9, 20),
                    Estacao = Estacao.Primavera,
                    EstadoSistema = EstadoSistema.Inativo
                },
                new Colecao
                {
                    NomeColecao = "Colecao 5",
                    IdResponsavel = 5,
                    Marca = "Marca 5",
                    Orcamento = 18000.0,
                    AnoLancamento = new DateTime(2022, 12, 10),
                    Estacao = Estacao.Verao,
                    EstadoSistema = EstadoSistema.Ativo
                }
                   };

               _context.Colecoes.AddRange(colecoes);
               _context.SaveChanges();
           }
       }
   }
}
