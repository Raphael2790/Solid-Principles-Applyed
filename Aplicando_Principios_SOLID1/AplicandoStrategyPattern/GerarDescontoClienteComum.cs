namespace Aplicando_Principios_SOLID1.AplicandoStrategyPattern
{
    public class GerarDescontoClienteComum : IGerarDesconto
    {
        public decimal CalcularDescontoTipoCliente(decimal precoProduto)
        {
            return precoProduto;
        }
    }
}
