using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using projeto_02.Models.Enum;
using projeto_02.Models.ViewModels;
using projeto_02.Services.Interfaces;

namespace projeto_02.Services
{
  public class UsuariosService : IUsuariosService
  {
    public Task<bool?> CreateAsync(PostUsuario usuario)
    {
      throw new NotImplementedException();
    }

    public Task<bool?> UpdateAsync(PutUsuario usuario)
    {
      throw new NotImplementedException();
    }

    public Task<bool?> UpdateStatusAsync(int id, Status status)
    {
      throw new NotImplementedException();
    }
  }
}