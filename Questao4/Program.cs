using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao4
{
    class Program
    {
        static void Main(string[] args)
        {
            double tempo = 0;
            double velocidadeMedia = 0;
            double distancia;
            double litrosGastos;

            Console.WriteLine("Você realizou uma viagem. O carro utilizado gasta 12 litros de combustível por Km percorrido.");

            bool esperandoValor = true;
            while (esperandoValor)
            {
                Console.WriteLine("Insira o tempo gasto, em horas:");
                try
                {
                    tempo = Convert.ToDouble(Console.ReadLine().Replace('.', ','));
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
                Console.WriteLine("Insira a velocidade média, em Km/h, do veículo durante a viagem:");
                try
                {
                    velocidadeMedia = Convert.ToDouble(Console.ReadLine().Replace('.', ','));
                    esperandoValor = false;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Valor inválido.");
                }
            }

            distancia = tempo * velocidadeMedia;
            litrosGastos = distancia / 12;

            Console.WriteLine("TEMPO DA VIAGEM (em horas): \t" + Convert.ToString(tempo).Replace('.', ','));
            Console.WriteLine("VELOCIDADE MÉDIA DO VEÍCULO (em Km/h): \t" + Convert.ToString(velocidadeMedia).Replace('.', ','));
            Console.WriteLine("DISTÂNCIA PERCORRIDA (em Km): \t" + Convert.ToString(distancia).Replace('.', ','));
            Console.WriteLine("COMBUSTÍVEL GASTO (em litros): \t" + Convert.ToString(litrosGastos).Replace('.', ','));

            Console.Read();
        }
    }
}
