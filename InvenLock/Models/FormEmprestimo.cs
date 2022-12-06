namespace InvenLock.Models
{
    public class FormEmprestimo
    {
        public int                   Id                { get; set; }
        public int                   IdEquipEmprestimo { get; set; }
        public List<EquipEmprestimo> EquipEmprestimo   { get; set; }
        public int                   IdFunc            { get; set; }
        public Funcionario           Funcionario       { get; set; }
        public int                   IdTecnico         { get; set; }
        public FuncInfra             FuncInfra         { get; set; }
        public DateTime?             Devolucao         { get; set; }
        public DateTime              Emissao           { get; set; }

    }
}
