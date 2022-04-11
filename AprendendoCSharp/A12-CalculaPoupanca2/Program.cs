using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A12_CalculaPoupanca2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 11");

            double valorInvestido = 1000;

            for (int i = 0; i < 12; i++)
            {
                valorInvestido *= 1.0036;
                Console.WriteLine("Após " + i + " você terá R$" + valorInvestido);
            }

            Console.ReadLine();
        }
    }
}
