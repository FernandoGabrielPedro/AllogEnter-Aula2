using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao5
{
    class Program
    {
        static void Main(string[] args)
        {
            //C = ((F - 32) * 5) / 9
            double tempF = 0;
            double tempC;

            bool esperandoValor = true;
            while (esperandoValor)
            {
                Console.WriteLine("Insira uma temperatura em graus Fahrenheit (Fº):");
                try
                {
                    tempF = Convert.ToDouble(Console.ReadLine().Replace('.', ','));
                    esperandoValor = false;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Valor inválido.");
                }
            }

            tempC = ((tempF - 32) * 5) / 9;
            Console.WriteLine("A temperatura inserida equivale a " + tempC + " graus Celsius (Cº)");

            Console.Read();
        }
    }
}
