using InvenLock.Models.Enuns;
using System.ComponentModel.DataAnnotations;

namespace InvenLock.Models
{
    public class Equipamento
    {
        public int            Id              { get; set; }
        public string         NomeEquip       { get; set; }
        public FabricanteEnum Fabricante      { get; set; }
        public TipoEquipEnum  TipoEquipamento { get; set; }
        public string         Descricao       { get; set; }
        public StatusEnum     SituacaoEquip   { get; set; }
        public DateTime       DataCompra      { get; set; }
        public DateTime?      DataFimEquip    { get; set; }
        public string         Observacao      { get; set; }
    }
}
