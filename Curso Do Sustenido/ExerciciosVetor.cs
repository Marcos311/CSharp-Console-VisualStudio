using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Curso_Do_Sustenido
{
    public class ExerciciosVetor
    {
        public static void exercicio1()
        {
            int N;
            double[] vet;
            N = int.Parse(Console.ReadLine());

            vet = new double[N];

            string[] v = Console.ReadLine().Split(' ');

            for(int i=0; i < N; i++)
            {
                vet[i] = double.Parse(v[i], CultureInfo.InvariantCulture);
            }

            double bigger = vet[0];
            int Biggestposition = 0;

            for (int i=0; i < N; i++)
            {
                if (vet[i] > bigger)
                {
                    bigger = vet[i];
                    Biggestposition = i;
                }
            }

            Console.WriteLine(bigger.ToString("F1", CultureInfo.InvariantCulture));
            Console.WriteLine(Biggestposition);

            Console.ReadKey();
        }

        public static void exercicio2()
        {
            int N = int.Parse(Console.ReadLine());

            int[] vet = new int[N];

            string[] s = Console.ReadLine().Split(' ');

            for(int i=0; i<N; i++)
            {
                vet[i] = int.Parse(s[i]);
            }

            int count = 0;

            for(int i=0; i<N; i++)
            {
                if(vet[i] % 2 == 0)
                {
                    Console.Write(vet[i] + " ");
                    count++;

                    if(i == N - 1)
                    {
                        Console.WriteLine();
                    }
                }
            }



            Console.WriteLine(count);

            Console.ReadKey();

        }
    }
}
