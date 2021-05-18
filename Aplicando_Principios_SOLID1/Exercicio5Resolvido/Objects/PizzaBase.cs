using Aplicando_Principios_SOLID1.Exercicio5Resolvido.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aplicando_Principios_SOLID1.Exercicio5Resolvido.Objects
{
    public abstract class PizzaBase
    {
        protected PizzaBase(string nome, TamanhoPizza tamanho, decimal preco)
        {
            Nome = nome;
            Tamanho = tamanho;
            Preco = preco;
        }


        public string Nome { get; set; }
        public TamanhoPizza Tamanho { get; set; }
        public decimal Preco { get; set; }

        public abstract void AssarPizza();
        public void DeliveryPizza()
        {
            Console.WriteLine($"Entregando pizza {Nome}");
        }
    }
}
