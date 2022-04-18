using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio2_ContaAcme_correcao_
{
    class Poupanca :Conta
    {
        const double tarifaSaque = 0.20 / 100;
        const double tarifaTransferir = 0.15 / 100;

        public Poupanca(string numeroConta, string nomeCorrentista) : base(numeroConta, nomeCorrentista)
        {

        }

        public void Sacar(double quantia)
        {
            base.Sacar(quantia, tarifaSaque);
        }

        public void TransferirParaOutraConta(double quantia, Conta outraConta)
        {
            base.TransferirParaOutraConta(quantia, outraConta, tarifaTransferir);
        }
    }
}
