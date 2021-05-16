using Aplicando_Principios_SOLID1.Exercicio1Resolvido.Enums;
using Aplicando_Principios_SOLID1.Exercicio1Resolvido.Interfaces;
using System;

namespace Aplicando_Principios_SOLID1.Exercicio1Resolvido.FactoryObjects
{
    public class GeradorRelatoriosFactory : IGeradorRelatoriosFactory
    {
        public IGeradorRelatorios GetTipoRelatorio(TiposRelatorio tipoRelatorio)
        {
            IGeradorRelatorios geradorRelatorios;

            switch (tipoRelatorio)
            {
                case TiposRelatorio.CSV:
                    geradorRelatorios = new GeradorRelatoriosCSV();
                    break;
                case TiposRelatorio.PDF:
                    geradorRelatorios = new GerarRelatoriosPDF();
                    break;
                case TiposRelatorio.XML:
                    geradorRelatorios = new GeradorRelatoriosXML();
                    break;
                default:
                    throw new NotImplementedException();
            }

            return geradorRelatorios;
        }
    }
}
