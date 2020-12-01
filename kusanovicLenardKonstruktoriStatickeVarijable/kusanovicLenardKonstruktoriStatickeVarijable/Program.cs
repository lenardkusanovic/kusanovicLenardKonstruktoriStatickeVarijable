using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kusanovicLenardKonstruktoriStatickeVarijable
{
    class Program
    {
        static void Main(string[] args)
        {
            PrvaKlasa x = new PrvaKlasa();
            Console.WriteLine(x.ToString());

            PrvaKlasa y = new PrvaKlasa();
            Console.WriteLine(y.ToString());

            PrvaKlasa z = new PrvaKlasa();
            Console.WriteLine(z.ToString());

            Console.ReadKey();
        }
    }
}
