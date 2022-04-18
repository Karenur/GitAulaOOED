﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio2_ContaAcme_correcao_
{
    abstract class Conta
    {
        string numeroConta;
        string nomeCorrentista;
        double saldoAtual;

        protected Conta(string numeroConta, string nomeCorrentista, double saldoAtual)
        {
            this.numeroConta = numeroConta;
            this.nomeCorrentista = nomeCorrentista;
            this.saldoAtual = 0;
        }

        public string NumeroConta { get => numeroConta;}
        public string NomeCorrentista { get => nomeCorrentista;}
        public double SaldoAtual { get => saldoAtual;}

        public abstract void Sacar();
        public abstract void TransferirParaOutraConta(double quantia, Conta contaDestino);
        public abstract void Depositar();


    }
}