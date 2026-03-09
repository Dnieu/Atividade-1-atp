using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double l, a, d, p;
            Console.WriteLine("insira o lado do quadrado");
            l= double.Parse(Console.ReadLine());
            a= Math.Pow(l,2);
            p = l * 4;
            d = l * (Math.Sqrt (2) );
            Console.WriteLine($"Seu Perimetro é {p}");
            Console.WriteLine($"Sua area é {a}");
            Console.WriteLine($"Sua diagonal é {d}");


        }
    }
}
