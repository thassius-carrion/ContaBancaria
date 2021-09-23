using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria
{
    class PagamentoDebito : ITipoPagamento
    {
        private double TaxaDebito = 0.01; 
        public double Pagar(double Valor)
        {
            return Valor * TaxaDebito;
        }
    }
}
