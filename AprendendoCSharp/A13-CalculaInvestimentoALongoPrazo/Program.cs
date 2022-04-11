using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A13_CalculaInvestimentoALongoPrazo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 13");

            double valorInvestido = 1000;
            double fatorRendimento = 1.0036;

            for (int i = 0; i <= 5; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    valorInvestido *= fatorRendimento;
                }
                fatorRendimento += 0.0010;
            }

            Console.WriteLine("Ao término do investimento você terá: R$" + valorInvestido);

            Console.ReadLine();
        }
    }
}
