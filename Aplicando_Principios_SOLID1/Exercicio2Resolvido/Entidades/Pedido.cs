using System;
using System.Collections.Generic;
using System.Text;

namespace CursoFoop_Solid_Exercicio2
{
    public class Pedido
    {
        public int PedidoId { get; set; }
        public int ClientId { get; set; }
        public int EnderecoEntregaId { get; set; }
        public decimal ValorTotalPedido { get; set; }
        public string StatusPedido { get; set; }
        public DateTime DataCriacaoPedido { get; set; }
        public DateTime DataEntregaPedido { get; set; }
    }
}
