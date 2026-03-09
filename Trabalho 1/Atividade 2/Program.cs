using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inforsua sua velocidade em Km/h");
            Double Km= Double.Parse(Console.ReadLine());
            Double m = Km / 3.6;
            Console.WriteLine($"Sua velocidade é {m} m/s");

        }
    }
}
