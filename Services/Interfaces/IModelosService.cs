using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using projeto_02.Models;
using projeto_02.Models.Enum;
using projeto_02.Models.ViewModels;

namespace projeto_02.Services.Interfaces
{
    public interface IModelosService
    {
        Task<bool?> CreateAsync(PostModelo modelo);
        Task<bool?> UpdateAsync(PutModelo modelo);
        Task<Modelo?> GetByIdAsync(int id);
    }
}