using ByteBank1.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank1.Funcionarios
{
    //O diretor é também um funcionário - diretor herda de funcionário
    internal class Diretor : FuncionarioAutenticavel
    {

        //Passa a diante para a classe base o argumento do construtor
        public Diretor(string cpf) : base(cpf, 5000) //Define que o valor mínimo de salário para um diretor é 5000
        {
            Console.WriteLine("Criando Diretor");
        }

        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }

        //Override: Para sobrescrever um método virtual
        public override double GetBonificacao() 
        {
            return Salario * 0.5;
        }
    }
}
