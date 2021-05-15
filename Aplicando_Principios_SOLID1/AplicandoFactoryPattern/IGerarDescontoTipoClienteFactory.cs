using Aplicando_Principios_SOLID1.Shared;

namespace Aplicando_Principios_SOLID1.AplicandoFactoryPattern
{
    public interface IGerarDescontoTipoClienteFactory
    {
        IGerarDesconto GetCalculoDescontoTipoConta(TipoContaCliente tipoConta);
    }
}
