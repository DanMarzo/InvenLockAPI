using System.Text.Json.Serialization;

namespace InvenLock.Models
{
    public class Ocorrencia
    {
        //Atributos para relacionamento
        public int Id { get; set; }
        [JsonIgnore]
        public ManutEquip ManutEquip { get; set; }
    }
}
