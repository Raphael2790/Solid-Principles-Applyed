using Aplicando_Principios_SOLID1.Exercicio1Resolvido.Enums;

namespace Aplicando_Principios_SOLID1.Exercicio1Resolvido.Interfaces
{
    public interface IGeradorRelatoriosFactory
    {
        IGeradorRelatorios GetTipoRelatorio(TiposRelatorio tipoRelatorio);
    }
}
