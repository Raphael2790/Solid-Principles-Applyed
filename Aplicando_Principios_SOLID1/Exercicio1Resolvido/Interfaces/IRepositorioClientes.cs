using Aplicando_Principios_SOLID1.Exercicio1Resolvido.Entidades;
using System.Collections.Generic;

namespace Aplicando_Principios_SOLID1.Exercicio1Resolvido.Interfaces
{
    public interface IRepositorioClientes
    {
        List<Cliente> GetClientes();
        Cliente ProcuraPorPais(string pais);
        Cliente ProcuraPorNome(string nome);
    }
}
