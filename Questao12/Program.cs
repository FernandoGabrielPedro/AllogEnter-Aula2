using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao12
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            double inputDouble = 0;
            double melhorTempo = -1;
            int melhorTempoVolta = 0;
            double tempoMedio = 0;

            Console.WriteLine("Registre os tempos alcançados por um piloto de corrida em cada volta, em segundos.\n" +
                              "Insira a letra 'e' para encerrar a inserção.\n" +
                              "Inserções inválidas seráo desconsideradas.\n");

            int voltasPercorridas = 0;
            while (true)
            {
                input = Console.ReadLine().Replace('.', ',');

                if (input == "e")
                    break;

                try
                {
                    inputDouble = Convert.ToDouble(input);
                    if (inputDouble < 0)
                        throw new Exception();
                }
                catch
                {
                    Console.WriteLine("Inserção inválida.");
                    continue;
                }

                voltasPercorridas++;

                if (inputDouble > melhorTempo)
                {
                    melhorTempo = inputDouble;
                    melhorTempoVolta = voltasPercorridas;
                }

                tempoMedio += inputDouble;
            }

            tempoMedio = tempoMedio / voltasPercorridas;

            Console.WriteLine("VOLTAS PERCORRIDAS:\t" + voltasPercorridas);
            Console.WriteLine("MELHOR TEMPO:\t" + melhorTempo);
            Console.WriteLine("MELHOR VOLTA:\t" + melhorTempoVolta);
            Console.WriteLine("TEMPO MÉDIO:\t" + tempoMedio);
            Console.Read();
        }
    }
}
