using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using projeto_02.Models.Enum;

namespace projeto_02.Models.ViewModels
{
     public class PostColecao
    {
        [Required(ErrorMessage = "O campo Nome da Coleção é obrigatório.")]
        public string NomeColecao { get; set; }

        [Required(ErrorMessage = "O campo Id do Responsável é obrigatório.")]
        public int IdResponsavel { get; set; }

        [Required(ErrorMessage = "O campo Marca é obrigatório.")]
        public string Marca { get; set; }

        [Required(ErrorMessage = "O campo Orçamento é obrigatório.")]
        public double Orcamento { get; set; }

        [Required(ErrorMessage = "O campo Ano de Lançamento é obrigatório.")]
        public DateTime AnoLancamento { get; set; }

        [Required(ErrorMessage = "O campo Estação é obrigatório.")]
        public Estacao Estacao { get; set; }

        [Required(ErrorMessage = "O campo Estado do Sistema é obrigatório.")]
        public EstadoSistema EstadoSistema { get; set; }
    }
}