using System;
using System.Collections.Generic;
using System.Text;

namespace CursoFoop_Exercicio3
{
    public class CalculoImpostoUSA : ICalculoImpostoPais
    {
        public decimal ValorTotal { get; set; }
        public decimal Reducao { get; set; }

        public decimal CalcularValorImposto()
        {
            var valorBase = ValorTotal - Reducao;
            //codigo para calcular os imposto dos Estados Unidos
            return decimal.MaxValue;
        }
    }
}
