using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03TypObject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            object a = 1; //na te jedynke patrze z perspektywy obiektu
            object b = (object)"ala ma kota";
            object c = new StringBuilder(); // to tez jest rzutowanie (niejawne)

            int d = 1; // na te jedynke patrze z perspektywy liczby 

            StringBuilder e = new StringBuilder();

            StringBuilder f = (StringBuilder)c; // rzutowanie (jawne)

            StringBuilder g = c as StringBuilder;

            // rzutowanie to nie konwersja 

            int h = 1;
            string i = Convert.ToString(h);

            // string j = (string)h;

            string[] napisy = { "ala", "ma ", "kota" };
            int[] liczby = { 2, 5, 6, 4 };

            object[] obiekty = { "ala", 3, true };

            string s1 = (string)obiekty[0];
            int s2 = (int)obiekty[1];
            bool s3 = (bool)obiekty[2];
        }
    }
}
