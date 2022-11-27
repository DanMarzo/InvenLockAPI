using InvenLock.Models.Enuns;
using System.ComponentModel.DataAnnotations;

namespace InvenLock.Models
{
    public class Equipamento
    {
        [Key]
        public int            Codigo          { get; set; }
        public string         NomeEquip       { get; set; }
        public FabricanteEnum Fabricante      { get; set; }
        public TipoEquipEnum  TipoEquipamento { get; set; }
        public string         Descricao       { get; set; }
        public StatusEnum     SituacaoEquip   { get; set; }
        public DateTime       DataCompra      { get; set; }
        public DateTime?      DataFimEquip    { get; set; }
    }
}
