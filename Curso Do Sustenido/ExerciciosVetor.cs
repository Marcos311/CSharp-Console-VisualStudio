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

        public static void exercise6()
        {
            int N = int.Parse(Console.ReadLine());

            string[] name = new string[N];
            int[] age = new int[N];

            for(int i=0; i < N; i++)
            {
                string[] s = Console.ReadLine().Split(' ');

                name[i] = s[0];
                age[i] = int.Parse(s[1]);
            }

            string answerName = name[0];
            int answerAge = 0;

            for(int i=0; i < N; i++)
            {
                if(age[i] > answerAge)
                {
                    answerAge = age[i];
                    answerName = name[i];
                }
            }

            Console.WriteLine("Older Person : " + answerName);

            Console.ReadKey();
        }

        public static void exercise7()
        {
            int N = int.Parse(Console.ReadLine());

            String[] name = new string[N];
            double[] gradeFirstSemester = new double[N];
            double[] gradeSecondSemester = new double[N];

            for(int i=0; i < N; i++)
            {
                string[] s = Console.ReadLine().Split(' ');

                name[i] = s[0];
                gradeFirstSemester[i] = double.Parse(s[1], CultureInfo.InvariantCulture);
                gradeSecondSemester[i] = double.Parse(s[2], CultureInfo.InvariantCulture);
            }

            Console.WriteLine("Approved Students :");

            for(int i=0; i<N; i++)
            {
                double media = (gradeFirstSemester[i] + gradeSecondSemester[i]) / 2.0;

                if(media >= 6.0)
                {
                    Console.WriteLine(name[i]);
                }
            }

            Console.ReadKey();
        }

        public static void exercise8()
        {
            int N = int.Parse(Console.ReadLine());

            double[] height = new double[N];
            char[] sex = new char[N];

            for(int i=0; i<N; i++)
            {
                string[] s = Console.ReadLine().Split(' ');

                height[i] = double.Parse(s[0], CultureInfo.InvariantCulture);
                sex[i] = char.Parse(s[1]);
            }

            double shorterHeight = height[0];

            for(int i=0; i<N; i++)
            {
                if(height[i] < shorterHeight)
                {
                    shorterHeight = height[i];
                }
            }

            double greaterHeight = 0.0;

            for(int i=0; i<N; i++)
            {
                if(height[i] > greaterHeight)
                {
                    greaterHeight = height[i];
                }
            }

            int countF = 0;
            double sumHeighterWomens = 0.0;

            for(int i = 0; i<N; i++)
            {
                if(sex[i] == 'F')
                {
                    sumHeighterWomens = sumHeighterWomens + height[i];
                    countF++;
                }
            }


            double average = sumHeighterWomens / countF;

            double countM = 0.0;

            for(int i=0; i<N; i++)
            {
                if(sex[i] == 'M')
                {
                    countM++;
                }
            }

            Console.WriteLine("Shorter Height : " + shorterHeight.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("Greater Height : " + greaterHeight.ToString("F2", CultureInfo.InvariantCulture));

            if(countF == 0){
                Console.WriteLine("There is no woman among the people");
            }
            else
            {
                Console.WriteLine("Average Height of women : " + average.ToString("F2", CultureInfo.InvariantCulture));
            }

            Console.WriteLine("Number of men : " + countM);

            Console.ReadKey();
        }
    }
}
