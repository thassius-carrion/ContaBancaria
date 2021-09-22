using System;

namespace ContaBancaria
{
    class ContaCorrente
    {
        private double FaturaMensalTotal;

        public ContaCorrente()
        {
            this.FaturaMensalTotal = 0;
        }

        public void Debito(double Valor)
        {
            FaturaMensalTotal += Valor;
        }

        public void Credito(double Valor)
        {
            FaturaMensalTotal += Valor;
        }

        public double FechamentoMes()
        {
            return FaturaMensalTotal + Imposto.CalculoImposto(FaturaMensalTotal);
        }
    }
}
