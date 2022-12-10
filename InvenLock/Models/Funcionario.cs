using System.Text.Json.Serialization;

namespace InvenLock.Models
{
    public class Funcionario
    {
        public int Id { get; set; }
        public ICollection<FormEmprestimo> FormEmprestimo { get; set; }
        [JsonIgnore]
        public FuncionarioContato FuncionarioContato { get; set; }
        [JsonIgnore]
        public InfraFuncionario InfraFuncionario { get; set; }
    }
}
