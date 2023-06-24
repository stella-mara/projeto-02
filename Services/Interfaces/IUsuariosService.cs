using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using projeto_02.Models;
using projeto_02.Models.Enum;
using projeto_02.Models.ViewModels;

namespace projeto_02.Services.Interfaces
{
  public interface IUsuariosService
  {
    Task<bool?> CreateAsync(PostUsuario usuario);
    Task<bool?> UpdateAsync(PutUsuario usuario);
    Task<bool?> UpdateStatusAsync(int id, Status status);
    Task<List<Usuario?>> GetAllAsync(Status? status);
    Task<Usuario?> GetByIdAsync(int id);

  }
}