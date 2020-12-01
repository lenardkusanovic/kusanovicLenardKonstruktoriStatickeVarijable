using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kusanovicLenardKonstruktoriStatickeVarijable_B_
{
    class Program
    {
        static void Main(string[] args)
        {
            PrvaKlasa x = new PrvaKlasa("cvek", "kcve");
            Console.WriteLine(x.ToString());

            PrvaKlasa y = new PrvaKlasa("tomc", "matija");
            Console.WriteLine(y.ToString());

            PrvaKlasa z = new PrvaKlasa("kostro", "genije");
            Console.WriteLine(z.ToString());

            Console.ReadKey();
        }
    }
}
