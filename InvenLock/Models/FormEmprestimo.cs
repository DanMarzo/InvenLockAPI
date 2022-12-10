namespace InvenLock.Models
{
    public class FormEmprestimo
    {
        //Atributos para relacionamento
        public int Id { get; set; }
        public List<EmprestimoEquip> EmprestimoEquip { get; set; }
        public int FuncionarioId { get; set; }
        public Funcionario Funcionario { get; set; }
        //Atributos 
        public InfraFuncionario InfraFuncionario { get; set; }
        public int InfraFuncionarioId { get; set; }
    }
}
