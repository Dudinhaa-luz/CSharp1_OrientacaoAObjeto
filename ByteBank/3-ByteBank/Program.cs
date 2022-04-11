using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaGabriela = new ContaCorrente();
            contaDaGabriela.titular = "Gabriela";
            contaDaGabriela.agencia = 863;
            contaDaGabriela.numero = 863452;

            //A variável guarda o endereço do objeto
            //Aponta, faz referência para o endereço da memória que está o objeto
            ContaCorrente contaDaGabrielaCosta = new ContaCorrente();
            contaDaGabrielaCosta.titular = "Gabriela";
            contaDaGabrielaCosta.agencia = 863;
            contaDaGabrielaCosta.numero = 863452;

            //Tipo de referência
            Console.WriteLine(contaDaGabrielaCosta == contaDaGabriela);

            //Tipo de valor
            int idade = 27;
            int idade2 = 27;
            Console.WriteLine(idade == idade2);

            //2 variáveis que apontam para o mesmo objeto da memória
            contaDaGabriela = contaDaGabrielaCosta;
            //Agora sim será igual
            Console.WriteLine(contaDaGabrielaCosta == contaDaGabriela);

            contaDaGabriela.saldo = 300;
            Console.WriteLine(contaDaGabriela.saldo); //300
            Console.WriteLine(contaDaGabrielaCosta.saldo); //300

            Console.ReadLine();
        }
    }
}
