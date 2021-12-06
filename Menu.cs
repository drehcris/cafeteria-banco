using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafeteria
{
    class Menu
    {
        public string menu()
        {
            Console.WriteLine("Bem vindo(a)! Escolha uma das seguintes opçoes:");
            Console.WriteLine("1 - Café");
            Console.WriteLine("2 - Chá");
            Console.WriteLine("3 - Chocolates");
            Console.WriteLine("4 - Classicos");
            Console.WriteLine("5 - Frappuccinos");
            Console.WriteLine("6 - Doce");
            Console.WriteLine("7 - Salgado");
            Console.WriteLine("8 - Qual vai ser a forma de pagamento?");
            Console.WriteLine("\t 8A - Cartão");
            Console.WriteLine("\t 8B - Dinheiro");
            Console.WriteLine("S - Sair");

            string opcao;
            opcao = Console.ReadLine();
            return opcao.ToUpper();

        }
    }
}
