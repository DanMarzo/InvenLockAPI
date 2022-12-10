using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace InvenLock.Models
{
    public class SucataEquip
    {
        //Atributos para relacionamento
        public int Id { get; set; }
        public EstoqueEquipamento EstoqueEquipamento { get; set; }
        public int EstoqueEquipamentoId { get; set; }
        //Atributos
        [Column(TypeName = "varchar(250)")]
        public string DsOcorrido { get; set; }
        public DateTime DataEntrada { get; set; }
    }
}
