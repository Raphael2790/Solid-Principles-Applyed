using Aplicando_Principios_SOLID1.Exerciocio4Resolvido.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aplicando_Principios_SOLID1.Exerciocio4Resolvido.Entidades
{
    public class Celular : ProdutoBase
    {
        public Celular(IPromocao promocao) : base(promocao)
        {
        }
    }
}
