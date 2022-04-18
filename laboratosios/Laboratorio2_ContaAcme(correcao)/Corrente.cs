using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio2_ContaAcme_correcao_
{
    class Corrente : Conta
    {
        const double tarifaSaque = 0.37 / 100;
        const double tarifaTransferir = 0.10 / 100;

        public Corrente(string numeroConta, string nomeCorrentista, double saldoAtual):base(numeroConta,nomeCorrentista)
        {
            
        }

        public  void Sacar(double quantia)
        {
            base.Sacar(quantia, tarifaSaque);
        }

        public void TransferirParaOutraConta(double quantia, Conta outraConta)
        {
            base.TransferirParaOutraConta(quantia, outraConta, tarifaTransferir);
        }
    }
}
