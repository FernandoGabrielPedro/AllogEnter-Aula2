using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao7
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (string nome in args)
                Console.WriteLine("Olá, meu nome é " + nome + "!");
        }
    }
}
