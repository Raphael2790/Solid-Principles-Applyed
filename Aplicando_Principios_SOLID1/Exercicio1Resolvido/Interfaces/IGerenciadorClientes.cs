using Aplicando_Principios_SOLID1.Exercicio1Resolvido.Entidades;
using Aplicando_Principios_SOLID1.Exercicio1Resolvido.Enums;

namespace Aplicando_Principios_SOLID1.Exercicio1Resolvido.Interfaces
{
    public interface IGerenciadorClientes
    {
        Cliente ProcuraPorPais(string pais);
        Cliente ProcuraPorNome(string nome);
        void GerarRelatorioClientesPorTipo(TiposRelatorio tiposRelatorio);
    }
}
