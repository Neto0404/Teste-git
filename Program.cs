using System;

namespace Italia_Lancheria_ControleCaixa
{
    class Program
    {
        static void Main(string[] args)
        {
            while (DateTime.Now.Hour < 14 && DateTime.Now.Hour > 6)
            {
                Console.WriteLine("Qual o valor inicial do caixa?");
                double ValorInicialCaixa = double.Parse(Console.ReadLine());

                Console.WriteLine();
                Console.WriteLine("Caixa Aberto Com : " + ValorInicialCaixa);

                Console.WriteLine("incira o valor da nota que o cliente pagou: ");
                double notaC = double.Parse(Console.ReadLine());

                Console.WriteLine("Quanto o Cliente Gastou? : ");
                double contaCliente = double.Parse(Console.ReadLine());

                double troco = (notaC - contaCliente);

                if (notaC < contaCliente)
                {
                    Console.WriteLine("Ainda falta dinheiro");
                }
                else
                {

                    Console.WriteLine("Valor do troco: " + troco);
                }
                double ValorAtualCaixa = ((ValorInicialCaixa + notaC) - troco);
                Console.WriteLine("Valor atual no caixa é de: "+ValorAtualCaixa);


            }
        }
    }
}
