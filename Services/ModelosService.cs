using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using projeto_02.Database.Repositories.Interfaces;
using projeto_02.Models;
using projeto_02.Models.Enum;
using projeto_02.Models.ViewModels;
using projeto_02.Services.Interfaces;

namespace projeto_02.Services
{
    public class ModelosService : IModelosService
    {
        private readonly IModelosRepository _modelosRepository;

        public ModelosService(IModelosRepository modelosRepository)
        {
            _modelosRepository = modelosRepository;
        }

        public async Task<bool?> CreateAsync(PostModelo postModelo)
        {
            try
            {
                if (await _modelosRepository.CheckNomeModeloAsync(postModelo.NomeModelo))
                    return null;

                var modelo = new Modelo
                {
                    NomeModelo = postModelo.NomeModelo,
                    IdColecaoRelacionada = postModelo.IdColecaoRelacionada,
                    Tipo = postModelo.Tipo,
                    Layout = postModelo.Layout
                };

                return await _modelosRepository.CreateAsync(modelo);
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public async Task<bool?> UpdateAsync(PutModelo putModelo)
        {
            try
            {
var modelo = await _modelosRepository.GetByIdAsync(putModelo.Id);

if (modelo == null)
    return null;

if (!string.IsNullOrEmpty(putModelo.NomeModelo))
    modelo.NomeModelo = putModelo.NomeModelo;

if (putModelo.IdColecaoRelacionada != 0)
    modelo.IdColecaoRelacionada = putModelo.IdColecaoRelacionada;

if (Enum.IsDefined(typeof(Tipo), putModelo.Tipo))
    modelo.Tipo = putModelo.Tipo;

if (Enum.IsDefined(typeof(Layout), putModelo.Layout))
    modelo.Layout = putModelo.Layout;

return await _modelosRepository.UpdateAsync(modelo);
            }
            catch (Exception e)
            {
                return false;
            }
        }


        public async Task<Modelo?> GetByIdAsync(int id)
        {
            return await _modelosRepository.GetByIdAsync(id);
        }

    public Task<bool?> CreateAsync(PostModelo modelo)
    {
      throw new NotImplementedException();
    }

    public Task<bool?> UpdateAsync(PutModelo modelo)
    {
      throw new NotImplementedException();
    }

    Task<Modelo?> IModelosService.GetByIdAsync(int id)
    {
      throw new NotImplementedException();
    }
  }
}
