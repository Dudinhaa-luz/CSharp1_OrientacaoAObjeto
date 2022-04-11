using ByteBank1.Funcionarios;
using ByteBank1.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CalculaBonificacao();

            UsarSistema();

            Console.ReadLine();
        }

        public static void CalculaBonificacao()
        {
            GerenciadorBonificacao gerenciadrBonificacao = new GerenciadorBonificacao();

            Funcionario pedro = new Designer("856.562.456-56");
            pedro.Nome = "Pedro";

            Funcionario roberta = new Diretor("569.458.632.14");
            roberta.Nome = "Roberta";

            Funcionario igor = new Auxiliar("213.568.652-65");
            igor.Nome = "Igor";

            Funcionario camila = new GerenteDeConta("563.445.856-54");
            camila.Nome = "Camila";

            gerenciadrBonificacao.Registrar(pedro);
            gerenciadrBonificacao.Registrar(roberta);
            gerenciadrBonificacao.Registrar(igor);
            gerenciadrBonificacao.Registrar(camila);

            Console.WriteLine("Total de Bonificacao: " + gerenciadrBonificacao.GetBonificacao());
        }

        public static void UsarSistema()
        {

            SistemaInterno sistema = new SistemaInterno();

            FuncionarioAutenticavel roberta = new Diretor("159.753.398-04");
            roberta.Nome = "Roberta";
            roberta.Senha = "123";

            FuncionarioAutenticavel camila = new GerenteDeConta("563.445.856-54");
            camila.Nome = "Camila";
            camila.Senha = "abc";

            ParceiroComercial parceiro = new ParceiroComercial();
            parceiro.Senha = "123456";

            sistema.Logar(roberta, "123");
            sistema.Logar(camila, "abc");
            sistema.Logar(parceiro, "123456");
        }
    }
}
