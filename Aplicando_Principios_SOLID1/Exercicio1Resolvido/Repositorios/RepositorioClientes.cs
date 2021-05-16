using Aplicando_Principios_SOLID1.Exercicio1Resolvido.Entidades;
using Aplicando_Principios_SOLID1.Exercicio1Resolvido.Interfaces;
using System.Collections.Generic;

namespace Aplicando_Principios_SOLID1.Exercicio1Resolvido.Repositorios
{
    public class RepositorioClientes : IRepositorioClientes
    {
        public List<Cliente> GetClientes()
        {
            List<Cliente> listaClientes = new List<Cliente>()
            {
                new Cliente
                {
                    Nome="Pedro", Pais="Brasil", Email="pedro@email.com"
                },
                new Cliente
                {
                    Nome="Maria", Pais="Chile", Email="maria@email.com"
                }
            };
            return listaClientes;
        }

        public Cliente ProcuraPorNome(string nome)
        {
            return GetClientes().Find(n => n.Nome == nome);
        }

        public Cliente ProcuraPorPais(string pais)
        {
            return GetClientes().Find(n => n.Pais == pais);
        }
    }
}
