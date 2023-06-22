using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_02.Models
{
    public class Colecao
    {
        public const int NomeColecaoMaxLength = 100;
        public const int MarcaMaxLength = 30;
        public const int OrcamentoMaxLength = 21;


        public int Id { get; set; }
        public string NomeColecao { get; set; }
        public int IdResponsavel { get; set; }
        public string Marca { get; set; }
        public double Orcamento { get; set; }
        public DateTime AnoLancamento { get; set; }
        public Estacao Estacao { get; set; }
        public EstadoSistema EstadoSistema { get; set; }
    }
}