using Aplicando_Principios_SOLID1.Shared;

namespace Aplicando_Principios_SOLID1.AplicandoFactoryPattern
{
    public class GerarDescontoTipoClienteVIP : IGerarDesconto
    {
        public decimal CalcularDescontoTotal(decimal valorAtual)
        {
            return (valorAtual - (DicionarioDescontos.CLIENTE_VIP * valorAtual));
            
        }
    }
}
