using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Curso_Do_Sustenido
{
    class exerciciosArray
    {
        public void exercicio1()
        {
            int N;
            int[] vet;

            N = int.Parse(Console.ReadLine());
            vet = new int[N];

            string[] s = Console.ReadLine().Split(' ');

            for(int i=0; i < N; i++)
            {
                vet[i] = int.Parse(s[i]);
            }

            for (int i = 0; i < N; i++)
            {
                if(vet[i] < 0)
                {
                    Console.WriteLine(vet[i]);
                }
            }
            Console.ReadKey();
        }

        public void exercicio2()
        {
            int N;
            double[] vet;

            N = int.Parse(Console.ReadLine());
            vet = new double[N];

            string[] s = Console.ReadLine().Split(' ');

            for(int i=0; i < N; i++)
            {
                vet[i] = double.Parse(s[i], CultureInfo.InvariantCulture);
            }

            for(int i=0; i < N; i++)
            {
                Console.Write(vet[i].ToString("F1", CultureInfo.InvariantCulture) + ' ');
            }
            Console.WriteLine();

            double sum = 0.0;

            for(int i=0; i < N; i++)
            {
                sum = sum + vet[i];
            }

            double average = 0.0;
            average = sum / N;

            Console.WriteLine(sum.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(average.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadKey();
        }
    }
}
