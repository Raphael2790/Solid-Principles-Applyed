using Aplicando_Principios_SOLID1.Exercicio1Resolvido.Entidades;
using Aplicando_Principios_SOLID1.Exercicio1Resolvido.Enums;
using Aplicando_Principios_SOLID1.Exercicio1Resolvido.Interfaces;

namespace cursoFoop_Exercicio_SOLID1
{
    public class ClientesService : IGerenciadorClientes
    {
        private readonly IRepositorioClientes _repositorioClientes;
        private readonly IGeradorRelatoriosFactory _geradorRelatorios;
        public ClientesService(IRepositorioClientes repositorioClientes, IGeradorRelatoriosFactory geradorRelatorios)
        {
            _repositorioClientes = repositorioClientes;
            _geradorRelatorios = geradorRelatorios;
        }
        public Cliente ProcuraPorPais(string pais)
        {
            return _repositorioClientes.ProcuraPorPais(pais);
        }

        public Cliente ProcuraPorNome(string nome)
        {
            return _repositorioClientes.ProcuraPorNome(nome);
        }

        public void GerarRelatorioClientesPorTipo(TiposRelatorio tiposRelatorio)
        {
            _geradorRelatorios.GetTipoRelatorio(tiposRelatorio).ExportarRelatorio(_repositorioClientes.GetClientes());
        }
    }
}
