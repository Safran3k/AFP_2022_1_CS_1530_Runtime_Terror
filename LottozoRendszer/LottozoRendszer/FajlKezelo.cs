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

        public FajlKezelo()
        {
            NyeroSzamok = nyeroSzamok;
            ValasztottSzamok = valasztottSzamok;
        }


        public string NyeroSzamok { get => nyeroSzamok; set => nyeroSzamok = value; }
        public string ValasztottSzamok { get => valasztottSzamok; set => valasztottSzamok = value; }
    }
}
