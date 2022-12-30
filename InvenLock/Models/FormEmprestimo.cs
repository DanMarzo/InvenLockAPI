using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace InvenLock.Models
{
    public class FormEmprestimo
    {
        //Atributos para relacionamento
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FormEmprestimoId { get; set; }
        [JsonIgnore]
        public Funcionario Funcionario { get; set; }
        public int FuncionarioId { get; set; }
        [JsonIgnore]
        public EstoqueEquipamento EstoqueEquipamento { get; set; }
        public int EstoqueEquipamentoId { get; set; }
        //Atributos 
        public DateTime? Devolucao { get; set; }
        public DateTime? Emissao { get; set; }
    }
}
