using System;
using System.Collections.Generic;
using System.Text;

namespace Cafeteria
{
    class Salgados : Comida
    {
        public void cadastrarSalgados()
        {
            Console.WriteLine("Você escolheu Salgados. Escolha uma das opçoes abaixo:");
            Console.WriteLine("1G - Coxinha de frango - R$ 7,50");
            Console.WriteLine("2G - Croissant de frango - R$ 8,00");
            Console.WriteLine("3G - Croissant presunto e queijo - R$ 8,00");
            Console.WriteLine("4G - Croissant Multigrãos - R$ 8,00");
            Console.WriteLine("5G - Mini pão de queijo (10 unid) - R$ 14,00");
            Console.WriteLine("6G - Toast de Presunto e Mussarela - R$ 15,00");
            Console.WriteLine("7G - Toast de Peito de Peru e Mussarela - R$ 15,00");
            Console.WriteLine("9G - Torrada Petrópolis - R$ 6,00");
            Console.WriteLine("10G - Croque Monsieur - R$ 20,00");
            Console.WriteLine("S - Sair");

            string opcao;
            opcao = Console.ReadLine();
        }
    }
}

