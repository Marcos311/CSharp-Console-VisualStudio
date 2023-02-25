using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_Do_Sustenido
{
    public class EXERCISESMATRICE
    {
        public static void exercise1()
        {
            int N = int.Parse(Console.ReadLine());
            int[,] A;

            A = new int[N, N];

            for(int i = 0; i < N; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    A[i, j] = int.Parse(s[j]);
                }
            }

            Console.WriteLine("Leading Diagonal:");
            for(int i=0; i < N; i++){
                Console.Write(A[i, i] + " ");
            };

            Console.WriteLine();

            int count = 0;

            for(int i = 0; i < N; i++)
            {
                for(int j=0; j < N; j++)
                {
                    if(A[i, j] < 0)
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine("AMOUNT OF NEGATIVE NUMBERS : " + count);

            Console.ReadKey();
        }

        public static void exercise2()
        {
            int M, N;

            string[] s = Console.ReadLine().Split();

            M = int.Parse(s[0]);
            N = int.Parse(s[1]);

            int[,] A;
            A = new int[M, N];

            for(int i = 0; i < M; i++){
                string[] v = Console.ReadLine().Split();
                for(int j=0; j < N; j++)
                {
                    A[i, j] = int.Parse(v[j]);
                }
            }

            int[] vet = new int[M];

            for(int i = 0; i < M; i++)
            {
                int sum = 0;
                for(int j = 0; j < N; j++)
                {
                    sum += A[i, j];
                }
                vet[i] = sum;
            }

            for(int i=0; i < M; i++)
            {
                Console.WriteLine(vet[i]);
            }

            Console.ReadKey();
        }
    }
}
