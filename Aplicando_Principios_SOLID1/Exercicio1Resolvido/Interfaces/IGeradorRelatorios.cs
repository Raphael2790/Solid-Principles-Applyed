using Aplicando_Principios_SOLID1.Exercicio1Resolvido.Entidades;
using System.Collections.Generic;

namespace Aplicando_Principios_SOLID1.Exercicio1Resolvido.Interfaces
{
    public interface IGeradorRelatorios
    {
        string ExportarRelatorio(List<Cliente> dados);
    }
}
