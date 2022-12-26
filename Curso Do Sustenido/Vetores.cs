using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_Do_Sustenido
{
    public class Vetores
    {
        int[] A = new int[10];
        double[] B = new double[5];
        string[] C = new string[8];

        public void vetor()
        {
            double[] B = new double[5];

            A = new int[10];
            B = new double[5];
            C = new string[8];

            A[5] = 10;

            for(int i=0; i<5; i++)
            {
                B[i] = i + 10;
                Console.WriteLine(B[i]);
            }

            Console.ReadKey();
        }

        public void elementosVetor()
        {
            int N;
            double[] vet;

            N = int.Parse(Console.ReadLine());
            vet = new double[N];

            for (int i=0; i < N; i++){
                vet[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            for(int i=0; i<N; i++)
            {
                Console.WriteLine(vet[i].ToString("F1", CultureInfo.InvariantCulture));
            }

            Console.ReadKey();
        }


    }
}
