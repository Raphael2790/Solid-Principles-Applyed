using System;
using System.Collections.Generic;
using System.Text;

namespace CursoFoop_Exercicio3
{
    public class CalculoImpostoBrazil : ICalculoImpostoPais
    {
        public decimal ValorTotal { get; set; }
        public decimal Reducao { get; set; }

        public decimal CalcularValorImposto()
        {
            var valorBase = ValorTotal - Reducao;
            //restante do código do calculo
            return decimal.MaxValue;
        }
    }
}
