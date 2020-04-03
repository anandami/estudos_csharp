using System;
using System.Collections.Generic;
using System.Text;

namespace Bytebank.Funcionarios {
    class GerenciadorBonificacao {
        private double _totalBonificacao;

        public void Registrar(Funcionario funcionario) {
            _totalBonificacao += funcionario.GetBonificacao();
        }

        public double TotalBonificacao {
            get {
                return _totalBonificacao;
            }
            set {
                TotalBonificacao =+ _totalBonificacao;
            }
        }

        public double GetTotalBonificacao() {
            return _totalBonificacao;
        }
    }
}
