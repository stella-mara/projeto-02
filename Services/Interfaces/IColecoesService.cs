using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_02.Services.Interfaces
{
    public interface IColecoesService
    {
        Task<bool?> CreateAsync(PostColecao colecao);
        Task<bool?> UpdateAsync(PutColecao colecao);
        Task<bool?> UpdateStatusAsync(int id, EstadoSistema status);
        Task<List<Usuario?>> GetAllAsync(EstadoSistema? status);
        Task<Usuario?> GetByIdAsync(int id);
    }
}