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
                    NomeModelo = "Modelo 1",
                    IdColecaoRelacionada = 1,
                    Tipo = Tipo.Bone,
                    Layout = Layout.Bordado
                },
                new Modelo
                {
                    NomeModelo = "Modelo 2",
                    IdColecaoRelacionada = 2,
                    Tipo = Tipo.Calcado,
                    Layout = Layout.Lisa
                },
                new Modelo
                {
                    NomeModelo = "Modelo 3",
                    IdColecaoRelacionada = 3,
                    Tipo = Tipo.Saia,
                    Layout = Layout.Estampa
                },
                new Modelo
                {
                    NomeModelo = "Modelo 4",
                    IdColecaoRelacionada = 4,
                    Tipo = Tipo.Biquini,
                    Layout = Layout.Bordado
                },
                new Modelo
                {
                    NomeModelo = "Modelo 5",
                    IdColecaoRelacionada = 5,
                    Tipo = Tipo.Bermuda,
                    Layout = Layout.Estampa
                }
                   };

        _context.Modelos.AddRange(modelos);
        _context.SaveChanges();
      }
    }
  }
}
