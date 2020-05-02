using System;
using Bytebank;

namespace Bytebank.Contas{
    public class SaldoInsuficienteException: Exception{
        //construtor
        public SaldoInsuficienteException(string mensagem) : base(mensagem){
            
        }
    }
}