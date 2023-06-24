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
        private readonly FashionContext _context;

        public ModelosRepository(FashionContext context)
        {
            _context = context;
        }

        public async Task<bool> CheckNomeModeloAsync(string nomeModelo)
        {
            try
            {
                return await _context.Modelos.AnyAsync(u => u.NomeModelo == nomeModelo);
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public async Task<bool?> CreateAsync(Modelo modelo)
        {
            try
            {
                await _context.Modelos.AddAsync(modelo);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public async Task<bool?> UpdateAsync(Modelo modelo)
        {
            try
            {
                _context.Modelos.Update(modelo);
                await _context.SaveChangesAsync();
                return true;
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
                return await _context.Modelos.FindAsync(id);
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
                var modelo = await _context.Modelos.FindAsync(id);

                if (modelo == null)
                    return null;

                _context.Modelos.Remove(modelo);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}