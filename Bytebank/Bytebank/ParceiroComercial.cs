using Bytebank.Sistema;
using System;
using System.Collections.Generic;
using System.Text;


namespace Bytebank {
    class ParceiroComercial: Autenticavel {

        public string Senha { get; set; }

        public bool Autenticar(string _senha) {
            if (Senha == _senha) {
                return true;
            }
            return false;
        }
    }
}
