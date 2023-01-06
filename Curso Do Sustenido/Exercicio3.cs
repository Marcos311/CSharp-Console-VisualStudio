using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Curso_Do_Sustenido
{
    class Exercicio3
    {
        public static void exercicio3(){

            int N;
            N = int.Parse(Console.ReadLine());

            string[] vetNome = new string[N];
            int[] vetIdade = new int[N];
            double[] vetAltura = new double[N];

            //reading data
            for(int i=0; i < N; i++)
            {
                string[] s = Console.ReadLine().Split();
                
                
                vetNome[i] = s[0];
                vetIdade[i] = int.Parse(s[1]);
                vetAltura[i] = double.Parse(s[2], CultureInfo.InvariantCulture);
            }

            //calculating the average high of people
            double soma = 0.0;
            for(int i=0; i < N; i++)
            {
                soma = soma + vetAltura[i];
            }
            double media = soma / N;
            Console.WriteLine("Altura média: " + media.ToString("F2", CultureInfo.InvariantCulture));

            // percetage of people under the age of sixteen
            int cont = 0;
            for(int i=0; i < N; i++)
            {
                if(vetIdade[i] < 16)
                {
                    cont = cont++;
                }
            }
            double percetage = (double) cont / N * 100.0;
            Console.WriteLine("People under the age of sixteen: " + percetage.ToString("F2", CultureInfo.InvariantCulture) + "%");

            Console.ReadKey();
        }

    }
}
