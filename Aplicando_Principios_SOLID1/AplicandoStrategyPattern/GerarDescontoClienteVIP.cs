using Aplicando_Principios_SOLID1.Shared;

namespace Aplicando_Principios_SOLID1.AplicandoStrategyPattern
{
    public class GerarDescontoClienteVIP : IGerarDesconto
    {
        public decimal CalcularDescontoTipoCliente(decimal precoProduto)
        {
            return (precoProduto - (DicionarioDescontos.CLIENTE_VIP * precoProduto));
        }
    }
}
