using System;
using System.Collections.Generic;
using System.Text;

namespace Bytebank.Funcionarios {
    class Funcionario {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public int RG { get; set; }

        public double Salario { get; set; }

        private double _totalBonificacao;

        public double TotalBonificacao {
            get {
                return _totalBonificacao;
            }
            set {
                TotalBonificacao = +_totalBonificacao;
            }
        }
        public virtual double GetBonificacao() { 
            return Salario*0.1;

        }
    }
}
