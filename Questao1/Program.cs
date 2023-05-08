using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Questão 1
            double cotacaoDolar = 0;
            double valorDolares = 0;
            double valorReais;

            bool esperandoValor = true;
            while (esperandoValor)
            {
                Console.WriteLine("Insira a cotação atual do dólar:");
                try
                {
                    cotacaoDolar = Convert.ToDouble(Console.ReadLine().Replace('.', ','));
                    esperandoValor = false;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Valor inválido.");
                }
            }

            esperandoValor = true;
            while (esperandoValor) {
                Console.WriteLine("Insira um valor em dólares:");
                try
                {
                    valorDolares = Convert.ToDouble(Console.ReadLine().Replace('.', ','));
                    esperandoValor = false;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Valor inválido.");
                }
            }

            valorReais = valorDolares * cotacaoDolar;
            Console.WriteLine("O valor inserido equivale a R$" + Convert.ToString(valorReais));
            Console.Read();
        }
    }
}
