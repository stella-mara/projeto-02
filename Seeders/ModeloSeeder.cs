using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using projeto_02.Database;
using projeto_02.Models;
using projeto_02.Models.Enum;


namespace projeto_02.Seeders
{
   public interface IModelosSeeder
   {
       void SeedModelos();
   }

   public class ModelosSeeder : IModelosSeeder
   {
       private readonly FashionContext _context;

       public ModelosSeeder(FashionContext context)
       {
           _context = context;
       }

       public void SeedModelos()
       {
           if (!_context.Modelos.Any())
           {
               var modelos = new List<Modelo>
                   {
                new Modelo
                {
                    Id = 1,
                    NomeModelo = "Modelo 1",
                    IdColecaoRelacionada = 1,
                    Tipo = Tipo.Tipo1,
                    Layout = Layout.Layout1
                },
                new Modelo
                {
                    Id = 2,
                    NomeModelo = "Modelo 2",
                    IdColecaoRelacionada = 2,
                    Tipo = Tipo.Tipo2,
                    Layout = Layout.Layout2
                },
                new Modelo
                {
                    Id = 3,
                    NomeModelo = "Modelo 3",
                    IdColecaoRelacionada = 3,
                    Tipo = Tipo.Tipo3,
                    Layout = Layout.Layout3
                },
                new Modelo
                {
                    Id = 4,
                    NomeModelo = "Modelo 4",
                    IdColecaoRelacionada = 4,
                    Tipo = Tipo.Tipo4,
                    Layout = Layout.Layout4
                },
                new Modelo
                {
                    Id = 5,
                    NomeModelo = "Modelo 5",
                    IdColecaoRelacionada = 5,
                    Tipo = Tipo.Tipo5,
                    Layout = Layout.Layout5
                }
                   };

               _context.Modelos.AddRange(modelos);
               _context.SaveChanges();
           }
       }
   }
}
