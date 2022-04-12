using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio2_Conta
{
    class Poupanca: Conta
    {
        public Poupanca(string numeroIdentificacao, string nomeCorrentista) : base(numeroIdentificacao, nomeCorrentista)
        {

        }

        public override string SacarDinheiro(double valorASacar)
        {
            const double tarifaSaque = 0.20 / 100;

            if (saldoAtual <= valorASacar + (valorASacar* tarifaSaque))
            {

                return "Saldo insuficiente, opercao cancelada";
            }
            else
            {
                saldoAtual = saldoAtual - valorASacar - (valorASacar * tarifaSaque);
                return "Operacao realizado com suceso.";
            }
        }

        public override string TransferirDinheiro(Conta contaATransferir, double valorTranseferido)
        {
            const double tarifaSaque = 0.15 / 100;
            if (saldoAtual <= valorTranseferido + (valorTranseferido* tarifaSaque))
            {
                return "Saldo insuficiente, opercao cancelada";
            }
            else
            {
                saldoAtual = saldoAtual - valorTranseferido - (valorTranseferido* tarifaSaque);
                contaATransferir.DepositarDinheiro(valorTranseferido);
                return "Operacao realizado com suceso.";
            }
            
        }
    }
}
