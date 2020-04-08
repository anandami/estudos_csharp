using System;
using System.Collections.Generic;
using System.Text;

namespace Bytebank.Funcionarios {
    class Funcionario {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public int RG { get; set; }

        public double Salario { get; set; }

        public virtual double GetBonificacao() { 
            return Salario * 0.10;
        }

        public static int TotalFuncionario { get; private set; }
        //construtor
        public Funcionario () {
            TotalFuncionario++;
        }
    }
}
