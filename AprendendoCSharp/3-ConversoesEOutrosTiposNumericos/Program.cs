using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_ConversoesEOutrosTiposNumericos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 4");

            double salario = 1200.50;
            int salarioEmInteiro = (int)salario;
            Console.WriteLine(salarioEmInteiro);

            //-2³¹ até 2³¹ ocupa 32 bits na memória
            int idade = 26;
            Console.WriteLine(idade);
            //idade = 13000000000; ultrapassa a capacidade de armazenamento

            //Variavel de 64 bits
            long idadeLong = 1300000000000000000;
            Console.WriteLine(idadeLong);

            //short suporta até 16000 ocupa 16 bits na memória
            short quantidadeProdutos = 15000;
            Console.WriteLine(quantidadeProdutos);

            //Float não oferece muita precisão para as casas decimais
            //Necessário adicionar o sufixo f quando o float for utilizado
            float altura = 1.80f;
            Console.WriteLine(altura);

            Console.ReadLine();
        }
    }
}
