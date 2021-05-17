namespace CursoFoop_Exercicio3
{
    public class CalculadoraImpostos : ICalculadoraImpostos
    {
      
        public decimal CalcularImpostoPorPais(ICalculoImpostoPais calculoImpostoPais)
        {
            return calculoImpostoPais.CalcularValorImposto();
        }
    }
}
