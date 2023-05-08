using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao3
{
    class Program
    {
        static void Main(string[] args)
        {
            //IMC = Peso/Altura²
            double peso = 0;
            double altura = 0;
            double imc;

            bool esperandoValor = true;
            while (esperandoValor)
            {
                Console.WriteLine("Insira o seu peso, em Kg:");
                try
                {
                    peso = Convert.ToDouble(Console.ReadLine().Replace('.', ','));
                    esperandoValor = false;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Valor inválido.");
                }
            }

            esperandoValor = true;
            while (esperandoValor)
            {
                Console.WriteLine("Insira a sua altura, em metros:");
                try
                {
                    altura = Convert.ToDouble(Console.ReadLine().Replace('.', ','));
                    esperandoValor = false;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Valor inválido.");
                }
            }

            imc = peso / (altura * altura);
            Console.WriteLine("O resultado do seu fator IMC é de: " + Convert.ToString(imc).Replace('.', ','));
            Console.Write("A sua classificação de obesidade é ");
            if (imc < 18.5)
                Console.Write("Grau 0: MAGREZA");
            else if (imc < 24.9)
                Console.Write("Grau 0: NORMAL");
            else if (imc < 29.9)
                Console.Write("Grau 1: SOBREPESO");
            else if (imc < 39.9)
                Console.Write("Grau 2: OBESIDADE");
            else
                Console.Write("Grau 3: OBESIDADE GRAVE");

            Console.Read();
        }
    }
}
