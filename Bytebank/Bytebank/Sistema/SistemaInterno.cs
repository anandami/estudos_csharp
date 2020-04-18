using Bytebank.Sistema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Sistemas {
    public class SistemaInterno {
        public bool Logar (Autenticavel _funcionario, string _senha) {
            bool usuarioAutenticado = _funcionario.Autenticar(_senha);

            if (usuarioAutenticado) {
                Console.WriteLine("Bem-vindo ao sistema!");
                return true;
            } else {
                Console.WriteLine("Senha incorreta!");
                return false;
            }
        }
    }
}