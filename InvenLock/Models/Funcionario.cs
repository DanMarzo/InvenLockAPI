using System.ComponentModel.DataAnnotations.Schema;

namespace InvenLock.Models
{
    public class Funcionario
    {
        public int                IdFunc          { get; set; }
        public string             Nome            { get; set; }
        public string             SobreNome       { get; set; }
        public int                TelefoneCelular { get; set; }
        public ContatoFuncionario Contatos        { get; set; }
        public byte[]             PasswordHash    { get; set; }
        public byte[]             PasswordSalt    { get; set; }
        [NotMapped]
        public string             PasswordString  { get; set; }
    }
}
