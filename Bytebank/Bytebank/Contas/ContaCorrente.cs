using System;
using System.Collections.Generic;
using System.Text;
using Bytebank;

namespace Bytebank.Contas{
        public class ContaCorrente: Conta {

        //construtor
        public ContaCorrente(int agencia, int numero):base(agencia,numero) {

            if (agencia <= 0 || numero <= 0){
                throw new ArgumentException("Agencia ou número não podem ter valores iguais ou menores que zero.");
            }
        }
    }
}
