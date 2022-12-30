using InvenLock.Models.Enums;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace InvenLock.Models
{
    public class Ocorrencia
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OcorrenciaId { get; set; }
        [JsonIgnore]
        public ManutEquip ManutEquip { get; set; }
        public int? ManutEquipId { get; set; }
        [JsonIgnore] 
        public Funcionario Funcionario { get; set; }
        public int FuncionarioId { get; set; }
        public int IdEquipamento { get; set; }
        [Column(TypeName = "varchar(250)")]
        public string DescOcorrencia { get; set; }
        public DateTime DataOcorrencia { get; set; }
        public SituacaoFuncOcoEnum Situacao { get; set; }
    }
}
