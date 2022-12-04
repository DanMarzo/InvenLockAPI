using System.ComponentModel.DataAnnotations;

namespace InvenLock.Models
{
    public class EquipEmprestimo
    {
        [Key]
        [Required]
        public int                IdEquipEmprestimo { get; set; }
        public List<EstoqueEquip> EstoqueEquip      { get; set; }
        public int                IdForm            { get; set; }
        public FormEmprestimo     FormEmprestimo    { set; get; }
        public DateTime           DataEmprestimo    { get; set; }
        public DateTime?          DataDevolucao     { get; set; }

    }
}
