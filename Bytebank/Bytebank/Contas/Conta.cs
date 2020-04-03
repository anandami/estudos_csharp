using Bytebank.Clientes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bytebank.Contas {
    class Conta {

        public Cliente Titular { get; set; }
        public int Agencia { get; set; }
        public int Numero { get; set; }
        public double Saldo { get; set; }
        
    }
}
