using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio2_Conta
{
    class Corrente : Conta
    {
        public Corrente(string numeroIdentificacao, string nomeCorrentista) : base(numeroIdentificacao, nomeCorrentista)
        {

        }

        public override string SacarDinheiro(double valorASacar)
        {
            double tarifaSaque = 0.37 / 100;
            
            if (saldoAtual <= valorASacar + (valorASacar * tarifaSaque))
            {

                return "Saldo insuficiente, opercao cancelada";
            }
            else
            {                
                saldoAtual = saldoAtual - valorASacar -(valorASacar* tarifaSaque);
                return "Operacao realizado com suceso.";
            }
        }

        public override string TransferirDinheiro(Conta contaATransferir, double valorTranseferido)
        {
            const double tarifaSaque = 0.10 / 100;
            if (saldoAtual <= valorTranseferido + (valorTranseferido * tarifaSaque))
            {
                return "Saldo insuficiente, opercao cancelada";
            }
            else
            {
                saldoAtual = saldoAtual - valorTranseferido - (valorTranseferido * tarifaSaque);
                contaATransferir.DepositarDinheiro(valorTranseferido);
                return "Operacao realizado com suceso.";
            }
        }
    }
}
