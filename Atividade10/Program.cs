using Atividade09.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade09
{
    /*
* PARTICIPANTES
* LUCAS HENRIQUE DE SOUZA SANTOS CB3012212
* KETHELEEN CRISTINE SIMÃO DOS SANTOS
*/
    internal class Program
    {
        static void Main(string[] args)
        {
            var jornada = new Jornada();

            var seletor = new Seletor(jornada);

            int opcao = -1;
            while (opcao != 0)
            {
                opcao = seletor.EscolherOpcao();
            }

        }
    }
}

