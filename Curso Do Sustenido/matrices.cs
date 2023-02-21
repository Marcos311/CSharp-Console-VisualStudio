using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_Do_Sustenido
{
    class matrices { 
    
        public static void matrice() { 
            int M, N;
            int[,] A;

            string[] s1 = Console.ReadLine().Split(' ');
            M = int.Parse(s1[0]);
            N = int.Parse(s1[1]);
            A = new int[M, N];

            for(int i=0; i<M; 
                i++)
            {
                string[] v = Console.ReadLine().Split(' ');

                for(int j=0; j<N; j++)
                {
                    A[i, j] = int.Parse(v[j]);
                 }
            }

            for(int i=0; i<M; i++)
            {
                for(int j=0; j<N; j++)
                {
                    Console.Write(A[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
