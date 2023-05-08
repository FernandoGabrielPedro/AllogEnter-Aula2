using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao8
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario = 0;

            bool esperandoValor = true;
            while (esperandoValor)
            {
                Console.WriteLine("Insira o seu salário para reajuste:");
                try
                {
                    salario = Convert.ToDouble(Console.ReadLine().Replace('.', ','));
                    esperandoValor = false;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Valor inválido.");
                }
            }

            if (salario < 1850)
                salario += 320;
            else
                salario += 180;

            Console.WriteLine("O seu salário, após reajuste, é de R$" + Convert.ToString(salario).Replace('.', ','));

            Console.Read();
        }
    }
}
