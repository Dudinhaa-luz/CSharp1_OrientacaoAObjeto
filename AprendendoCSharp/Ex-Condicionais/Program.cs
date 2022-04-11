using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Condicionais
{
    internal class Program
    {
        //O João gostaria de criar um programa sobre Imposto de Renda(IR) e verificou as regras de alíquota.Ele descobriu no site da receita:
        //De 1900.0 até 2800.0, o IR é de 7.5% e pode deduzir na declaração o valor de R$ 142;
        //De 2800.01 até 3751.0, o IR é de 15% e pode deduzir R$ 350;
        //De 3751.01 até 4664.00, o IR é de 22.5% e pode deduzir R$ 636.
        static void Main(string[] args)
        {
            double salario = 3300.0;

            if (salario >= 1900.0 && salario <= 2800.0)
            {
                Console.WriteLine("IR é de 7.5% pode deduzir R$142,00");
            }
            else if (salario <= 3751.0)
            {
                Console.WriteLine("IR é de 15% pode deduzir R$350,00");
            }
            else if (salario <= 4664.0)
            {
                Console.WriteLine("IR é de 22.5% pode deduzir R$636,00");
            }
        }
    }
}
