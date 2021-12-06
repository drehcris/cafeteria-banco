using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafeteria
{
    class Comida
    {
        public string pagamento;

        public virtual void cadastrarComida()
        {
            Console.WriteLine("Qual vai ser a forma de pagamento? Cartão ou Dinheiro [c/d]");
            pagamento = Console.ReadLine();
            Console.WriteLine("Espere ser chamado até o caixa para ter mais informações");
        }
    }
}
