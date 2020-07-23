using System;
using System.Collections.Generic;
using System.Text;

namespace Italia_Lancheria_ControleCaixa
{
    class Controle
    {
        public static double ValorInicialCaixa { get; set; }
        public static double ValorAtualCaixa  { get; set;}
        public static float i { get; set; }
        
        public static double Controlar()
        {
            Console.WriteLine();


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
            
            
            if (i == 0)
            {
                ValorAtualCaixa = ((ValorInicialCaixa + notaC) - troco);
                i++;
                Console.WriteLine("Valor atual no caixa é de: " + ValorAtualCaixa);
                return ValorAtualCaixa;

            }
            else
            {
                ValorAtualCaixa = ((ValorAtualCaixa + notaC) - troco);
                i++;
                Console.WriteLine("Valor atual no caixa é de: " + ValorAtualCaixa);
                return ValorAtualCaixa;
            }
        }
        
        public static double Caixa(double valor)
        {
            
            ValorInicialCaixa =valor;
            return ValorInicialCaixa;
        }
    }
}
