using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio2_Conta
{
    class Corrente : Conta
    {
        public Corrente(string numeroIdentificacao, string nomeCorrentista) : base(numeroIdentificacao,nomeCorrentista)
        {

        }

        public override string SacarDinheiro(double valorASacar)
        {
            const double tarifaSaque = 0.37 / 100;

            if (saldoAtual >= valorASacar * tarifaSaque)
            {
                saldoAtual = saldoAtual - valorASacar - tarifaSaque;
                return "Operacao realizado com suceso.";
            }
            else
            {
                return "Saldo insuficiente";
            }
        }

        public override string TransferirDinheiro(Conta contaATransferir, double valorTranseferido)
        {
            const double tarifaSaque = 0.10 / 100;
            if (saldoAtual >= valorTranseferido * tarifaSaque)
            {
                saldoAtual = saldoAtual - valorTranseferido - tarifaSaque;
                contaATransferir.DepositarDinheiro(valorTranseferido);
                return "Operacao realizado com suceso.";
            }
            return "Saldo insuficiente";
        }
    }
}
