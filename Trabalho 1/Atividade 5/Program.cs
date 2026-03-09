using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double vh, h, d, d2;
            Console.WriteLine("Qual o valor da hora de trabalo (em reais)");
            vh = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira o numero de horas mensais");
            h = double.Parse(Console.ReadLine());
            d = h * vh;
            d2 = d + (0.1 * d);
            Console.WriteLine($"o valor a ser pago é {d2}");

        }
    }
}
