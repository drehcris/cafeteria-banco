using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafeteria
{
    class Chocolates : Bebidas
    {
        public void cadastrarChocolates()
        {
            Console.WriteLine("Você escolheu Chocolates. Escolha uma das opçoes abaixo:");
            Console.WriteLine("1C - Chocolate Clássico - R$ 12,00");
            Console.WriteLine("2C - Chocolate Branco - R$ 12,00");
            Console.WriteLine("3C - Chocolate Clássico Gelado - R$ 12,00");
            Console.WriteLine("4C - Chocolate Branco Gelado - R$ 12,00");
            Console.WriteLine("5C - Chocomenta Mocha - R$ 14,00");
            Console.WriteLine("6C - Brigadeiro Latte - R$ 14,00");
            Console.WriteLine("S - Sair");

            string opcao;
            opcao = Console.ReadLine();
            Console.WriteLine("Voce escolheu {0}", opcao);
        }
    }
}
 

  