using System;
using Bytebank;


public class OperacaoFinanceiraException:Exception{
    //Construtores 
    public OperacaoFinanceiraException(){

    }
    public OperacaoFinanceiraException(string mensagem):base(mensagem){

    }

    public OperacaoFinanceiraException(string mensagem, Exception innerException) 
        : base (mensagem, innerException){

    }

    
}