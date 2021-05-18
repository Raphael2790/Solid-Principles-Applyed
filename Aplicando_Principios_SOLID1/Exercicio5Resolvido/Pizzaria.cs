using Aplicando_Principios_SOLID1.Exercicio5Resolvido.Enums;
using Aplicando_Principios_SOLID1.Exercicio5Resolvido.Interfaces;
using Aplicando_Principios_SOLID1.Exercicio5Resolvido.Objects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aplicando_Principios_SOLID1.Exercicio5Resolvido
{
    public class Pizzaria
    {
        private PizzaBase _pizza;
        private readonly IPizzaFactory _pizzaFactory;
        public Pizzaria(IPizzaFactory pizzaFactory)
        {
            _pizzaFactory = pizzaFactory;
        }

        public void CriarPizza(TipoPizza tipoPizza, TamanhoPizza tamanho)
        {
            _pizza = _pizzaFactory.CriarPizzaEspecifica(tipoPizza, tamanho);
            _pizza.AssarPizza();
            _pizza.DeliveryPizza();
        }
    }
}
