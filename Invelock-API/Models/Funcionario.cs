using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Invelock_API.Models
{
    public class Funcionario
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int? FuncionarioId { get; set; }

        [Required(ErrorMessage = "O primeiro nome é obrigatorio")]
        [Display(Name = "Primeiro Nome")]
        [Column(TypeName ="varchar(15)")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O sobrenome é obrigatório")]
        [Display(Name = "Sobrenome")]
        [Column(TypeName = "varchar(20)")]
        public string Sobrenome { get; set; }

        [Required(ErrorMessage = "O CPF é obrigatório!")]
        [Column(TypeName = "varchar(11)")]
        public string Cpf { get; set; }

        [Column(TypeName = "date")]
        [Display(Name = "Data de admissão")]
        public DateTime? Admissao { get; set; }

        [Column(TypeName = "date")]
        [Display(Name = "Data de demissão")]
        public DateTime? Demissao { get; set; }

        [Required(ErrorMessage ="A data de nascimento é obrigatória")]
        [Column(TypeName = "date")]
        public DateTime Nascimento { get; set; }


    }
}
