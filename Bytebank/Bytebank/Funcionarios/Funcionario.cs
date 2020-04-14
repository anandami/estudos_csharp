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

        //método estático para somar o total de funcionarios que forem criados durante a execução
        public static int TotalFuncionario { get; private set; }

        //métodos abstratos - não contém lógica interna
        public abstract double GetBonificacao ();

        public abstract void AumentarSalario ();

        //construtores
        /*por padrão, o salario inicial será R$1500,00, então poderia deixar este código abaixo descomentado
        public Funcionario (string _cpf) {
            Console.WriteLine("Criando FUNCIONÁRIO");
            Salario = 1500;
            CPF = _cpf;
            TotalFuncionario++;
        }
            ou fazer um mais economico que tem o mesmo significado:
        */

        public Funcionario (string _cpf) : this(1500, _cpf) {
            // o this no construtor indica qual construtor será executado antes
        }
        public Funcionario(double _salario, string _cpf) {
            Salario = _salario;
            CPF = _cpf;
            TotalFuncionario++;
        }

    }
}
