using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
﻿using Microsoft.EntityFrameworkCore;
using projeto_02.Database.Repositories.Interfaces;
using projeto_02.Models;
using projeto_02.Models.Enum;

namespace projeto_02.Database.Repositories
{
    public class ColecoesRepository : IColecoesRepository
    {
        private readonly FashionContext _context;

        public ColecoesRepository(FashionContext context)
        {
            _context = context;
        }
        
        public async Task<bool?> CreateAsync(Colecao colecao)
        {
            try
            {
                await _context.Colecoes.AddAsync(colecao);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public async Task<bool?> UpdateAsync(Colecao colecao)
        {
            try
            {
                _context.Colecoes.Update(colecao);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public async Task<bool?> UpdateEstadoSistemasAsync(int id, EstadoSistema estadoSistema)
        {
            try
            {
                var colecao = await GetByIdAsync(id);

                if (colecao == null)
                    return null;

                colecao.EstadoSistema = estadoSistema;
                _context.Colecoes.Update(colecao);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public async Task<List<Colecao>> GetAllAsync(EstadoSistema? estadoSistema)
        {
            try
            {
                if (estadoSistema == null)
                    return await _context.Colecoes.ToListAsync();

                return await _context.Colecoes.Where(u => u.EstadoSistema == estadoSistema).ToListAsync();
            }
            catch (Exception e)
            {
                return new List<Colecoes>();
            }
        }

        public async Task<bool> CheckNomeColecaoAsync(string NomeColecao)
        {
            try
            {
                return await _context.Colecoes.AnyAsync(u => u.NomeColecao == NomeColecao);
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public async Task<Colecao?> GetByIdAsync(int id)
        {
            try
            {
                return await _context.Colecoes.FindAsync(id);
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
                var colecao = await _context.Colecoes.FindAsync(id);

                if (colecao == null)
                    return null;

                _context.Colecoes.Remove(colecao);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

    public Task<bool?> UpdateStatusAsync(int id, EstadoSistema estadoSistema)
    {
      throw new NotImplementedException();
    }

    Task<List<Usuario>> IColecoesRepository.GetAllAsync(EstadoSistema? estadoSistema)
    {
      throw new NotImplementedException();
    }

    Task<Usuario?> IColecoesRepository.GetByIdAsync(int id)
    {
      throw new NotImplementedException();
    }
  }
}