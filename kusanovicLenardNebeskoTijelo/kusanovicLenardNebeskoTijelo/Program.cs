using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kusanovicLenardNebeskoTijelo
{
    class Program
    {
        static void Main(string[] args)
        {
            Planet Zemlja = new Planet(2, 2);
            Satelit Mjesec = new Satelit(4, 2);

            Console.WriteLine("\nBrzina oko osi: " + Zemlja.BrzinaOkoOsi + "\nBrzina oko Sunca: " + Zemlja.BrzinaOkoSunca);
            Console.WriteLine("\nBrzina oko osi: " + Mjesec.BrzinaOkoOsi + "\nBrzina oko Sunca: " + Mjesec.BrzinaOkoSunca);

            Console.ReadKey();
        }
    }
}
