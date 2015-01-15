using SGCore.Utils;

namespace SGEntidades.Enum
{
    public enum SituacaoAgenda
    {
        [EnumDescription("Aberta")]
        [EnumValue("A")]
        Aberta,
        [EnumDescription("Cancelada")]
        [EnumValue("C")]
        Cancelada,
        [EnumDescription("Finalizada")]
        [EnumValue("F")]
        Finalizada,
    }
}