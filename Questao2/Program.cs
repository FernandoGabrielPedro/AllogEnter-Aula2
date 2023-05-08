using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao2
{
    class Program
    {
        static void Main(string[] args)
        {
            //F = (9 * C + 160)/5
            double tempC = 0;
            double tempF;

            bool esperandoValor = true;
            while (esperandoValor)
            {
                Console.WriteLine("Insira uma temperatura em graus Celsius (Cº):");
                try
                {
                    tempC = Convert.ToDouble(Console.ReadLine().Replace('.', ','));
                    esperandoValor = false;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Valor inválido.");
                }
            }

            tempF = (9 * tempC + 160) / 5;
            Console.WriteLine("A temperatura inserida equivale a " + tempF + " graus Fahrenheit (Fº)");
            Console.Read();
        }
    }
}
