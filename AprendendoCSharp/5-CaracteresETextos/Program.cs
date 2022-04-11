using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CaracteresETextos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 5 - _5_CaracteresETextos e textos");

            //Suporta apenas um caractere;
            char primeiraLetra = 'A';
            Console.WriteLine(primeiraLetra);

            //Internamente os caracteres são números
            primeiraLetra = (char)65;
            Console.WriteLine(primeiraLetra);

            //ASCII Table
            primeiraLetra = (char)(primeiraLetra + 1);
            Console.WriteLine(primeiraLetra);

            string titulo = "Alura Cursos de Tecnologia " + 2020;
            string cursosProgramacao = " - .NET \r\n - Java \r\n - Javascript";
            Console.WriteLine(titulo);
            Console.WriteLine(cursosProgramacao);

            //O @ permite uma string de várias linhas
            cursosProgramacao = @" - .NET 
                                   - Java 
                                   - Javascript";

            Console.WriteLine(cursosProgramacao);

            Console.ReadLine();
        }
    }
}
