namespace Aplicando_Principios_SOLID1.Shared
{
    public class CalcularDescontoFidelidade : ICalculaDescontoFidelidade
    {
        public decimal AplicarDescontoFidelidade(decimal precoProduto, int anosFidelidade)
        {
            decimal descontoPorFidelidade = (anosFidelidade > DicionarioDescontos.MAXIMO_POR_FIDELIDADE) 
                ? (decimal)DicionarioDescontos.MAXIMO_POR_FIDELIDADE / 100 : (decimal)anosFidelidade / 100;

            return precoProduto - (descontoPorFidelidade * precoProduto);
        }
    }
}
