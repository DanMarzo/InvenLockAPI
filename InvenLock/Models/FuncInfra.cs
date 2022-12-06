using InvenLock.Models.Enums;

namespace InvenLock.Models
{
    public class FuncInfra
    {
        public int           Id          { get; set; }
        public int           IdFunc      { get; set; }
        public Funcionario   Funcionario { get; set; }
        public FuncInfraEnum TipoFunc    { get; set; }
    }
}