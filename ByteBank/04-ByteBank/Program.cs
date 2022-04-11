using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoBruno = new ContaCorrente();

            contaDoBruno.titular = "Bruno";

            Console.WriteLine(contaDoBruno.saldo);

            bool resultadoSaque = contaDoBruno.Sacar(50);

            Console.WriteLine(contaDoBruno.saldo);
            Console.WriteLine(resultadoSaque);

            contaDoBruno.Depositar(500);
            Console.WriteLine(contaDoBruno.saldo);

            ContaCorrente contaDaGabriela = new ContaCorrente();

            Console.WriteLine("Bruno: " + contaDoBruno.saldo);
            Console.WriteLine("Gabriela: " + contaDaGabriela.saldo);

            contaDaGabriela.titular = "Gabriela";
            bool resultadoTransferencia = contaDoBruno.Transferir(200, contaDaGabriela);

            Console.WriteLine("Bruno: " + contaDoBruno.saldo);
            Console.WriteLine("Gabriela: " + contaDaGabriela.saldo);
            Console.WriteLine(resultadoTransferencia);

            contaDaGabriela.Transferir(100, contaDoBruno);
            Console.WriteLine("Bruno: " + contaDoBruno.saldo);
            Console.WriteLine("Gabriela: " + contaDaGabriela.saldo);

            Console.ReadLine();
        }
    }
}
