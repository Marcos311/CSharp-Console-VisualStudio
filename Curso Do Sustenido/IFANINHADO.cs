﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_Do_Sustenido
{
    class IFANINHADO
    {
        public static void IfAninhado()
        {
            int n1, n2, n3, n4, res;
            res = n1 = n2 = n3 = n4 = 0;
            string resultado;

            Console.WriteLine("Digite a nota 1: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nota 2: ");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nota 3: ");
            n3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nota 4: ");
            n4 = int.Parse(Console.ReadLine());

            res = n1 + n2 + n3 + n4;

            //>=60 Aprovado
            //50 e 40 - Recuperação
            //<40 - Reprovado

            //65

            if (res >= 60)
            {
                if (res >= 90)
                {
                    if (res >= 99)
                    {
                        resultado = "Aprovado com super louvor";

                    }
                    else
                    {
                        resultado = "Aprovado com louvor";
                    }
                }
                else
                {
                    resultado = "Aprovado";
                }
               
            }
            else
            {
                if (res >= 40)
                {
                    resultado = "Recuperação";
                }
                else
                {
                    resultado = "Reprovado";
                }
            }
        
            Console.WriteLine("Nota: {0} - Resultado: {1}", res, resultado);

            Console.ReadKey();
        }
    }
}
