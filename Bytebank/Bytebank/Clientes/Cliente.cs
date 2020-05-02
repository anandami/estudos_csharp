using System;
using System.Collections.Generic;
using System.Text;

namespace Bytebank.Clientes {
    public abstract class Cliente {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public int RG { get; set; }
        public string Logradouro { get; set; }
        public int NumeroResidencia { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }

        private static int TotalClientes { get; set; }

        public Cliente (string nome, string cpf) {
            Nome = nome;
            Cpf = cpf;

            TotalClientes++;
        }
    }
}
