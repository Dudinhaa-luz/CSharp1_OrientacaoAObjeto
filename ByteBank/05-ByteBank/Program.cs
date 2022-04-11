using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente gabriela = new Cliente();

            ContaCorrente conta = new ContaCorrente();

            conta.titular = new Cliente();
            conta.titular.nome = "Gabriela";
            conta.titular.profissao = "Desenvolvedora C#";
            conta.titular.cpf = "11396411909";

            gabriela.nome = "Gabriela";
            gabriela.profissao = "Desenvolvedora C#";
            gabriela.cpf = "11396411909";

            conta.titular = gabriela;
            conta.saldo = 500;
            conta.agencia = 563;
            conta.numero = 5634527;

            if(conta.titular == null)
            {
                Console.WriteLine("A referência do titular é nula.");
            }

            Console.WriteLine(gabriela.nome);
            Console.WriteLine(conta.titular.nome);

            Console.ReadLine();
        }
    }
}
