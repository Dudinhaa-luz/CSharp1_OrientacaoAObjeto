﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Escopo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 9 - Escopo");

            int idadeJoao = 16;
            bool acompanhado = true;
            string mensagemAdicional = "";

            if (acompanhado)
                mensagemAdicional = "João está acompanhado";
            else
                mensagemAdicional = "João não está acompanhado";
            
            if (idadeJoao >= 18 && acompanhado)
            {
                Console.WriteLine("João pode entrar");
                Console.WriteLine(mensagemAdicional);
            }
            else
                Console.WriteLine("João não pode entrar.");

            Console.ReadLine();
        }
    }
}
