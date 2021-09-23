using System;

namespace ContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta1 = new ContaCorrente(123, 222);
            ITipoPagamento credito = new PagamentoCredito();
            ITipoPagamento debito = new PagamentoDebito();

            conta1.Entrada(1000);
            conta1.Saida(debito, 100);
            conta1.Saida(credito, 200);
            conta1.Saida(credito, 200);
            conta1.Saida(credito, 200);
            conta1.Saida(debito, 100);

            Console.WriteLine(conta1.Saldo);

            conta1.FechamentoDeMes();
        }
    }
}
