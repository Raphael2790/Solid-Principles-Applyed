namespace Aplicando_Principios_SOLID1.AplicandoFactoryPattern
{
    public class GerarDescontoTipoClienteComum : IGerarDesconto
    {
        public decimal CalcularDescontoTotal(decimal valorAtual)
        {
            return valorAtual;
        }
    }
}
