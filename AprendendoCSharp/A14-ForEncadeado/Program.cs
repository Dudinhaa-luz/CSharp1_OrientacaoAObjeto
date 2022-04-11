using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A14_ForEncadeado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto 13");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine();

                for (int j = 0; j < 10; j++)
                {
                    Console.Write("*");

                    if (i >= j)
                        break;
                }
            }

            //Outra forma
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine();

                for (int j = 0; j < i; j++)
                    Console.Write("*");
            }

            Console.ReadLine();
        }
    }
}
