using Aplicando_Principios_SOLID1.Exerciocio4Resolvido.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aplicando_Principios_SOLID1.Exerciocio4Resolvido.Entidades
{
    public class Perfume : ProdutoBase
    {
        public Perfume(IPromocao promocao) : base(promocao)
        {
        }
    }
}
