using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num, exp, res; 
            Console.WriteLine("Digite um número da base");
            num = Double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o numero expoente");
            exp = Double.Parse(Console.ReadLine());
            res = Math.Pow(num, exp);
            Console.WriteLine($"O quadrado deste numero é {res}");
        }
    }
}
