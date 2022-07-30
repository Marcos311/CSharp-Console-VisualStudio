using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_Do_Sustenido
{
    class AULA09
    {
        public static void bitwise()
        {
            int num = 2;
            int num2 = 20;

            num = num << 2;
            num2 = num2 >> 2;

            Console.WriteLine(num);
            Console.WriteLine(num2);

            Console.ReadKey();
        }
    }
}
