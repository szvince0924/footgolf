using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace footgolf
{
    internal class Versenyzok
    {
        public string Nev { get; set; }

        public string Kategoria { get; set; }
        public string Egyesulet { get; set; }
        public int Fordulok { get; set; }


        public Versenyzok(string sor)
        {
            string[] s = sor.Split(';');

            Nev = s[0];
            Kategoria = s[1];
            Egyesulet = s[2];
            Fordulok = int.Parse(s[3]);

        }





    }

 
}
