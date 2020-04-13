using Bytebank.Clientes;
using Bytebank.Contas;
using Bytebank.Funcionarios;
using System;

namespace Bytebank {
    class Program {
        static void Main (string[] args) {

            CalcularBonificacao();

            Console.ReadLine();
            
        }

        public static void CalcularBonificacao () {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Funcionario pedro = new Designer("833.222.048-39");
            pedro.Nome = "Pedro";

            Funcionario roberta = new Diretor("159.753.398-04");
            roberta.Nome = "Roberta";

            Funcionario igor = new Auxiliar("981.198.778-53");
            igor.Nome = "Igor";

            Funcionario camila = new GerenteDeConta("326.985.628-89");
            camila.Nome = "Camila";

            gerenciador.Registrar(pedro);
            gerenciador.Registrar(roberta); 
            gerenciador.Registrar(igor);
            gerenciador.Registrar(camila);

            Console.WriteLine("Total de Bonificações: R$" + gerenciador.GetTotalBonificacao());

        }
    }
}
