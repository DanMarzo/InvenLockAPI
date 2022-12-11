using System.Text.Json.Serialization;

namespace InvenLock.Models
{
    public class FormEmprestimo
    {
        //Atributos para relacionamento
        public int Id { get; set; }
        [JsonIgnore]
        public Funcionario Funcionario { get; set; }
        public int FuncionarioId { get; set; }
        [JsonIgnore]
        public List<EmprestimoEquip> EmprestimoEquip { get; set; }
        //Atributos 
        public DateTime? Devolucao { get; set; }
        public DateTime Emissao { get; set; }
    }
}
