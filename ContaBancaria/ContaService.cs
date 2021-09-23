using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria
{
    class ContaService
    {
        public static Boolean VerificarSaldo(double Saldo, double Valor)
        {
            if(Saldo < Valor)
            {
                Console.WriteLine("Saldo insuficiente");
                return false;
            }
            else
            {
                return true;
            }
        }

        public static double FechamentoDeMes(double GastoTotal)
        {
            return GastoTotal + Imposto.CalculoImposto(GastoTotal);
        }
    }
}
