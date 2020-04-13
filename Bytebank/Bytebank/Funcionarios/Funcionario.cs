using System;
using System.Collections.Generic;
using System.Text;

namespace Bytebank.Funcionarios {
    public abstract class Funcionario {

        //propriedades
        public string Nome { get; set; }

        //CPF privado - somente acessível por métodos da classe mãe
        public string CPF { get; private set; }
        public int RG { get; set; }

        //salario protegido - acessível para a classe-mãe e classes filhas
        public double Salario { get; protected set; }

        public virtual double GetBonificacao() { 
            return Salario * 0.10;
        }
        
        //métodos
        public static int TotalFuncionario { get; private set; }


        public virtual void AumentarSalario () {
            Salario *= 1.1;
        }

        //construtor
        public Funcionario (double _salario, string _cpf) {
            Console.WriteLine("Criando FUNCIONÁRIO");
            Salario = _salario;
            CPF = _cpf;
            TotalFuncionario++;
        }
    }
}
