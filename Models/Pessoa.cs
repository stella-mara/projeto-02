using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_02.Models
{
    public class Pessoa
    {
        public const int NomeMaxLength = 100;
        public const int GeneroMaxLength = 10;
        public const int CpfCnpjMaxLength = 21;
        public const int TelefoneMaxLength = 15;
        public int Id { get; set; }
        public string NomeCommpleto { get; set; }
        public string Genero { get; set; }
        public DateTime DataNascimento { get; set; }
        public string CpfCnpj { get; set; }
        public string Telefone { get; set; }
    }
}