using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_CriandoVariaveisPontoFlutuante
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 3 - Criando Variaveis Ponto Flutuante");

            double salario = 1200.70;
            Console.WriteLine(salario);
            
            //Número inteiro dividido por número inteiro será um número inteiro (resultado 7)
            double idade = 15 / 2;
            Console.WriteLine(idade);
            
            //Necessário transformar ao menos um em double (resultado 7,5)
            idade = 15.0 / 2;
            Console.WriteLine(idade);

            idade = 5 / 3;
            Console.WriteLine("5 / 3 = " + idade);

            idade = 5.0 / 3;
            Console.WriteLine("5 / 3 = " + idade);

            Console.WriteLine("A execução acabou. Tecle enter para sair...");
            Console.ReadLine();
        }
    }
}
