using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria
{
    interface IConta
    {
        int Agencia { get; }
        int Numero { get; }
        double Saldo { get; }

        void Saida(ITipoPagamento Tipo, double Valor);

        void Entrada(double Valor);
    }
}
