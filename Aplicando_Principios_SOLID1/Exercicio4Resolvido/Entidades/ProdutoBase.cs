using Aplicando_Principios_SOLID1.Exerciocio4Resolvido.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aplicando_Principios_SOLID1.Exerciocio4Resolvido.Entidades
{
    public abstract class ProdutoBase
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        protected IPromocao _promocao;
        public ProdutoBase(IPromocao promocao)
        {
            _promocao = promocao;
        }

        public decimal DescontoPromocao()
        {
            return _promocao.Desconto();
        }

        public decimal PrecoVenda()
        {
            return Preco - (Preco * DescontoPromocao());
        }
    }
}
