using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Invelock_API.Models
{
    public class Funcionario
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FuncionarioId { get; set; }

        [Required(ErrorMessage = "O primeiro nome é obrigatorio")]
        [Display(Name = "Primeiro Nome")]
        public int Nome { get; set; }
        public int Sobrenome { get; set; }
    }
}
