using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Curso_Do_Sustenido
{
    public class EXTRAMATRIXEXERCISES
    {
        public static void exercise1()
        {
            int M, N;            
            string[] s = Console.ReadLine().Split(' ');
            M = int.Parse(s[0]);
            N = int.Parse(s[1]);
            int[,] A = new int[M, N];


            for (int i = 0; i < M; i++)
            {
                string[] v = Console.ReadLine().Split(' ');
                for(int j = 0; j < N; j++)
                {
                    A[i, j] = int.Parse(v[j]);
                }
            }

            Console.WriteLine("NEGATIVE VALUES : ");
            for(int i = 0; i < M; i++)
            {
                for(int j = 0; j < N; j++)
                {
                    if(A[i,j] < 0)
                    {
                        Console.WriteLine(A[i, j]);
                    }
                }
            }

            Console.ReadKey();
        }

        public static void exercise2()
        {
            int N = int.Parse(Console.ReadLine());
            int[,] A = new int[N, N];

            for(int i = 0; i < N; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                for(int j = 0; j < N; j++)
                {
                    A[i, j] = int.Parse(s[j]);
                }
            }

            int[] vet = new int[N];

            for(int i = 0; i < N; i++)
            {
                int sum = 0;
                for(int j = 0; j < N; j++)
                {
                    sum += A[i, j];
                }
                vet[i] = sum;
            }

            for(int i = 0; i < N; i++)
            {
                Console.WriteLine(vet[i]);
            }

            Console.ReadKey();
        }

        public static void exercise3()
        {
            int N = int.Parse(Console.ReadLine());

            int[,] Mat = new int[N, N];

            for(int i = 0; i < N; i++)
            {
                string[] v = Console.ReadLine().Split(' ');
                for(int j = 0; j < N; j++)
                {
                    Mat[i, j] = int.Parse(v[j]); 
                }
            }

            int[] vet = new int[N];

            for(int i = 0; i < N; i++)
            {
                int biggerNumber = Mat[i, 0];
                for(int j = 0; j < N; j++)
                {
                    if(Mat[i, j] > biggerNumber)
                    {
                        biggerNumber = Mat[i, j];
                    }
                }
                vet[i] = biggerNumber;
            }

            for(int i = 0; i < N; i++)
            {
                Console.WriteLine(vet[i]);
            }
            Console.ReadKey();
        }

        public static void exercise4()
        {
            int N = int.Parse(Console.ReadLine());
            int[,] Mat = new int[N, N];

            for(int i = 0; i < N; i++)
            {
                string[] s = Console.ReadLine().Split();
                for(int j = 0; j < N; j++)
                {
                    Mat[i, j] = int.Parse(s[j]);
                }
            }

            int sum = 0;

            for(int i = 0; i < N; i++)
            {
                for(int j = 0; j < N; j++)
                {
                    if(j > i)
                    {
                        sum += Mat[i, j];
                    }
                }
            }

            Console.Write(sum);

            Console.ReadKey();

        }

        public static void exercise5()
        {
            int M, N;
            string[] s = Console.ReadLine().Split(' ');
            M = int.Parse(s[0]);
            N = int.Parse(s[1]);

            int[,] A = new int[M, N];
            int[,] B = new int[M, N];
            int[,] C = new int[M, N];

            for(int i = 0; i < M; i++)
            {
                string[] SA = Console.ReadLine().Split(' ');
                for(int j = 0; j < N; j++)
                {
                    A[i, j] = int.Parse(SA[j]);
                }
            }

            for(int i = 0; i < M; i++)
            {
                string[] SB = Console.ReadLine().Split(' ');
                for(int j = 0; j < N; j++)
                {
                    B[i, j] = int.Parse(SB[j]);
                }
            }

            for(int i = 0; i < M; i++)
            {
                for(int j = 0; j < N; j++)
                {
                    C[i, j] = A[i, j] + B[i, j];
                }
            }

            for(int i = 0; i < M; i++)
            {
                for(int j = 0; j < N; j++)
                {
                    Console.Write(C[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }

        public static void exercise6()
        {
            int N = int.Parse(Console.ReadLine());
            double[,] Mat = new double[N, N];

            for(int i = 0; i < N; i++)
            {
                string[] v = Console.ReadLine().Split(' ');
                for(int j = 0; j < N; j++)
                {
                    Mat[i, j] = double.Parse(v[j], CultureInfo.InvariantCulture);
                }
            }

            double positiveSum = 0;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (Mat[i, j] > 0)
                    {
                        positiveSum += Mat[i, j];
                    }
                }
            }
            Console.WriteLine("SUM OF POSITIVES : " + positiveSum.ToString("F1", CultureInfo.InvariantCulture));

            int chosenline = int.Parse(Console.ReadLine());
            Console.Write("CHOSEN LINE : ");           
            for (int j = 0; j < N; j++)
            {
                Console.Write(Mat[chosenline, j].ToString("F1", CultureInfo.InvariantCulture) + " ");
            }

            Console.WriteLine();

            int chosenColumn = int.Parse(Console.ReadLine());
            Console.Write("CHOSEN COLUMN : ");
            for(int i = 0; i < N; i++)
            {
                Console.Write(Mat[i, chosenColumn].ToString("F1", CultureInfo.InvariantCulture) + " ");
            }

            Console.WriteLine();

            Console.Write("LEADING DIAGONAL : ");
            for(int i = 0; i < N; i++)
            {
                    Console.Write(Mat[i, i].ToString(CultureInfo.InvariantCulture) + " ");
            }

            Console.WriteLine();

            for(int i=0; i < N; i++)
            {
                for(int j=0; j < N; j++)
                {
                    if(Mat[i,j] < 0.0)
                    {
                        Mat[i,j] = Math.Pow(Mat[i, j], 2);
                    }
                }
            }

            Console.WriteLine("CHANGED MATRIX:");
            for(int i=0; i < N; i++)
            {
                for(int j=0; j < N; j++)
                {
                    Console.Write(Mat[i, j].ToString("F1", CultureInfo.InvariantCulture) + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        public static void exercise7()
        {
            int M = int.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());

            int[,] platoon = new int[M, N];

            for(int i=0; i < M; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                for(int j=0; j < N; j++)
                {
                    platoon[i, j] = int.Parse(s[j]);
                }
            }

            int row = int.Parse(Console.ReadLine());
            row = row - 1;

            int lastInLine = platoon[row, N - 1];

            for(int j = N-1; j > 0; j--)
            {
                platoon[row, j] = platoon[row, j - 1];
            }

            platoon[row, 0] = lastInLine;

            for(int i = 0; i < M; i++)
            {
                for(int j = 0; j < N; j++)
                {
                    Console.Write(platoon[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
