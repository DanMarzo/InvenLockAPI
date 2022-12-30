using InvenLock.Models.Enums;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace InvenLock.Models
{
    public class ManutEquip
    {
        //Atributos para relacionamento
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ManutEquipId { get; set; }
        [JsonIgnore]
        public EstoqueEquipamento EstoqueEquipamento { get; set; }
        public int EstoqueEquipamentoId { get; set; }
        [JsonIgnore]
        public Ocorrencia Ocorrencia { get; set; }
        public DateTime DataEntrada { get; set; }
        public DateTime? DataSaida { get; set; }
        [Column(TypeName = "varchar(250)")]
        public string Desc { get; set; }
        public SituacaoManuEnum Situacao { get; set; }
        
    }
}
