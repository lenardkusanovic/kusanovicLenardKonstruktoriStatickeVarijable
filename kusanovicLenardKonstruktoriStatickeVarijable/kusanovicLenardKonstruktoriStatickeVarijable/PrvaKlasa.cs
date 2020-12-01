using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kusanovicLenardKonstruktoriStatickeVarijable
{
    class PrvaKlasa
    {
        private static int counter;

        public PrvaKlasa()
        {
            counter++;
        }

        public static int Counter { get => counter; }

        public override string ToString()
        {
            string ispis = "Redni broj: " + counter;
            return ispis;
        }
    }
}
