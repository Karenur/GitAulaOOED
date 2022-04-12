using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio2_Conta
{
    class Conta
    {
        protected string idConta;
        protected string nomeCorrentista;
        protected double saldoAtual;

        public Conta(string numeroIdentificacao, string nomeCorrentista)
        {
            this.idConta = numeroIdentificacao;
            this.nomeCorrentista = nomeCorrentista;
            this.saldoAtual = 0;
        }

        public string NumeroIdentificacao
        {
            get
            {
                return idConta;
            }
        }

        public string NomeCorrentista
        {
            get
            {
                return nomeCorrentista;
            }
        }

        public double SaldoAtual
        {
            get
            {
                return saldoAtual;
            }
        }

        public virtual string SacarDinheiro(double valorASacar)
        {
            
            return "Saldo insuficiente";

        }

        public void DepositarDinheiro(double valorADepositar)
        {
            saldoAtual += valorADepositar;
        }

        public virtual string TransferirDinheiro(Conta contaATransferir, double valorDranferido)
        {
            return "Saldo insuficiente";
        }

        public string VerificarSaldo()
        {

            return $"Saldo na conde de {nomeCorrentista}, é de " + saldoAtual.ToString("C");
            
        }

    }
}
