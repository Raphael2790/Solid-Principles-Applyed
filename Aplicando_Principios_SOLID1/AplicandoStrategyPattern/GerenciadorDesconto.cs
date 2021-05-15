using Aplicando_Principios_SOLID1.Shared;


namespace Aplicando_Principios_SOLID1.AplicandoStrategyPattern
{
    public class GerenciadorDesconto
    {
        private readonly ICalculaDescontoFidelidade _calculaDescontoFidelidade;

        public GerenciadorDesconto(ICalculaDescontoFidelidade calculaDescontoFidelidade)
        {
            _calculaDescontoFidelidade = calculaDescontoFidelidade;
        }

        public decimal CalcularValorComDesconto(IGerarDesconto desconto, decimal valorProduto, int anosFidelidade)
        {
            decimal precoComDesconto = _calculaDescontoFidelidade.AplicarDescontoFidelidade(valorProduto, anosFidelidade);
            precoComDesconto = desconto.CalcularDescontoTipoCliente(precoComDesconto);
            return precoComDesconto;
        }
    }
}
