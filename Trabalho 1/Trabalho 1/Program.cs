using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva um numero");
            int num=int.Parse(Console.ReadLine());
            Console.WriteLine($"Seu sucessor é {num + 1}" );
            Console.WriteLine($"Seu antecessor é {num - 1}");

        }
    }
}
