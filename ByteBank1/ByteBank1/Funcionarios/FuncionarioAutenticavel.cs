using ByteBank1.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank1.Funcionarios
{
    internal abstract class FuncionarioAutenticavel : Funcionario, IAutenticavel
    {
        public string Senha { get; set; }

        public FuncionarioAutenticavel(string cpf, double salario) : base(cpf, salario)
        {

        }

        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }
    }
}
