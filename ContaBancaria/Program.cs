using System;

namespace ContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta1 = new ContaCorrente();

            conta1.Credito(1000);
            conta1.Debito(27000);

            Console.WriteLine("Sua Fatura do mes ficou no valor total de: R$ " + conta1.FechamentoMes());
        }
    }
}
