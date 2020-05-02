using Bytebank.Clientes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bytebank.Contas {
    public abstract class Conta {

        public ClienteCorrente Titular { get; set; }
        public int Agencia { get; } //valor readonly - somente setado no construtor
        public int Numero { get; } //valor readonly - somente setado no construtor
        public double Saldo { get; set; }

        public static int TotalContas { get; private set; }

        //construtor
        public Conta(int agencia, int numero) {

            if (agencia <= 0 || numero <= 0){
                throw new ArgumentException("Agencia ou número não podem ter valores iguais ou menores que zero.");
            }
            TotalContas++;
        }
    }
}
