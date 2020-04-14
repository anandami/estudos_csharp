using System;
using System.Collections.Generic;
using System.Text;

namespace Bytebank.Funcionarios {
    class Desenvolvedor: Funcionario {

        //constrututor
        public Desenvolvedor(string _cpf) : base(3000, _cpf) {

        }
        //métodos sobrepostos
        public override void AumentarSalario () {
            Salario *= 1.15;
        }

        public override double GetBonificacao () {
            return Salario * 0.1;
        }
    }
}
