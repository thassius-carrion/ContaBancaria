using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria
{
    class Imposto
    {

        public static double CalculoImposto(double Valor)
        {
            if(Valor < 0)
            {
                throw new Exception("Valor de Fatura Invalido");
            }

            if(Valor <= 999)
            {
                return Valor * 0.02;
            }
            else if(Valor <= 2999)
            {
                return Valor * 0.025;
            }
            else if (Valor <= 6999)
            {
                return Valor * 0.028;
            }
            else
            {
                return Valor * 0.03;
            }
        }

    }
}
