using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafeteria
{
    class Chas : Bebidas
    {
        public void cadastrarChas()
        {
            Console.WriteLine("Você escolheu Chás. Escolha uma das opçoes abaixo:");
            Console.WriteLine("1B - Chá Verde - R$ 8,00");
            Console.WriteLine("2B - Chá Preto - R$ 8,00");
            Console.WriteLine("3B - Chá Verde Latte - R$ 10,00");
            Console.WriteLine("4B - Chá Preto Gelado - R$ 8,00");
            Console.WriteLine("5B - Chá Verde Gelado - R$ 8,00");
            Console.WriteLine("6B - Chá Preto Gelado com Limonada - R$ 10,00");
            Console.WriteLine("7B - Chá Verde Gelado com Limonada - R$ 10,00");
            Console.WriteLine("8B - Chá Preto com Blueberry - R$ 10,00");
            Console.WriteLine("S - Sair");

            string opcao;
            opcao = Console.ReadLine();
            Console.WriteLine("Voce escolheu {0}", opcao);
        }
    }
}

