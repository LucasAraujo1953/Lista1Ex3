using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double d;
            double a;

            Console.Write("Informe a diagonal do quadrado: ");
            d = double.Parse(Console.ReadLine());

            a = Math.Pow(d, 2) / 2;
            Console.WriteLine("O valor da diagonal do quadrado é {0}, com isso, sua área é igual a {1}", d, a);
        }
    }
}
