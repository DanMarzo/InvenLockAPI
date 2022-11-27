namespace InvenLock.Models.Enuns
{
    public enum StatusEnum
    {
        Disponivel   = 1, //pronto para usar
        Indisponivel = 2, //nao esta mais disponivel para usar
        Emprestado   = 3, //Se encontra em uso
        Manutenção   = 4, //O aparelho esta em manutenção
    }
}
