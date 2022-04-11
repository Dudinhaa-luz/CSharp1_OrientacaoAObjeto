using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(867, 86795235);

            //Agora esses valores são informados no construtor
            //conta.Numero = 8671523;
            //conta.Agencia = -10;

            Console.WriteLine(conta.Numero);
            Console.WriteLine(conta.Agencia);

            ContaCorrente conta1 = new ContaCorrente(123, 12356987);

            //Membros estáticos
            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

            //Como o set é private não deixa incrementar valor às propriedades
            //ContaCorrente.TotalDeContasCriadas = 100;

            Console.ReadLine();
        }
    }
}
