using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria
{
    class PagamentoCredito : ITipoPagamento
    {
        private double TaxaCredito = 0.02; 
        public double TaxaSaida(double Valor)
        {
            return Valor * TaxaCredito;
        }
    }
}
