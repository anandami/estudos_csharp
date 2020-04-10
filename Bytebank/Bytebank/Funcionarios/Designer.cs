using System;
using System.Collections.Generic;
using System.Text;

namespace Bytebank.Funcionarios {
    class Designer: Funcionario {

        //construtor
        public Designer(string _cpf) : base (3000,_cpf) {

        }

        //métodos sobrepostos
        public override void AumentarSalario () {
            Salario *= 1.11;
        }

        public override double GetBonificacao () {
            return Salario*0.17;
        }
    }
}
