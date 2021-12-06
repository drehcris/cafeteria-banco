using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafeteria
{
    class Cafe : Bebidas
    {
        public string opcao;

        public void cadastrarCafe()
        {
            Console.WriteLine("Você escolheu Café. Escolha uma das opçoes abaixo:");
            Console.WriteLine("1A - Café Mocha Branco - R$ 14,00");
            Console.WriteLine("2A - Café Mocha Branco Gelado - R$ 14,00");
            Console.WriteLine("3A - Café Latte - R$ 11,00");
            Console.WriteLine("4A - Café Mocha - R$ 14,00");
            Console.WriteLine("5A - Café Americano Gelado - R$ 8,00");
            Console.WriteLine("6A - Café com Leite - R$ 9,00");
            Console.WriteLine("7A - Café Americano - R$ 8,00");
            Console.WriteLine("8A - Café Filtrado/Dia - R$ 7,50");
            Console.WriteLine("9A - Doce de Leite Latte - R$ 14,00");
            Console.WriteLine("10A - Caramelo Macchiato Gelado - R$ 14,00");
            Console.WriteLine("S - Sair");


            string opcao;
            opcao = Console.ReadLine();
            Console.WriteLine("Voce escolheu {0}", opcao);

        }
    }
}
