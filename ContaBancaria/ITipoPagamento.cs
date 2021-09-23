using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria
{
    interface ITipoPagamento
    {
       // public int Valor { get; }

        public double Pagar(double Valor);
    }
}
