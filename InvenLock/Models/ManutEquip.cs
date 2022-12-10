using InvenLock.Models.Enums;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace InvenLock.Models
{
    public class ManutEquip
    {
        //Atributos para relacionamento
        public int Id { get; set; }
        public EstoqueEquipamento EstoqueEquipamento { get; set; }
        public int EstoqueEquipamentoId { get; set; }
        public Ocorrencia Ocorrencia { get; set; }
        public int OcorrenciaId { get; set; }
        //atributos
        public DateTime DataEntrada { get; set; }
        public DateTime? DataSaida { get; set; }
        [Column(TypeName = "varchar(250)")]
        public string Desc { get; set; }
        public StatusManuEnum Status { get; set; }
    }
}
