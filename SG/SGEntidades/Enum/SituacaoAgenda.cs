using SGCore.Utils;

namespace SGEntidades.Enum
{
    public enum SituacaoAgenda
    {
        [EnumDescription("Aberta")]
        [EnumValue("a")]
        Aberta,
        [EnumDescription("Cancelada")]
        [EnumValue("C")]
        Cancelada,
        [EnumDescription("Finalizada")]
        [EnumValue("F")]
        Finalizada,
    }
}