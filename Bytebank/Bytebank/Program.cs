using Bytebank.Clientes;
using Bytebank.Contas;
using Bytebank.Funcionarios;
using System;

namespace Bytebank {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine("Teste de classes");
            Cliente ananda = new Cliente("Ananda Michelino", "123.456.789.-00");
            ananda.RG = 48781023;
            ananda.Logradouro = "Downtown";
            ananda.NumeroResidencia = 1472;
            ananda.UF = "SP";
            ananda.Cidade = "Iacri";

            Conta primeiraConta = new Conta();
            primeiraConta.Titular = ananda;
            primeiraConta.Numero = 1234;
            primeiraConta.Agencia = 0100;
            primeiraConta.Saldo = 1000;

            Funcionario lucas = new Funcionario();
            lucas.Nome = "Lucas Fernandes Pessoa";
            lucas.CPF = "123.543.654-87";
            lucas.RG = 11234563;
            lucas.Salario = 5000;

            Funcionario cleide = new Diretor();
            cleide.Nome = "Cleide R da Silva Michelino";
            cleide.CPF = "999.999.999-99";
            cleide.RG = 88888888;
            cleide.Salario = 10000;

            Console.WriteLine("Impressão de dados do Banco");
            Console.WriteLine("Funcionarios do banco:");
            Console.WriteLine(lucas);
            Console.WriteLine(lucas.Nome);
            Console.WriteLine(lucas.CPF);
            Console.WriteLine(lucas.Salario);
            GerenciadorBonificacao bonif1 = new GerenciadorBonificacao();
            bonif1.Registrar(lucas);
            Console.WriteLine(cleide);
            Console.WriteLine(cleide.Nome);
            Console.WriteLine(cleide.CPF);
            Console.WriteLine(cleide.Salario);
            GerenciadorBonificacao bonif2 = new GerenciadorBonificacao();
            bonif1.Registrar(cleide);
            Console.WriteLine("Bonificacao de " + lucas.Nome + ":" + lucas.GetBonificacao());
            Console.WriteLine("Bonificacao de " + cleide.Nome + ":" + cleide.GetBonificacao());
            Console.WriteLine();
            Console.WriteLine("Clientes:");
            Console.WriteLine(ananda);
            Console.WriteLine(ananda.Nome);
            Console.WriteLine(ananda.Cpf);
            Console.WriteLine();
            Console.WriteLine("Conta em aberto");
            Console.WriteLine(primeiraConta);
            Console.WriteLine("Titular da conta " + primeiraConta.Titular.Nome);
            Console.WriteLine(primeiraConta.Agencia);
            Console.WriteLine(primeiraConta.Numero);
            Console.WriteLine(primeiraConta.Saldo);


            Console.ReadLine();



        }
    }
}
