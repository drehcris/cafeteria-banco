using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafeteria
{
    class Frappuccinos : Bebidas
    {
        public void cadastrarFrappuccinos()
        {
            Console.WriteLine("Você escolheu Frappuccinos. Escolha uma das opçoes abaixo:");
            Console.WriteLine("1E - Frappuccino Baunilha - R$ 14,50");
            Console.WriteLine("2E - Frappuccino Brigadeiro - R$ 14,50");
            Console.WriteLine("3E- Frappuccino Caramelo - R$ 14,50");
            Console.WriteLine("4F - Frappuccino Chai - R$ 14,50");
            Console.WriteLine("5E - Frappuccino Chá Verde - R$ 14,50");
            Console.WriteLine("6E - Frappuccino Chocolate - R$ 14,50");
            Console.WriteLine("7E - Frappuccino Chocolate Branco - R$ 14,50");
            Console.WriteLine("8E - Frappuccino Doce de leite - R$ 14,50");
            Console.WriteLine("9E - Frappuccino Mocha - R$ 14,50");
            Console.WriteLine("10E - Frappuccino Mocha Branco - R$ 14,50");
            Console.WriteLine("S - Sair");

            string opcao;
            opcao = Console.ReadLine();
            Console.WriteLine("Voce escolheu {0}", opcao);
        }

    }
}