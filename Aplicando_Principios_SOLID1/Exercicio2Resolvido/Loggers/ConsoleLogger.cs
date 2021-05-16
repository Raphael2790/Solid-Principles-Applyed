using System;
using System.Collections.Generic;
using System.Text;

namespace CursoFoop_Solid_Exercicio2
{
    public class ConsoleLogger : ILogger
    {
        public void RegistrarLog(string mensagem)
        {
            Console.WriteLine(mensagem);
        }
    }
}
