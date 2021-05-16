using Aplicando_Principios_SOLID1.Exercicio1Resolvido.Entidades;
using Aplicando_Principios_SOLID1.Exercicio1Resolvido.Interfaces;
using System.Collections.Generic;
using System.Text;

namespace Aplicando_Principios_SOLID1.Exercicio1Resolvido.FactoryObjects
{
    public class GeradorRelatoriosCSV : IGeradorRelatorios
    {
        public string ExportarRelatorio(List<Cliente> dados)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in dados)
            {
                sb.AppendFormat($"{item.Nome},{item.Pais},{item.Email}");
                sb.AppendLine();
            }
            return sb.ToString();
        }
    }
}
