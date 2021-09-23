using System;

namespace ContaBancaria
{
    class ContaCorrente : IConta
    {
        public int Agencia { get; }
        public int Numero { get; }
        public double Saldo { get; set; }
        public double GastoTotal { get; set; }

        public ContaCorrente(int Agencia, int Numero)
        {
            this.Agencia = Agencia;
            this.Numero = Numero;
            this.Saldo = 0;
        }

        public void Saida(ITipoPagamento Tipo, double Valor)
        {
            if(ContaService.VerificarSaldo(this.Saldo, Valor) == true)
            {
                this.Saldo = this.Saldo - Valor - Tipo.TaxaSaida(Valor);
                this.GastoTotal = this.GastoTotal + Valor;
            }
        }

        public void Entrada(double Valor)
        {
            this.Saldo =+ Valor;
        }

        public void FechamentoDeMes()
        {
            var FaturaMensal = ContaService.FechamentoDeMes(GastoTotal);
            Console.WriteLine("Fatura Mensal incluindo Imposto: " + FaturaMensal.ToString("C"));
        }
    }
}
