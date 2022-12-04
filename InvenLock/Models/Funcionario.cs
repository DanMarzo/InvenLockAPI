using InvenLock.Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InvenLock.Models
{
    public class Funcionario
    {
        [Key]
        public int              IdFunc         { get; set; }
        [Column(TypeName = "varchar(20)")]
        public string           Nome           { get; set; }
        [Column(TypeName = "varchar(20)")]
        public string           SobreNome      { get; set; }
        public DateTime         Admissao       { get; set; }
        public DateTime?        Demissao       { get; set; }
        [Column(TypeName ="char(11)")]
        public string           Cpf            { get; set; }
        public SituacaoFuncEnum Situacao       { get; set; }
        public byte[]           PasswordSalt   { get; set; }
        public byte[]           PasswordHash   { get; set; }
        [NotMapped]
        public string           PasswordString { get; set; }
    }
}
