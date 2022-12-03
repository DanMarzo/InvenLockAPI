using InvenLock.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace InvenLock.Models
{
    public class EstoqueEquip
    {
        [Key]
        public int             IdEquipamento { get; set; }  
        public TipoEquipEnum   Tipo          { get; set; }
        public StatusEquipEnum Situacao      { get; set; }
        public string?         Descricao     { get; set; }
        public string?         NomeEquip     { get; set; }
        public FabEnum         Fabricante    { get; set; }
        public DateTime        DataCompra    { get; set; }
        public DateTime?       DataFimEquip  { get; set; }

    }
}
