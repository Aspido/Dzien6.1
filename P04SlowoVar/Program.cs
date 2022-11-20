using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04SlowoVar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            var b = 1; //var to slowo ktore zastepuje nam typ


            StringBuilder sb = new StringBuilder();
            var sb2 = new StringBuilder();

            List<List<StringBuilder>> sb3 = new List<List<StringBuilder>>();
            var sb4 = new List<List<StringBuilder>>();


            // ciekawostka 
            dynamic c = 4;
            c = "ala ma kota";
            // na tym etpie to jest niewlasciwa forma pracy 
        }
    }
}
