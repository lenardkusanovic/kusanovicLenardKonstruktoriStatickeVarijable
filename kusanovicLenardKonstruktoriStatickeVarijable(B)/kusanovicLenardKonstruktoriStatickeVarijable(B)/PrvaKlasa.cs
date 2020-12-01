using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kusanovicLenardKonstruktoriStatickeVarijable_B_
{
    class PrvaKlasa
    {
        private static int counter;
        string ime;
        string prezime;

        public PrvaKlasa()
        {
            Counter++;
        }

        public PrvaKlasa(string ime , string prezime)
        {
            Counter++;
            this.Ime = ime;
            this.Prezime = prezime;

        }

        public static int Counter { get => counter; set => counter = value; }
        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }

        public override string ToString()
        {
            string ispis = "Redni broj: " + counter + ", " + ime " " + prezime;
            return ispis;
        }
    }
}
