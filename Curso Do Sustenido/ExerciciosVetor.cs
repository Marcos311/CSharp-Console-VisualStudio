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

        public static void exercicio3()
        {

            int N;

            N = int.Parse(Console.ReadLine());

            int[] vetA = new int[N];
            int[] vetB = new int[N];
            int[] vetC = new int[N];

            string[] stringA = Console.ReadLine().Split(' ');
            string[] stringB = Console.ReadLine().Split(' ');

            for(int i = 0; i < N; i++)
            {
                vetA[i] = int.Parse(stringA[i]);
                vetB[i] = int.Parse(stringB[i]);
            }

            for(int i = 0; i < N; i++)
            {
                vetC[i] = vetA[i] + vetB[i];
            }

            for(int i =0; i < N; i++)
            {
                Console.Write(vetC[i] + " ");
            }

            Console.ReadKey();
        }

        public static void exercise4()
        {
            int N = int.Parse(Console.ReadLine());

            double[] values = new double[N];

            string[] s = Console.ReadLine().Split(' ');

            for(int i = 0; i < N; i++)
            {
                values[i] = double.Parse(s[i], CultureInfo.InvariantCulture);
            }

            double sum = 0.0;

            for(int i = 0; i < N; i++)
            {
                sum = sum + values[i];
            }

            double average = sum / N;
            
            Console.WriteLine("AVERAGE = " + average.ToString("F3", CultureInfo.InvariantCulture));

            for(int i = 0; i < N; i++)
            {
                if (values[i] < average)
                {
                    Console.WriteLine(values[i].ToString("F1", CultureInfo.InvariantCulture));
                }
            }

            Console.ReadKey();

        }

        public static void exercise5()
        {
            int N = int.Parse(Console.ReadLine());

            int[] array = new int[N];

            string[] v = Console.ReadLine().Split();

            for(int i = 0; i < N; i++)
            {
                array[i] = int.Parse(v[i]);
            }

            double sum = 0;
            int count = 0;

            for(int i=0; i < N; i++)
            {
                if(array[i] % 2 == 0)
                {
                    sum += array[i];
                    count += 1;
                }
            }

            if(count == 0)
            {
                Console.WriteLine("there was no even number");
            }
            else
            {
                sum = sum / count;
                Console.WriteLine(sum.ToString("F1", CultureInfo.InvariantCulture));
            }

            Console.ReadKey();
        }
    }
}
