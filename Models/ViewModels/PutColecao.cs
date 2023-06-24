using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using projeto_02.Models.Enum;

namespace projeto_02.Models.ViewModels
{
  public class PutColecao
  {
    [IgnoreDataMember]
    public int Id { get; set; }

    [Required(ErrorMessage = "O campo Nome da Coleção é obrigatório.")]
    public string NomeColecao { get; set; }

    [IgnoreDataMember]
    public int IdResponsavel { get; set; }

    [Required(ErrorMessage = "O campo Marca é obrigatório.")]
    public string Marca { get; set; }

    [Required(ErrorMessage = "O campo Orçamento é obrigatório.")]
    public double Orcamento { get; set; }

    [Required(ErrorMessage = "O campo Ano de Lançamento é obrigatório.")]
    public DateTime AnoLancamento { get; set; }

    [Required(ErrorMessage = "O campo Estação é obrigatório.")]
    [EnumDataType(typeof(Estacao), ErrorMessage = "O campo Estação é inválido.")]
    public Estacao Estacao { get; set; }
  }
}