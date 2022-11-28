namespace InvenLock.Models.Enuns
{
    public enum StatusEnum
    {
        Disponivel   = 1, //pronto para usar
        Indisponivel = 2, //incoveniente (perda total ou roubo)
        Emprestado   = 3, //Se encontra em uso
        Manutenção   = 4, //O aparelho esta em manutenção
        Sucata       = 5
    }
}
