﻿using Bytebank.Clientes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bytebank.Contas {
    public abstract class Conta {

        public ClienteCorrente Titular { get; set; }
        public int Agencia { get; } //valor readonly - somente setado no construtor
        public int Numero { get; } //valor readonly - somente setado no construtor
        public double Saldo { get; set; }

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
    }
}
