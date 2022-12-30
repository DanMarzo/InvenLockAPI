using InvenLock.Models.Enums;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace InvenLock.Models
{
    public class EstoqueEquipamento
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EstoqueEquipamentoId { get; set; }
        public List<FormEmprestimo> FormEmprestimo { get; set; } = new List<FormEmprestimo>();
        //Atributos
        public TipoEquipEnum Tipo { get; set; }
        public SituacaoEquipEnum Situacao { get; set; }




        [Column(TypeName = "varchar(250)")]
        public string? Descricao { get; set; }
        [Column(TypeName = "varchar(20)")]
        public string? NomeEquip { get; set; }
        public FabEnum Fabricante { get; set; }
        public DateTime DataCompra { get; set; }
        public DateTime? DataFimEquip { get; set; }
    }
}
