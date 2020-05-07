using System;
using System.Collections.Generic;
using System.Text;

namespace Bytebank.Contas{
        public class ContaCorrente: Conta {
        public ContaCorrente(int agencia, int numero): base(agencia,numero)
        {
            System.Console.WriteLine("ContaCorrente criada");

        }  
    }
}
