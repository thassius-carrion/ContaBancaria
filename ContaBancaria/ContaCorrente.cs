using System;

namespace ContaBancaria
{
    class ContaCorrente : IConta
    {
        public int Agencia { get; }
        public int Numero { get; }
        public double Saldo { get; set; }

        public ContaCorrente(int Agencia, int Numero)
        {
            this.Agencia = Agencia;
            this.Numero = Numero;
            this.Saldo = 0;
        }

        public void Pagar(ITipoPagamento Tipo, double Valor)
        {
          this.Saldo =- Tipo.Pagar(Valor);
        }


    }
}
