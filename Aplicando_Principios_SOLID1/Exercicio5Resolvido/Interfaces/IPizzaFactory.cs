using Aplicando_Principios_SOLID1.Exercicio5Resolvido.Enums;
using Aplicando_Principios_SOLID1.Exercicio5Resolvido.Objects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aplicando_Principios_SOLID1.Exercicio5Resolvido.Interfaces
{
    public interface IPizzaFactory
    {
        PizzaBase CriarPizzaEspecifica(TipoPizza tipo, TamanhoPizza tamanho);
    }
}
