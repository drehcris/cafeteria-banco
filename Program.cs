using System;

namespace Cafeteria
{
    class Program : Menu
    {
        static void Main(string[] args)
        {
            string opcao;
            Menu menu = new Menu();
            do
            {
                opcao = menu.menu();
                switch (opcao)
                {
                    case "1":
                        Console.WriteLine("Café");
                        Cafe cafe = new Cafe();
                        cafe.cadastrarCafe();
                        cafe.cadastrarBebida();                      
                        break;
                    case "2":
                        Console.WriteLine("Chá");
                        Chas chas = new Chas();
                        chas.cadastrarChas();
                        chas.cadastrarBebida();
                        break;
                    case "3":
                        Console.WriteLine("Chocolates");
                        Chocolates chocolates = new Chocolates();
                        chocolates.cadastrarChocolates();
                        chocolates.cadastrarBebida();
                        break;
                    case "4":
                        Console.WriteLine("Clássicos");
                        Classicos classicos = new Classicos();
                        classicos.cadastrarClassicos();
                        classicos.cadastrarBebida();
                        break;
                    case "5":
                        Console.WriteLine("Frappuccinos");
                        Frappuccinos frappuccinos = new Frappuccinos();
                        frappuccinos.cadastrarFrappuccinos();
                        frappuccinos.cadastrarBebida();
                        break;
                    case "6":
                        Console.WriteLine("Doces");
                        Doces doces = new Doces();
                        doces.cadastrarDoces();
                        doces.cadastrarComida();
                        break;
                    case "7":
                        Console.WriteLine("Salgados");
                        Salgados salgados = new Salgados();
                        salgados.cadastrarSalgados();
                        salgados.cadastrarComida();
                        break;
                    case "S":
                        Console.WriteLine("Encerrando o programa");
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            } while (opcao != "S");
            //Environment.Exit(0);
        }
    }
}