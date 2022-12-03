using InvenLock.Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InvenLock.Models
{
    public class EstoqueEquip
    {
        [Key]
        public int             IdEquipamento { get; set; }
        [Required]
        public TipoEquipEnum   Tipo          { get; set; }
        [Required]
        public StatusEquipEnum Situacao      { get; set; }
        [Column(TypeName = "varchar(250)")]
        public string?         Descricao     { get; set; }
        [Column(TypeName = "varchar(20)")]
        public string?         NomeEquip     { get; set; }
        [Required]
        public FabEnum         Fabricante    { get; set; }
        public DateTime        DataCompra    { get; set; }
        public DateTime?       DataFimEquip  { get; set; }

    }
}
