using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LottozoRendszer
{
    class FajlKezelo
    {
        string nyeroSzamok;
        string valasztottSzamok;

        public FajlKezelo(int[] nyeroSzamok, int[] valasztottSzamok)
        {
            NyeroSzamok = HozzaAd(nyeroSzamok);
            ValasztottSzamok = HozzaAd(valasztottSzamok);
        }


        public string NyeroSzamok { get => nyeroSzamok; set => nyeroSzamok = value; }
        public string ValasztottSzamok { get => valasztottSzamok; set => valasztottSzamok = value; }

        static string HozzaAd(int[] szamok)
        {
            string sz = string.Empty;
            for (int i = 0; i < szamok.Length; i++)
            {
                sz += szamok[i] + " ";
            }
            return sz;
        }

        public void FajlbaIras()
        {
            StreamWriter sw;
            string fajlNev = "eredmeny.csv";

            if (File.Exists(fajlNev))
            {
                sw = new StreamWriter(fajlNev, true, Encoding.Default);
                sw.WriteLine($"{nyeroSzamok};{valasztottSzamok}");
            }
            else
            {
                sw = new StreamWriter(fajlNev, false, Encoding.Default);
                sw.WriteLine("Nyerő számok;Választott számok");
                sw.WriteLine($"{nyeroSzamok};{valasztottSzamok}");
            }
            sw.Close();
        }
    }
}
