using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafeteria
{
    class Classicos : Bebidas
    {
        public void cadastrarClassicos()
        {
            Console.WriteLine("Você escolheu Clássicos. Escolha uma das opçoes abaixo:");
            Console.WriteLine("1D - Café Latte - R$ 11,00");
            Console.WriteLine("2D - Flat White - R$ 11,00");
            Console.WriteLine("3D - Café Mocha - R$ 14,00");
            Console.WriteLine("4D - Café Mocha Branco - R$ 12,00");
            Console.WriteLine("5D - Doce de Leite Latte - R$ 14,00");
            Console.WriteLine("6D - Brigadeiro Latte - R$ 14,00");
            Console.WriteLine("S - Sair");

            string opcao;
            opcao = Console.ReadLine();
            Console.WriteLine("Voce escolheu {0}", opcao);
        }
    }
}

