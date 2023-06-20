using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using projeto_02.Models.ViewModels;

namespace projeto_02.Services.Interfaces
{
    public class IUsuariosService
    {
        Task<bool?> CreateAsync(PostUsuario usuario);

    }
}