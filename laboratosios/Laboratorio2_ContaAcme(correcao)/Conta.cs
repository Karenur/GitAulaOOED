using System;
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

        protected Conta(string numeroConta, string nomeCorrentista)
        {
            this.numeroConta = numeroConta;
            this.nomeCorrentista = nomeCorrentista;
            this.saldoAtual = 0;
        }

        public string NumeroConta { get => numeroConta;}
        public string NomeCorrentista { get => nomeCorrentista;}
        public double SaldoAtual { get => saldoAtual;}

        public virtual void Sacar(double quantia,double tarifaSaque)
        {
            double valorDebitado = quantia * (1 + tarifaSaque);


            if (SaldoAtual >= (SaldoAtual + valorDebitado))
            {
                RedusirSaldo(valorDebitado);
            }
            else
            {
                throw new Exception("Nao foi possivel realizar saque");
            }

        }

        public virtual void TransferirParaOutraConta(double quantia, Conta contaDestino, double tarifaTransferir)
        {
            double valorDebitado = quantia * (1 + tarifaTransferir);


            if (SaldoAtual >= (SaldoAtual + valorDebitado))
            {
                RedusirSaldo(valorDebitado);
                contaDestino.DepositarQuantia(quantia);
            }
            else
            {
                throw new Exception("Nao foi possivel realizar transferencia");
            }

        }

        public double VerificarSaldo()
        {
            return saldoAtual;
        }

        public void DepositarQuantia(double quantia)
        {
            AumentarSaldo(quantia);
        }

        protected void RedusirSaldo(double quantia)
        {
            saldoAtual -= quantia;
        }

        protected void AumentarSaldo(double quantia)
        {
            saldoAtual += quantia;
        }
        //public void RealizarDeposito(Conta conta, double quantia)
        //{
        //    conta.DepositarQuantia(quantia);
        //    Console.WriteLine($"{conta.NomeCorrentista} depositou {quantia.ToString("C")} em sua conta");
        //}

        //public void RealizarSaque(Conta conta, double quantia)
        //{
            
        //    Console.WriteLine($"{conta.NomeCorrentista} depositou {quantia.ToString("C")} em sua conta");
        //}

        //public void RealizarTransferencia(Conta contaOrigem, Conta contaDestino, double quantia)
        //{
        //      contaOrigem.TransferirParaOutraConta(quantia, contaDestino);

        //}

    }

}