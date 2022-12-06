using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InvenLock.Models
{
    public class ContatoFunc
    {
        [Key]
        public int         Id               { get; set; }
        public Funcionario Funcionario      { get; set; }
        [Column(TypeName = "char(11)")]
        public string      CelPessoal       { get; set; }
        [Column(TypeName = "char(4)")]
        public string      RamalCorporativo { get; set; }
        [Column(TypeName = "varchar(70)")]
        public string      EmailPessoal     { get; set; }
        [Column(TypeName = "varchar(70)")]
        public string      EmailCorporativo { get; set; }
    }
}
