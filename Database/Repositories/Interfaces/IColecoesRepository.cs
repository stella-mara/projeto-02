using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using projeto_02.Models;
using projeto_02.Models.Enum;

namespace projeto_02.Database.Repositories.Interfaces
{
    public interface IColecoesRepository
    {
        Task<bool?> CreateAsync(Colecao colecao);
        Task<bool?> UpdateAsync(Colecao colecao);
        Task<bool?> UpdateStatusAsync(int id, EstadoSistema estadoSistema);
        Task<List<Usuario>> GetAllAsync(EstadoSistema? estadoSistema);
        Task<bool> CheckNomeColecaoAsync(string nomeColecao);
        Task<Usuario?> GetByIdAsync(int id);
        Task<bool?> DeleteAsync(int id);
    }
}