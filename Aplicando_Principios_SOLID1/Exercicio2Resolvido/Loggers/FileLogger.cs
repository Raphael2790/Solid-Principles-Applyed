using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CursoFoop_Solid_Exercicio2
{
    public class FileLogger : ILogger
    {
        public void RegistrarLog(string mensagem)
        {
            File.WriteAllText("C:\\Modulo3_Principios_SOLID\\Modulo3_Principios_SOLID\\9_Aplicando_Principios_SOLID1\\Aplicando_Principios_SOLID1\\LogOcorrencias.txt", mensagem);
        }
    }
}
