using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_Do_Sustenido
{
    class AULA10
    {
        enum DiasSemana { Domingo, Segunda, Terça, Quarta, Quinta, Sexta, Sábado };

        public static void Enum()
        {
            int ds = (int)DiasSemana.Sábado;
          

            Console.WriteLine(ds);

            Console.ReadKey();
        }
    }
}
