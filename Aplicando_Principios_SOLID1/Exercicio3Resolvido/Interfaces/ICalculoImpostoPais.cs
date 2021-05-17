using System;
using System.Collections.Generic;
using System.Text;

namespace CursoFoop_Exercicio3
{
    public interface ICalculoImpostoPais
    {
        decimal ValorTotal { get; set; }
        decimal Reducao { get; set; }
        decimal CalcularValorImposto();
    }
}
