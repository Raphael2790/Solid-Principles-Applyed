namespace Aplicando_Principios_SOLID1.Shared
{
    public interface ICalculaDescontoFidelidade
    {
        decimal AplicarDescontoFidelidade(decimal precoProduto, int anosFidelidade);
    }
}
