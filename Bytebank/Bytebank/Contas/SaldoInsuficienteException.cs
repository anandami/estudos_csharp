using System;


namespace Bytebank.Contas{
    public class SaldoInsuficienteException: OperacaoFinanceiraException{
        
        //propriedades 
        double Saldo {get;}//setter privado
        double ValorSaque{get;}//setter privado

        //CONSTRUTORES PADRÃO PARA TODAS AS CLASSES DE EXCEÇÃO
        //construtor vazio
        public SaldoInsuficienteException(){

        }
        //construtuor com mensagem
        public SaldoInsuficienteException(string mensagem) : base(mensagem){
            
        }
        //construtor com mensagem e innerException
        public SaldoInsuficienteException(string mensagem, Exception excecaoInterna) 
            : base (mensagem, excecaoInterna){

        }

        //Construtor extra
        public SaldoInsuficienteException(double saldo, double valorSaque) 
            : this ("Tentativa de saque no valor de " + valorSaque + " com saldo disponivel de " + saldo){
                Saldo = saldo;
                ValorSaque = valorSaque;
            }
    }
}