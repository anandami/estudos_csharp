using System;
using System.Collections.Generic;
using System.Text;

namespace Bytebank.Contas{
        public class ContaCorrente: Conta {
        
        public double TaxaOperacao;
        public static int TotalContasCorrente;
        public ContaCorrente(int agencia, int numero): base(agencia,numero)
        {
            TotalContasCorrente++;
            System.Console.WriteLine("ContaCorrente criada");
            TaxaOperacao = 30/TotalContasCorrente;
        }  
    }
}
