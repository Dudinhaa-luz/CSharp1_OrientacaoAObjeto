using ByteBank1.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank1.Sistemas
{
    internal class SistemaInterno
    {

        public bool Logar(IAutenticavel funcionario, string senha)
        {
            bool usuarioAutenticado = funcionario.Autenticar(senha);

            if (usuarioAutenticado)
            {
                Console.WriteLine("Bem Vindo ao sistema");
                return true;
            }
            else
            {
                Console.WriteLine("Senha Incorreta");
                return false;
            }
        }
    }
}
