using Aplicando_Principios_SOLID1.Shared;

namespace Aplicando_Principios_SOLID1.AplicandoFactoryPattern
{
    public class GerenciadorDescontosSOLID
    {
        private readonly ICalculaDescontoFidelidade _calculaDescontoFidelidade;
        private readonly IGerarDescontoTipoClienteFactory _gerarDescontoFactory;
        public GerenciadorDescontosSOLID(ICalculaDescontoFidelidade calculaDescontoFidelidade, IGerarDescontoTipoClienteFactory gerarDescontoFactory)
        {
            _calculaDescontoFidelidade = calculaDescontoFidelidade;
            _gerarDescontoFactory = gerarDescontoFactory;
        }

        public decimal AplicarDesconto(decimal valorProduto, TipoContaCliente tipoConta, int anosFidelidade)
        {
            decimal precoComDesconto = 0;

            precoComDesconto = _gerarDescontoFactory.GetCalculoDescontoTipoConta(tipoConta).CalcularDescontoTotal(valorProduto);
            precoComDesconto = _calculaDescontoFidelidade.AplicarDescontoFidelidade(precoComDesconto, anosFidelidade);
                 
            return precoComDesconto;

        }
    }
}
