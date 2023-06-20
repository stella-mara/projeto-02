using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using projeto_02.Models.Enum;

namespace projeto_02.Models
{
    public class Usuario : Pessoa
    {
        public const int EmailMaxLength = 100;

        public string Email { get; set; }
        public TipoUsuario TipoUsuario { get; set; }
        public Status Status { get; set; }
    }
}