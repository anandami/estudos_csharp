using System;
using System.Collections.Generic;
using System.Text;

namespace Bytebank.Funcionarios {
    class Auxiliar:Funcionario {

        //construtor
        public Auxiliar (string _cpf) : base(2000, _cpf) {

        }

        //métodos sobrepostos
        public override void AumentarSalario () {
            Salario *= 1.1;
        }

        public override double GetBonificacao () {
            return Salario*0.2;
        }

    }
}
