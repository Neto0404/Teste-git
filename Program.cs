using System;

namespace Italia_Lancheria_ControleCaixa
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Qual o valor inicial do caixa?");
           double CaixaI = Controle.Caixa(double.Parse(Console.ReadLine()));
        

            Console.WriteLine("Caixa Aberto Com : " + CaixaI);

            while (DateTime.Now.Hour < 14 && DateTime.Now.Hour > 6)
            {
                Controle.Controlar();
            }
        }
    }
}
