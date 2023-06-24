using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using projeto_02.Models;
using projeto_02.Models.Enum;
using projeto_02.Models.ViewModels;

namespace projeto_02.Services.Interfaces
{
  public interface IColecoesService
  {
    Task<bool?> CreateAsync(PostColecao colecao);
    Task<bool?> UpdateAsync(PutColecao colecao);
    Task<bool?> UpdateStatusAsync(int id, EstadoSistema estadoSistema);
    Task<List<Colecao?>> GetAllAsync(EstadoSistema? estadoSistema);
    Task<Colecao?> GetByIdAsync(int id);
  }
}