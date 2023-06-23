using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using projeto_02.Models;
using projeto_02.Models.Enum;

namespace projeto_02.Database.Repositories.Interfaces
{
    public interface IModelosRepository
    {
        Task<bool?> CreateAsync(Modelo modelo);
        Task<bool?> UpdateAsync(Modelo modelo);
        Task<bool> CheckNomeModeloAsync(string nomeModelo);
        Task<Modelo?> GetByIdAsync(int id);
        Task<bool?> DeleteAsync(int id);
    }
}