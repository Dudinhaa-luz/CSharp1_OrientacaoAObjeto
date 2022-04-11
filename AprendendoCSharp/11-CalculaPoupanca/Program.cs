using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_CalculaPoupanca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 11 - Calcula Poupança");

            double valorInverstido = 1000;
            int contadorMes = 1;

            while (contadorMes <= 12)
            {
                valorInverstido += valorInverstido * 0.0036;
                Console.WriteLine("Após " + contadorMes + " mês você terá R$ " + valorInverstido);
                contadorMes++;
            }

            //0.36% = 0.0036
            valorInverstido += valorInverstido * 0.0036;
            Console.WriteLine("Após 1 mês você terá R$" + valorInverstido);

            valorInverstido += valorInverstido * 0.0036;
            Console.WriteLine("Após 2 mês você terá R$" + valorInverstido);

            Console.ReadLine();
        }
    }
}
