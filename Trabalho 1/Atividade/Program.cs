using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, n1, n2, n3, n4;
            Console.WriteLine("insira um numero entre 1000 e 9999");
            n = int.Parse(Console.ReadLine());
            n1 = (n / 1000) % 10;
            n2 = (n / 100) % 10;
            n3 = (n / 10) % 10;
            n4 = n % 10;
            
            Console.WriteLine($" seu numero é " + n1.ToString("0"));
            Console.WriteLine($" seu numero é " + n2.ToString("0"));
            Console.WriteLine($" seu numero é " + n3.ToString("0"));
            Console.WriteLine($" seu numero é " + n.ToString("0"));


        }
    }
}
