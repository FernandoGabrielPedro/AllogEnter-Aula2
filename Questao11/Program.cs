using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao11
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> pilhaInt = new Stack<int>();
            string input;

            Console.WriteLine("Insira uma lista de valores inteiros.\n" +
                              "Insira a letra 'e' para encerrar a inserção.\n" +
                              "Inserções inválidas seráo desconsideradas.\n");

            while (true)
            {
                input = Console.ReadLine();

                if (input == "e")
                    break;

                try
                {
                    pilhaInt.Push(Convert.ToInt32(input));
                }
                catch (Exception e)
                {
                    Console.WriteLine("Inserção inválida.");
                    continue;
                }
            }
            Console.WriteLine("Inserção encerrada.\n");

            foreach (int num in pilhaInt)
                Console.WriteLine(num);

            if (pilhaInt.Count < 1)
                Console.WriteLine("Não foi inserido nenhum elemento.");

            Console.Read();
        }
    }
}
