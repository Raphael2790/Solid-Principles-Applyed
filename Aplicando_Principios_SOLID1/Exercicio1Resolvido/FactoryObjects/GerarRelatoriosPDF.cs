using Aplicando_Principios_SOLID1.Exercicio1Resolvido.Entidades;
using Aplicando_Principios_SOLID1.Exercicio1Resolvido.Interfaces;
using System;
using System.Collections.Generic;

namespace Aplicando_Principios_SOLID1.Exercicio1Resolvido.FactoryObjects
{
    public class GerarRelatoriosPDF : IGeradorRelatorios
    {
        public string ExportarRelatorio(List<Cliente> dados)
        {
            throw new NotImplementedException();
        }
    }
}
