using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace InvenLock.Models
{
    public class Ocorrencia
    {
        //Atributos para relacionamento
        public int Id { get; set; }
        [JsonIgnore]
        public ManutEquip ManutEquip { get; set; }
        [JsonIgnore]
        public Funcionario Funcionario { get; set; }
        public int FuncionarioId { get; set; }
        //Atributos
        [Column(TypeName = "varchar(250)")]
        public string DescOcorrencia { get; set; }
        public DateTime DataOcorrencia { get; set; }

    }
}
