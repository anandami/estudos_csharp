using Bytebank.Sistema;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bytebank.Funcionarios {
    //classe intermediária para evitar repetição de codigo
    public abstract class FuncionarioAutenticavel: Funcionario, IAutenticavel {

        //implementando a interface IAutenticavel
        public string Senha { get; set; }

        public bool Autenticar (string _senha) {
            if (Senha == _senha) {
                return true;
            }
            return false;
        }

        //construtor
        public FuncionarioAutenticavel(double salario, string cpf) : base(salario,cpf) {

        }
    }
}
