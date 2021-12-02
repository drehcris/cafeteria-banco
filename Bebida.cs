using System;
using System.Collections.Generic;
using System.Text;

namespace Cafeteria
{
    class Bebida
    {
        public string acucar;
        public string pagamento;

        public virtual void cadastrarBebida()
        {
            Console.WriteLine("Com açucar? [s/n]");
            acucar = Console.ReadLine();
            Console.WriteLine("Qual vai ser a forma de pagamento? Cartão ou Dinheiro [c/d]");
            pagamento = Console.ReadLine();
            Console.WriteLine("Espere ser chamado até o caixa para ter mais informações");
        }   
    }
}


