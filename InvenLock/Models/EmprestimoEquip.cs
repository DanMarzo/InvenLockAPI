namespace InvenLock.Models
{
    public class EmprestimoEquip
    {
        //Atributos para relacionamento
        public int Id { get; set; }
        public EstoqueEquipamento EstoqueEquipamento { get; set; }
        public int EstoqueEquipamentoId { get; set; }
        public FormEmprestimo FormEmprestimo { get; set; }
        public int FormEmprestimoId { get; set; }
        //atributos
        public DateTime DataEmprestimo { get; set; }
        public DateTime? DataDevolucao { get; set; }
    }
}
