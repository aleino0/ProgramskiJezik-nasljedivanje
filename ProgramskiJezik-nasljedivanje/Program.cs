using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramskiJezik_nasljedivanje
{
    class ProgramskiJezik
    {
        double postotak;
        public double Postotak { get => postotak; set => postotak = value; }

    }
    class Proceduralni : ProgramskiJezik { }
    class Objektni : ProgramskiJezik { }
    class Funkcionalni : ProgramskiJezik { }

    internal class Program
    {
        static void Main()
        {
            double zbroj;
            Proceduralni x = new Proceduralni();
            Objektni y = new Objektni();
            Funkcionalni z = new Funkcionalni();

            unos: Console.WriteLine("Unesi vrijednost postotka za proceduralni jezik: ");
            x.Postotak = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Unesi vrijednost postotka za objektivni jezik: ");
            y.Postotak = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Unesi vrijednost postotka za funkcionalni jezik: ");
            z.Postotak = Convert.ToInt32(Console.ReadLine());

            zbroj = x.Postotak + y.Postotak + z.Postotak;

            if (zbroj != 100)
            {
                Console.WriteLine("Neispravan unos podataka, ukupna vrijednost postotka mora biti 100% \r\n");
                goto unos;
            }
            else if (zbroj == 100)
            {
                if (x.Postotak > y.Postotak && x.Postotak > z.Postotak)
                {
                    Console.WriteLine("Najveci postotak ima procedurarlno sa: " + x.Postotak + "%");
                }
                if (y.Postotak > x.Postotak && y.Postotak > z.Postotak)
                {
                    Console.WriteLine("Najveci postotak ima Objektno sa: " + y.Postotak + "%");
                }
                if (z.Postotak > y.Postotak && z.Postotak > x.Postotak)
                {
                    Console.WriteLine("Najveci postotak ima Funkcionalno sa: " + z.Postotak + "%");
                }
            }


            Console.ReadKey();
        }

    }

}