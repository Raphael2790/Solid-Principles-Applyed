using Aplicando_Principios_SOLID1.Exercicio5Resolvido.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aplicando_Principios_SOLID1.Exercicio5Resolvido.Objects
{
    public class PizzaMussarela : PizzaBase
    {
        public PizzaMussarela(string nome, TamanhoPizza tamanho, decimal preco) : base(nome, tamanho, preco)
        {
        }

        public override void AssarPizza()
        {
            var tempo = 15;
            Console.WriteLine($"O pizza de {Nome} levará {tempo} minutos.");
        }
    }
}
