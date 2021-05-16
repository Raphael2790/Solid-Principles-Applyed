using System;

namespace CursoFoop_Solid_Exercicio2
{
    public class PedidoService
    {
        private readonly ILogger _log;
        private readonly IRepositorioPedido _repositorioPedido;

        public PedidoService(ILogger logger, IRepositorioPedido repositorioPedido)
        {
            _log = logger;
            _repositorioPedido = repositorioPedido;
        }
        public void AdicionarPedido(Pedido pedido)
        {
            try
            {
                //código para validar e incluir pedido
                _repositorioPedido.CadastrarPedido(pedido);
                _log.RegistrarLog($"Pedido Incluido em :  {DateTime.Now}");
            }
            catch (Exception ex)
            {
                _log.RegistrarLog($"{ex} - {DateTime.Now}");
            }
        }
    }
}
