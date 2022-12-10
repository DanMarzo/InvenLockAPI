using InvenLock.Models.Enums;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace InvenLock.Models
{
    public class EstoqueEquipamento
    {
        public int Id { get; set; }
        [JsonIgnore]
        public EmprestimoEquip EmprestimoEquip { get; set; }
        [JsonIgnore]
        public SucataEquip SucataEquip { get; set; }
        [JsonIgnore]
        public ManutEquip ManutEquip { get; set; }

        //Atributos
        public TipoEquipEnum Tipo { get; set; }
        public StatusEquipEnum Situacao { get; set; }
        [Column(TypeName = "varchar(250)")]
        public string? Descricao { get; set; }
        [Column(TypeName = "varchar(20)")]
        public string? NomeEquip { get; set; }
        public FabEnum Fabricante { get; set; }
        public DateTime DataCompra { get; set; }
        public DateTime? DataFimEquip { get; set; }
    }
}
