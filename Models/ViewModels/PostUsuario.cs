using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using projeto_02.Models.Enum;

namespace projeto_02.Models.ViewModels
{
     public class PostUsuario
    {
        [Required(ErrorMessage = "O campo Nome Completo é obrigatório.")]
        [StringLength(Pessoa.NomeMaxLength, ErrorMessage = "O campo Nome Completo deve ter no máximo 100 caracteres.")]
        public string NomeCommpleto { get; set; }

        [Required(ErrorMessage = "O campo Gênero é obrigatório.")]
        [StringLength(Pessoa.GeneroMaxLength, ErrorMessage = "O campo Gênero deve ter no máximo 10 caractere.")]
        public string Genero { get; set; }

        [Required(ErrorMessage = "O campo Data de Nascimento é obrigatório.")]
        public DateTime DataNascimento { get; set; }

        [Required(ErrorMessage = "O campo CPF/CNPJ é obrigatório.")]
        [StringLength(Pessoa.CpfCnpjMaxLength, ErrorMessage = "O campo CPF/CNPJ deve ter no máximo 21 caracteres.")]
        public string CpfCnpj { get; set; }

        [Required(ErrorMessage = "O campo Telefone é obrigatório.")]
        [StringLength(Pessoa.TelefoneMaxLength, ErrorMessage = "O campo Telefone deve ter no máximo 15 caracteres.")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "O campo Email é obrigatório.")]
        [StringLength(Usuario.EmailMaxLength, ErrorMessage = "O campo Email deve ter no máximo 100 caracteres.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O campo Tipo de Usuário é obrigatório.")]
        [EnumDataType(typeof(TipoUsuario), ErrorMessage = "O campo Tipo de Usuário é inválido.")]
        public TipoUsuario TipoUsuario { get; set; }

        [Required(ErrorMessage = "O campo Status é obrigatório.")]
        [EnumDataType(typeof(Status), ErrorMessage = "O campo Status é inválido.")]
        public Status Status { get; set; }
    }
}