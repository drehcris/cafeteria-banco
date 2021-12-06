using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafeteria
{
    class Doces : Comida
    {
        public void cadastrarDoces()
        {
            Console.WriteLine("Você escolheu Doces. Escolha uma das opçoes abaixo:");
            Console.WriteLine("1F - Bolo de Cenoura - R$ 8,00");
            Console.WriteLine("2F - Bolo Red Velvet - R$ 15,00");
            Console.WriteLine("3F - Brownie Espresso - R$ 9,00");
            Console.WriteLine("4F - Cookie de Chocolate com Gotas de Chocolate - R$ 8,00");
            Console.WriteLine("5F - Cookie de Baunilha com Gotas de Chocolate - R$ 8,00");
            Console.WriteLine("6F - Donuts Chocoberrye - R$ 9,00");
            Console.WriteLine("7F - Muffin Chocolatee - R$ 9,50");
            Console.WriteLine("8F - Muffin Blueberry - R$ 9,00");
            Console.WriteLine("9F - Donuts Chocoberrye - R$ 9,00");
            Console.WriteLine("10F - Pão de Mel - R$ 6,00");
            Console.WriteLine("11F - Bolo Triplo Brigadeiro - R$ 17,00");
            Console.WriteLine("S - Sair");

            string opcao;
            opcao = Console.ReadLine();
            Console.WriteLine("Voce escolheu {0}", opcao);
        }
    }
}
 
    
