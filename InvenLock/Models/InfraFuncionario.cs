using System.Text.Json.Serialization;

namespace InvenLock.Models
{
    public class InfraFuncionario
    {
        public int Id { get; set; }
        public Funcionario Funcionario { get; set; }
        public int FuncionarioId { get; set; }
        [JsonIgnore]
        public FormEmprestimo FormEmprestimo { get; set; }
    }
}
