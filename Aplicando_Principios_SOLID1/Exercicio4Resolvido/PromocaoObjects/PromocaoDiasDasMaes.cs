using Aplicando_Principios_SOLID1.Exerciocio4Resolvido.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aplicando_Principios_SOLID1.Exerciocio4Resolvido.PromocaoObjects
{
    public class PromocaoDiasDasMaes : IPromocao
    {
        public decimal Desconto()
        {
            return 0.10m;
        }
    }
}
