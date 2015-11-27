using System;

namespace Vsite.CSharp
{
    class MojaKlasa
    {
    }

    struct MojaStruktura
    {
    }

    class Program
    {
        static void Main(string[] args)
        {
            MojaKlasa mk1 = new MojaKlasa();
            MojaKlasa mk2 = null;

            //  Usporediti objekte mk1 i mk2 korištenjem statičke metode MojaKlasa.Equals te ispisati rezultat
            Console.WriteLine(mk1.Equals(mk2));
            Console.WriteLine(MojaKlasa.Equals(mk1,mk2));
    

            //  Usporediti objekte mk1 i mk2 pozivom metode mk1.Equals te ispisati rezultat
            Console.WriteLine(mk1.Equals(mk2));

            //  Usporediti objekte mk1 i mk2 pozivom metode mk2.Equals te ispisati rezultat
               //Console.WriteLine(mk2.Equals(mk1)); ne može se izvršit
            //  Storiti dvije strukture ms1 i ms2 na isti način kao i za gornje instance klasa mk1 i mk2
            MojaStruktura ms1 = new MojaStruktura();
            MojaStruktura ms2 = ms1;

            //  Usporediti objekte ms1 i ms2 korištenjem statičke metode MojaStruktura.Equals te ispisati rezultat
            Console.WriteLine(MojaStruktura.Equals(ms1, ms2));

            // TODO: Usporediti objekte ms1 i ms2 pozivom metode ms1.Equals te ispisati rezultat
            Console.WriteLine(ms2.Equals( ms1));

            // TODO: Usporediti objekte ms1 i ms2 pozivom metode ms2.Equals te ispisati rezultat
            Console.WriteLine(ms1.Equals(ms2));

            // TODO: Ispis prekopirati u datoteku Equals.txt pridruženu ovom projektu te obrazložite svaki rezultat

            Console.ReadKey();
        }
    }
}
