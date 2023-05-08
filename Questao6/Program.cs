using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao6
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringInicial = "";
            string stringFinal = "";

            Console.WriteLine("Insira uma frase, e iremos substituir todas as letras A pelo símbolo &:");
            stringInicial = Console.ReadLine();

            foreach (char letra in stringInicial)
            {
                if (letra == 'A' || letra == 'a')
                {
                    stringFinal = stringFinal + '&';
                    continue;
                }
                stringFinal = stringFinal + letra;
            }

            Console.WriteLine("A frase resultante é:");
            Console.WriteLine("'" + stringFinal + "'");

            Console.Read();
        }
    }
}
