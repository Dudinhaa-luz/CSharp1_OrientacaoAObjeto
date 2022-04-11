using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank1.Funcionarios
{
    //Funcionário é apenas uma abstração, pois utilizamos dele para gerar tipos especificos de funcionario, mas ele diretamente não é utilizado
    //Tornar a classe abstrata nos dá mais segurança pois não dá mais para criar uma instância de funcionário, apenas de suas derivações
    internal abstract class Funcionario
    {
        public static int TotalDeFuncionarios { get; private set; }
        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; } //Se torna publico apenas para a classe atual e as classes derivadas

        public Funcionario(string cpf, double salario)
        {
            Console.WriteLine("Criando Funcionario");
            CPF = cpf;
            Salario = salario;
            TotalDeFuncionarios++;
        }

        //Métodods abstratos não possuem corpo, são utilizados para obrigar as classes filhas a adicionar o método abstrato
        //Métodos abstratos só fazem parte de classes abstratas
        public abstract void AumentarSalario();

        //Virtual: para permitir que este método seja sobrescrito, como não é abstrato não se torna um método obrigatório nas classes filhas
        public virtual double GetBonificacao()
        {
            return Salario * 0.10;
        }
    }
}
