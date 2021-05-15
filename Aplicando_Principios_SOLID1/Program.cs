using Aplicando_Principios_SOLID1.AplicandoFactoryPattern;
using Aplicando_Principios_SOLID1.AplicandoStrategyPattern;
using Aplicando_Principios_SOLID1.Shared;
using System;

namespace Aplicando_Principios_SOLID1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aplicado correção nomenclatura e identação para melhor visibilidade
            //Retirado a aplicação de números diretos no código nomeando-os devidamente criando enumeradores e valores constantes
            //Aplicado responsabilidade única gerando classes para cada tipo de cliente, separando a logica de desconto fidelidade e desconto tipo de cliente
            //Aplicado o principio de aberto/fechado pois podemos aumentar os tipos de clientes sem mudanças nas outras classes
            //Aplicado o principio de Liskov pq não mudamos comportamentos da classe base nas classes derivadas
            //Aplicado o principio de segregação de interfaces pois todas classes dependem de uma abstração e não herdam mais do que precisam
            //Inversão de dependecia aplicada para remover a dependencia direta do calculo de fidelidade e fabrica de classes, também aplicado a inversão de controle e inejeção de dependencia
            //resultando no quebra do principio da segregação de interfaces ou abstrações
            //Aplicado também 2 padrões de projetos Factory e Strategy ambos com mesmo resultado
            ICalculaDescontoFidelidade calculaDescontoFidelidade = new CalcularDescontoFidelidade();
            IGerarDescontoTipoClienteFactory descontoTipoClienteFactory = new GerarDescontoTipoClienteFactory();
            GerenciadorDescontosSOLID gerenciadorDescontos = new GerenciadorDescontosSOLID(calculaDescontoFidelidade, descontoTipoClienteFactory);
            Console.WriteLine("Valor da compra 1000 e fidelidade 10 anos (5%)");

            var valorComDesconto = gerenciadorDescontos.AplicarDesconto(1000,TipoContaCliente.Diferenciado, 10);
            Console.WriteLine($"Cliente tipo 2, 10 anos fidelidade,  = {valorComDesconto}");


            var valorComDesconto1 = gerenciadorDescontos.AplicarDesconto(1000,TipoContaCliente.Especial, 10);
            Console.WriteLine($"Cliente tipo 3 o valor do desconto é de : {valorComDesconto1}");

            var valorComDesconto2 = gerenciadorDescontos.AplicarDesconto(1000,TipoContaCliente.VIP,10);
            Console.WriteLine($"Cliente tipo 4 o valor do desconto é de : {valorComDesconto2}");

            Console.WriteLine("Valor da compra 1000 e fidelidade 4 anos (4%) ");
            var valorComDesconto3 = gerenciadorDescontos.AplicarDesconto(1000,TipoContaCliente.Diferenciado, 4);
            Console.WriteLine($"Cliente tipo 2, 10 anos fidelidade,  = {valorComDesconto3}");

            var valorComDesconto4 = gerenciadorDescontos.AplicarDesconto(1000, TipoContaCliente.Especial, 4);
            Console.WriteLine($"Para Cliente tipo 3 o valor do desconto é de : {valorComDesconto4}");

            var valorComDesconto5 = gerenciadorDescontos.AplicarDesconto(1000, TipoContaCliente.VIP, 4);
            Console.WriteLine($"Para Cliente tipo 4 o valor do desconto é de : {valorComDesconto5} \n");

            Console.WriteLine("Usando padrão de projeto strategy\n");
            GerenciadorDesconto gerenciador = new GerenciadorDesconto(calculaDescontoFidelidade);

            var valorFinalClienteDiferenciado = gerenciador.CalcularValorComDesconto(new GerarDescontoClienteDiferenciado(), 1000, 10);
            Console.WriteLine($"Cliente tipo 2, 10 anos fidelidade,  = {valorFinalClienteDiferenciado}");

            var valorFinalClienteEspecial = gerenciador.CalcularValorComDesconto(new GerarDescontoClienteEspecial(), 1000, 10);
            Console.WriteLine($"Cliente tipo 2, 10 anos fidelidade,  = {valorFinalClienteEspecial}");

            var valorFinalClienteVIP = gerenciador.CalcularValorComDesconto(new GerarDescontoClienteVIP(), 1000, 10);
            Console.WriteLine($"Cliente tipo 2, 10 anos fidelidade,  = {valorFinalClienteVIP}");

            Console.ReadLine();
        }
    }
}
