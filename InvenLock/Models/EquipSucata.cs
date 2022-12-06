using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace InvenLock.Models
{
    public class EquipSucata
    {
        public int                Id           { get; set; }
        public List<EstoqueEquip> EstoqueEquip { get; set; }
        [Column(TypeName = "varchar(250)")]
        public string             DsOcorrido   { get; set; }
        public DateTime           DataEntrada  { get; set; }

    }
}
