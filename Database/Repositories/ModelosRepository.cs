using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using projeto_02.Database.Repositories.Interfaces;
using projeto_02.Models;
using projeto_02.Models.Enum;

namespace projeto_02.Database.Repositories
{
    public class ModelosRepository : IModelosRepository
    {
        private readonly FashionContext _modeloRepository;

        public ModelosRepository(FashionContext modeloRepository)
        {
            _modeloRepository = modeloRepository;
        }

    public Task<bool> CheckNomeModeloAsync(string nomeModelo)
    {
      throw new NotImplementedException();
    }

    public async Task<bool?> CreateAsync(Modelo modelo)
        {
            try
            {
                await _modeloRepository.Modelos.AddAsync(modelo);
                await _modeloRepository.SaveChangesAsync();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

    public Task<bool?> DeleteAsync(int id)
    {
      throw new NotImplementedException();
    }

    public Task<Modelo?> GetByIdAsync(int id)
    {
      throw new NotImplementedException();
    }

    public async Task<bool?> UpdateAsync(Modelo modelo)
        {
            try
            {
                _modeloRepository.Modelos.Update(modelo);
                await _modeloRepository.SaveChangesAsync();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }


        public async Task<bool> CheckNomeModeloAsync(string NomeModelo)
        {
            try
            {
                return await _modeloRepository.Modelos.AnyAsync(u => u.NomeModelo == NomeModelo);
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public async Task<Modelo?> GetByIdAsync(int id)
        {
            try
            {
                return await _modeloRepository.Modelos.FindAsync(id);
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public async Task<bool?> DeleteAsync(int id)
        {
            try
            {
                var modelo = await _modeloRepository.Modelos.FindAsync(id);

                if (modelo == null)
                    return null;

                _modeloRepository.Modelos.Remove(modelo);
                await _modeloRepository.SaveChangesAsync();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

    Task<Modelo?> IModelosRepository.GetByIdAsync(int id)
    {
      throw new NotImplementedException();
    }

    public Task<bool?> CreateAsync(Modelo modelo)
    {
      throw new NotImplementedException();
    }

    public Task<bool?> UpdateAsync(Modelo modelo)
    {
      throw new NotImplementedException();
    }

    public Task<bool> CheckNomeModeloAsync(string nomeModelo)
    {
      throw new NotImplementedException();
    }

    Task<Modelo?> IModelosRepository.GetByIdAsync(int id)
    {
      throw new NotImplementedException();
    }
  }
}