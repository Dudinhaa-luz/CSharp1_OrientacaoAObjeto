using ByteBank1.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank1.Sistemas
{
    internal interface IAutenticavel 
    {
        bool Autenticar(string senha);
    }
}
