using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Berek
    {
        public string nev { get; set; }
        public string neme { get; set; }
        public string reszleg { get; set; }
        public int belepes { get; set; }
        public int ber { get; set; }

        public Berek(string sor)
        {
            string[] dbok = sor.Split(";");
            nev = dbok[0];
            neme = dbok[1];
            reszleg = dbok[2];
            belepes = int.Parse(dbok[3]);
            ber = int.Parse(dbok[4]);
        }
    }
}
