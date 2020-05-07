using Bytebank.Clientes;
using Bytebank.Contas;
using Bytebank.Funcionarios;
using ByteBank.Sistemas;
using System;

namespace Bytebank {
    class Program {
        static void Main (string[] args) {

            //CalcularBonificacao();
            //UsarSistema();
            //CriarContaCorrente();
            Movimentacao();

            Console.ReadLine();
            
        }

        public static void Movimentacao(){
            ContaCorrente conta1 = new ContaCorrente(123,345);
            ContaCorrente conta2 = new ContaCorrente(123,456);

            conta1.Depositar(500);
            System.Console.WriteLine(conta1.Saldo);
            conta1.Sacar(1000);
            System.Console.WriteLine(conta1.Saldo);
        }

        public static void UsarSistema () {

            Funcionario pedro = new Designer("833.222.048-39");
            pedro.Nome = "Pedro";

            Diretor roberta = new Diretor("159.753.398-04");
            roberta.Nome = "Roberta";
            roberta.Senha = "123";

            Funcionario igor = new Auxiliar("981.198.778-53");
            igor.Nome = "Igor";

            GerenteDeConta camila = new GerenteDeConta("326.985.628-89");
            camila.Nome = "Camila";
            camila.Senha = "camila";

            SistemaInterno sistema = new SistemaInterno();

            sistema.Logar(roberta, "123");
            sistema.Logar(roberta, "abc");
            sistema.Logar(camila, "camila");
            sistema.Logar(camila, "camila_hack");

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

        public static void CriarContaCorrente(){
            try{
                ClienteCorrente ananda = new ClienteCorrente("Ananda", "123.345.232-22");
                System.Console.WriteLine(ananda.Nome);
                System.Console.WriteLine(ananda.Cpf);
                ContaCorrente conta1 = new ContaCorrente(123,0);
                conta1.Titular = ananda;
                System.Console.WriteLine(conta1.Agencia); 
                System.Console.WriteLine(conta1.Numero);
            }
            catch(ArgumentException e){
                System.Console.WriteLine(e.Message);
                System.Console.WriteLine(e.ParamName);
            }
            

        }
    }
}
