using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace InvenLock.Models
{
    public class Ocorrencia
    {
        public int              Id             { get; set; }
        public int              IdFunc         { get; set; }
        public Funcionario      Funcionario    { get; set; }
        [Column(TypeName = "varchar(250)")]
        public string           DescOcorrencia { get; set; }
        public DateTime         DataOcorrencia { get; set; }
        public int              IdEquip        { get; set; }
        public List<EquipManut> EquipManutencao { get; set; }
    }
}