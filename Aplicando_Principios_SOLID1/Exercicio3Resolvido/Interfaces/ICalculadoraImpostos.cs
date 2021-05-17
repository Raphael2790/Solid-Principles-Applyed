using System;
using System.Collections.Generic;
using System.Text;

namespace CursoFoop_Exercicio3
{
    public interface ICalculadoraImpostos
    {
        decimal CalcularImpostoPorPais(ICalculoImpostoPais calculoImpostoPais);
    }
}
