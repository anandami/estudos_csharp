using System;
using System.Collections.Generic;
using System.Text;

namespace Bytebank.Funcionarios {
    class Diretor:Funcionario {
        //construtor
        public Diretor (string _cpf) : base(5000,_cpf) { 
            
        }
        //métodos (sem retorno) e funções (com retorno)
        public override double GetBonificacao() {
            return (Salario*0.5);
        }

        public override void AumentarSalario () {
            Salario *= 1.15;
        }
    }
}
