using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio2_ContaAcme_correcao_
{
    class Poupanca :Conta
    {


        public Poupanca(string numeroConta, string nomeCorrentista, double saldoAtual) : base(numeroConta, nomeCorrentista)
        {

        }

        public override void Sacar()
        {
            throw new NotImplementedException();
        }

        public override void TransferirParaOutraConta(double quantia, Conta contaDestino)
        {
            throw new NotImplementedException();
        }
    }
}
