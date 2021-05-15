using Aplicando_Principios_SOLID1.Shared;
using System;

namespace Aplicando_Principios_SOLID1.AplicandoFactoryPattern
{
    public class GerarDescontoTipoClienteFactory : IGerarDescontoTipoClienteFactory
    {
        public IGerarDesconto GetCalculoDescontoTipoConta(TipoContaCliente tipoConta)
        {
            IGerarDesconto calcular;

            switch (tipoConta)
            {
                case TipoContaCliente.Comum:
                    calcular = new GerarDescontoTipoClienteComum();
                    break;
                case TipoContaCliente.Diferenciado:
                    calcular = new GerarDescontoTipoClienteDiferenciado();
                    break;
                case TipoContaCliente.Especial:
                    calcular = new GerarDescontoTipoClienteEspecial();
                    break;
                case TipoContaCliente.VIP:
                    calcular = new GerarDescontoTipoClienteVIP();
                    break;
                default:
                    throw new NotImplementedException();
            }

            return calcular;
        }
    }
}
