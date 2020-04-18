using Bytebank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bytebank.Sistema {

    //transformo a classe derivada autenticavel também em abstrata para que eu nao precise implementar os métodos abstratos de funcionario
    public abstract class Autenticavel : Funcionario {

         //construtor (item formal, somente para repassar o contrutor de funcionarios para as suas proprias classes filhas)
        public Autenticavel(double _salario, string _cpf) : base(_salario, _cpf) {

        }
    
        //autenticar
        public string Senha { get; set; }

        public bool Autenticar (string _senha) {
            return Senha == _senha;
        }
    }
}
