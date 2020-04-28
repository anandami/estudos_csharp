using Bytebank.Sistema;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bytebank.Funcionarios {
    class Diretor: Funcionario, Autenticavel {
        public string Senha { get; set; }

        public bool Autenticar (string _senha) {

            if (Senha == _senha){
                return true;
            } else {
                return false;
            }

        }

        //construtor
        public Diretor (string _cpf) : base(5000,_cpf) {
            Console.WriteLine("Criando Diretor");
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
