using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_Do_Sustenido
{
    class AULA08
    {
        public static void LendoValoresTeclado()
        {
            int v1, v2, soma;
            string nome;

            Console.Write("Digite o primeiro valor: ");
            v1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo valor: ");
            v2 = Convert.ToInt32(Console.ReadLine());
            soma = v1 + v2;
            Console.WriteLine("A soma de {0} + {1} é igual a {2}", v1,v2,soma);

            Console.ReadKey();
        }
    }
}
