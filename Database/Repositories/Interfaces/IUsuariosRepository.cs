using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using projeto_02.Models;
using projeto_02.Models.Enum;

namespace projeto_02.Database.Repositories.Interfaces
{
    public interface IUsuariosRepository
    {
        Task<bool?> CreateAsync(Usuario usuario);
        Task<bool?> UpdateAsync(Usuario usuario);
        Task<bool?> UpdateStatusAsync(int id, Status status);
        Task<List<Usuario>> GetAllAsync(Status? status);
        Task<bool> CheckCpfCnpjAsync(string cpfCnpj);
        Task<Usuario?> GetByIdAsync(int id);
        Task<bool?> DeleteAsync(int id);
    }
}