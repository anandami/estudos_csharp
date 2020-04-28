using Bytebank.Sistema;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bytebank.Funcionarios {
    class GerenteDeConta:FuncionarioAutenticavel {
                
        //construtor
        public GerenteDeConta(string _cpf) : base(4000, _cpf) {
            Console.WriteLine("Criando Gerente de Conta");
        }

        //métodos sobrepostos

        public override void AumentarSalario() {
            Salario *=1.05;
        }

        public override double GetBonificacao() {
            return Salario*0.25;
        }

    }
}
