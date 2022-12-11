using InvenLock.Models.Enums;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace InvenLock.Models
{
    public class Funcionario
    {
        //Atributos para relacionamento
        public int Id { get; set; }
        public List<FormEmprestimo> FormEmprestimo { get; set; }
        [JsonIgnore]
        public FuncionarioContato FuncionarioContato { get; set; }
        [JsonIgnore]
        //public InfraFuncionario InfraFuncionario { get; set; }
        public List<Ocorrencia> Ocorrencia { get; set; }
        //Atributos
        [Column(TypeName = "varchar(20)")]
        public string Nome { get; set; }
        public DateTime Admissao { get; set; }
        public DateTime? Demissao { get; set; }
        [Column(TypeName = "char(11)")]
        public string Cpf { get; set; }
        public SituacaoFuncEnum Situacao { get; set; }
        public byte[] PasswordSalt { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] FotoFuncionario { get; set;  }
        [NotMapped]
        public string PasswordString { get; set; }
    }
}
