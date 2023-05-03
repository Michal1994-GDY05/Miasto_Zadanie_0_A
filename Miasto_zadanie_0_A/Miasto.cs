using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miasto_Zadanie_0_A
{
    public class Miasto
    {
        public string Nazwa { get; set; }
        public uint Populacja { get; set; }
        public double Powierzchnia

        {
            get { return powierzchnia; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Powierzchnia musi być większa od 0.");
                }
                powierzchnia = value;
            }
        }

        private double powierzchnia;
        public double GestoscZaludnienia
        {
            get { return Math.Round(Populacja / Powierzchnia, 2); }
        }

        public Miasto(string nazwa, uint populacja, double powierzchnia)
        {
            Nazwa = nazwa;
            Populacja = populacja;
            Powierzchnia = powierzchnia;
        }
    }
}