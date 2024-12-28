using System.ComponentModel;

namespace keisarmindproject.Enums
{
    public enum StatusTarefa
    {
        [Description(" Em progresso ")]
        EmProgresso = 1,
        [Description(" Agendado ")]
        Agendado = 2,
        [Description(" Delegado ")]
        Delegado = 3,
        [Description(" Feito ")]
        Feito = 4,
        [Description(" Arquivado ")]
        Arquivado = 5
    }
}
