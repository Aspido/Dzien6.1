using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02PolaczenieZBaza
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PolaczenieZBaza pzb = new PolaczenieZBaza();
            object[][] wynik = pzb.WyslijPolecenieSQL("select * from zawodnicy");

            foreach (var w in wynik)
            {
                // Console.WriteLine(w[0] + " " + w[1] + "..");
                Console.WriteLine(String.Join(" ", w));
            }
            Console.ReadKey();
        }
    }
}
