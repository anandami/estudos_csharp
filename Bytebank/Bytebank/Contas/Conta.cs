using Bytebank.Clientes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bytebank.Contas {
    public abstract class Conta {
        
        //Propriedades
        public ClienteCorrente Titular { get; set; }
        public int Agencia { get; } //valor readonly - somente setado no construtor
        public int Numero { get; } //valor readonly - somente setado no construtor
        private double _saldo = 100;
        public int ContadorSaquesNaoPermitidos { get; private set; }
        public int ContadorTransferenciasNaoPermitidas { get; private set; }


        public double Saldo{
            get{
                return _saldo;
            }
            set{
                if (value < 0){
                    return;
                }
                _saldo = value;
            }
        }
       
        public static int TotalContas { get; private set; }

        //construtor
        public Conta(int agencia, int numero) {
            System.Console.WriteLine("Iniciando criacao de conta.......");
            
            if (agencia <= 0){
                throw new ArgumentException("Agencia com valor menor ou igual a zero.", nameof(agencia));
            }
            if (numero <=0){
                throw new ArgumentException("Numero da conta com valor menor ou igual a zero.", nameof(numero));
            }
            //atribuicao
            Agencia = agencia;
            Numero = numero;

            TotalContas++;
        }

        //Métodos 
        public void Sacar(double valor){
            //saldo menor que o valor requerido
            if (_saldo < valor){
                throw new SaldoInsuficienteException(_saldo, valor);
            }
            //valor negativo
            if (valor < 0){
                throw new ArgumentException("Valor negativo não permitido.", nameof(valor));
            }
            Saldo -= valor;
        }
        public void Depositar(double valor){
            Saldo += valor;
            
        }

        public void Transferir(double valor, Conta contaDestino){
            if (valor < 0){
                throw new ArgumentException("Valor inválido para a transferência.", nameof(valor));
            }
            try{
                Sacar(valor);
            }catch(SaldoInsuficienteException ex){
                ContadorTransferenciasNaoPermitidas++;
                throw new OperacaoFinanceiraException("Operação não realizada.", ex);
            }
            
            contaDestino.Depositar(valor);
        }
    }
}
