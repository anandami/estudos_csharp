using Bytebank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bytebank.Sistema {

    //transformo a classe derivada autenticavel também em abstrata para que eu nao precise implementar os métodos abstratos de funcionario
    public interface IAutenticavel {
                  
        //autenticar
        string Senha { get; set; }

        bool Autenticar (string _senha);
    }
}
