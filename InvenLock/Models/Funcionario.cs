using InvenLock.Models.Enums;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace InvenLock.Models
{
    public class Funcionario
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        //Atributos para relacionamento
        public int FuncionarioId { get; set; }
        [JsonIgnore]
        public List<FormEmprestimo> FormEmprestimo { get; set; }
        [JsonIgnore]
        public List<Ocorrencia> Ocorrencia { get; set; }
        //Atributos
        [Column(TypeName = "varchar(20)")]
        public string Nome { get; set; }
        public DateTime Admissao { get; set; }
        public DateTime? Demissao { get; set; }
        [Column(TypeName = "char(11)")]
        public string Cpf { get; set; }
        public SituacaoFuncOcoEnum Situacao { get; set; }
        public byte[] PasswordSalt { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] FotoFuncionario { get; set; }
        [NotMapped]
        public string PasswordString { get; set; }
        [Column(TypeName ="char(11)")]
        public string CelPessoal { get; set; }
        [Column(TypeName = "char(4)")]
        public string Ramal { get; set; }
        [Column(TypeName = "varchar(70)")]
        public string EmailCorp { get; set; }

        [Column(TypeName = "varchar(70)")]
        public string EmailPessoal { get; set; }
    }
}
