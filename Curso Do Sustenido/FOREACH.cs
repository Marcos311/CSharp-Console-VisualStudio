using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_Do_Sustenido
{
    public class FOREACH
    {
        public static void foreachi(){

            int N;
            N = int.Parse(Console.ReadLine());
            string[] vet = new string[N];

            for(int i=0; i<N; i++)
            {
                vet[i] = Console.ReadLine();
            }

            Console.WriteLine("names read :");
            foreach (string element in vet)
            {
                Console.WriteLine(element);
            }

            Console.ReadKey();
        }

    }
}
