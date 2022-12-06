using InvenLock.Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InvenLock.Models
{
    public class EquipManut
    {
        public int                Id           { get; set; }
        public List<EstoqueEquip> EstoqueEquip { get; set; }
        public int                IdOcorrencia { get; set; }
        public Ocorrencia         Ocorrencia   { get; set; }
        public DateTime           DataEntrada  { get; set; }
        public DateTime?          DataSaida    { get; set; }
        [Column(TypeName = "varchar(250)")]
        public string             Desc         { get; set; }
        public StatusManuEnum     Status       { get; set; }
    }
}
