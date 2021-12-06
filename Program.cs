using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafeteria
{
    class Program
    {
        static void Main(string[] args)
        {
                string opcao;
                Menu menu = new Menu();
                MySql091121 mys = new MySql091121();
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
                            mys.chec();
                           
                        break;
                        case "2":
                            Console.WriteLine("Chá");
                            Chas chas = new Chas();
                            chas.cadastrarChas();
                            chas.cadastrarBebida();
                            mys.chec();
                        break;
                        case "3":
                            Console.WriteLine("Chocolates");
                            Chocolates chocolates = new Chocolates();
                            chocolates.cadastrarChocolates();
                            chocolates.cadastrarBebida();
                            mys.chec();
                        break;
                        case "4":
                            Console.WriteLine("Clássicos");
                            Classicos classicos = new Classicos();
                            classicos.cadastrarClassicos();
                            classicos.cadastrarBebida();
                            mys.chec();
                        break;
                        case "5":
                            Console.WriteLine("Frappuccinos");
                            Frappuccinos frappuccinos = new Frappuccinos();
                            frappuccinos.cadastrarFrappuccinos();
                            frappuccinos.cadastrarBebida();
                            mys.chec();
                        break;
                        case "6":
                            Console.WriteLine("Doces");
                            Doces doces = new Doces();
                            doces.cadastrarDoces();
                            doces.cadastrarComida();
                            mys.chec();
                        break;
                        case "7":
                            Console.WriteLine("Salgados");
                            Salgados salgados = new Salgados();
                            salgados.cadastrarSalgados();
                            salgados.cadastrarComida();
                            mys.chec();
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