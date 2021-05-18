using Aplicando_Principios_SOLID1.Exercicio5Resolvido.Enums;
using Aplicando_Principios_SOLID1.Exercicio5Resolvido.Interfaces;
using Aplicando_Principios_SOLID1.Exercicio5Resolvido.Objects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aplicando_Principios_SOLID1.Exercicio5Resolvido
{
    public class PizzaFactory : IPizzaFactory
    {
        public PizzaBase CriarPizzaEspecifica(TipoPizza tipo, TamanhoPizza tamanho)
        {
            PizzaBase pizza;

            switch (tipo)
            {
                case TipoPizza.Calabresa 
                    when tamanho == TamanhoPizza.Broto:
                    pizza = new PizzaCalabresa("Calabresa", TamanhoPizza.Broto , 20m);
                    break;
                case TipoPizza.Calabresa
                    when tamanho == TamanhoPizza.Media:
                    pizza = new PizzaCalabresa("Calabresa", TamanhoPizza.Media, 20m);
                    break;
                case TipoPizza.Calabresa
                    when tamanho == TamanhoPizza.Grande:
                    pizza = new PizzaCalabresa("Calabresa", TamanhoPizza.Grande, 20m);
                    break;
                case TipoPizza.Mussarela:
                    switch (tamanho)
                    {
                        case TamanhoPizza.Grande:
                            pizza = new PizzaMussarela("Mussarela", TamanhoPizza.Grande, 40m);
                            break;
                        case TamanhoPizza.Media:
                            pizza = new PizzaMussarela("Mussarela", TamanhoPizza.Media, 40m);
                            break;
                        case TamanhoPizza.Broto:
                            pizza = new PizzaMussarela("Mussarela", TamanhoPizza.Broto, 40m);
                            break;
                        default:
                            throw new NotImplementedException();
                    }
                    break;
                case TipoPizza.Portuguesa
                    when tamanho == TamanhoPizza.Broto:
                    pizza = new PizzaPortuguesa("Portuguesa", TamanhoPizza.Broto, 45m);
                    break;
                case TipoPizza.Portuguesa
                    when tamanho == TamanhoPizza.Media:
                    pizza = new PizzaPortuguesa("Portuguesa", TamanhoPizza.Media, 45m);
                    break;
                case TipoPizza.Portuguesa
                    when tamanho == TamanhoPizza.Grande:
                    pizza = new PizzaPortuguesa("Portuguesa", TamanhoPizza.Grande, 45m);
                    break;
                default:
                    throw new NotImplementedException();
            }

            return pizza;
        }
    }
}
