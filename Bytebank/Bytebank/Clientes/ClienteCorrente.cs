using System;
using System.Collections.Generic;
using System.Text;
using Bytebank.Clientes;
using Bytebank.Contas;

namespace Bytebank.Clientes{
    public class ClienteCorrente:Cliente{

       //construtor
        public ClienteCorrente(string nome, string cpf) : base(nome, cpf) {
            Nome = nome;
            Cpf = cpf;

            System.Console.WriteLine("ClienteCorrente criado!");
        }

    }
}