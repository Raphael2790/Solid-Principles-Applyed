using Aplicando_Principios_SOLID1.Shared;

namespace Aplicando_Principios_SOLID1.AplicandoFactoryPattern
{
    public class GerarDescontoTipoClienteDiferenciado : IGerarDesconto
    {
        public decimal CalcularDescontoTotal(decimal valorAtual)
        {
            return (valorAtual - (DicionarioDescontos.CLIENTE_DIFERENCIADO * valorAtual));
        }
    }
}
