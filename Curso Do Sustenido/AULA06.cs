using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_Do_Sustenido
{
    class AULA06
    {
        public void Digita()
        {
            int n1, n2, n3;

            n1 = 10; n2 = 20; n3 = 30;

            Console.Write("\nn1=\t{0}\nn2=\t{1}\nn3=\t{2}\n" ,n1,n2,n3);

            Console.ReadKey();
        }

        public void Metodo2()
        {
            double valorCompra = 5.50;
            double valorVenda;
            double lucro = 0.1;
            string produto = "pastel";

            valorVenda = valorCompra * lucro;

            Console.WriteLine("Produto.......:{0,15}", produto);
            Console.WriteLine("Val.Compra....:{0,15:c}", valorCompra);
            Console.WriteLine("Lucro.........:{0,15:p}", lucro);
            Console.WriteLine("Val.Venda.....:{0,15:c}", valorVenda);
            Console.ReadKey();
        }
    }
}
