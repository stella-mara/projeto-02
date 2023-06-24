using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using projeto_02.Models.Enum;

namespace projeto_02.Models.ViewModels
{
  public class PutModelo
  {
    [IgnoreDataMember]
    public int Id { get; set; }

    [Required(ErrorMessage = "O campo Nome do Modelo é obrigatório.")]
    public string NomeModelo { get; set; }

    [IgnoreDataMember]
    public int IdColecaoRelacionada { get; set; }

    [Required(ErrorMessage = "O campo Tipo é obrigatório.")]
    [EnumDataType(typeof(Tipo), ErrorMessage = "O campo Tipo é inválido.")]
    public Tipo Tipo { get; set; }

    [Required(ErrorMessage = "O campo Layout é obrigatório.")]
    [EnumDataType(typeof(Layout), ErrorMessage = "O campo Layout é inválido.")]
    public Layout Layout { get; set; }
  }
}