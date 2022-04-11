using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_MultiplosDe3For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Utilize um laço do tipo for para imprimir todos os múltiplos de 3, entre 1 e 100.
            for (int i = 0; i < 100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);   
                }
            }

            Console.ReadLine();

        }
    }
}
