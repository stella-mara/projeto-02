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
    public class UsuariosRepository : IUsuariosRepository
    {
        private readonly FashionContext _context;

        public UsuariosRepository(FashionContext context)
        {
            _context = context;
        }
        
        public async Task<bool?> CreateAsync(Usuario usuario)
        {
            try
            {
                await _context.Usuarios.AddAsync(usuario);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public async Task<bool?> UpdateAsync(Usuario usuario)
        {
            try
            {
                _context.Usuarios.Update(usuario);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public async Task<bool?> UpdateStatusAsync(int id, Status status)
        {
            try
            {
                var usuario = await GetByIdAsync(id);

                if (usuario == null)
                    return null;

                usuario.Status = status;
                _context.Usuarios.Update(usuario);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public async Task<List<Usuario>> GetAllAsync(Status? status)
        {
            try
            {
                if (status == null)
                    return await _context.Usuarios.ToListAsync();

                return await _context.Usuarios.Where(u => u.Status == status).ToListAsync();
            }
            catch (Exception e)
            {
                return new List<Usuario>();
            }
        }

        public async Task<bool> CheckCpfCnpjAsync(string cpfCnpj)
        {
            try
            {
                return await _context.Usuarios.AnyAsync(u => u.CpfCnpj == cpfCnpj);
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public async Task<Usuario?> GetByIdAsync(int id)
        {
            try
            {
                return await _context.Usuarios.FindAsync(id);
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
                var usuario = await _context.Usuarios.FindAsync(id);

                if (usuario == null)
                    return null;

                _context.Usuarios.Remove(usuario);
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