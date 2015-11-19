﻿using System;

namespace Vsite.CSharp
{
    class MojaKlasa
    {
    }

    class Program
    {
        static void Main(string[] args)
        {
            MojaKlasa mk1 = new MojaKlasa();
            MojaKlasa mk2 = mk1;
            MojaKlasa mk3 = new MojaKlasa();

            // metoda ToString
            // za svaki objekt pozvati njegovu metodu ToString i ispisati na konzolu ono što ona vraća
            Console.WriteLine(mk1.ToString());
            Console.WriteLine(mk2.ToString());
            Console.WriteLine(mk3.ToString());

            // metoda GetType
            //  za svaki objekt pozvati njegovu metodu GetType i ispisati na konzolu ono što ona vraća
            Console.WriteLine(mk1.GetType());
            Console.WriteLine(mk2.GetType());
            Console.WriteLine(mk3.GetType());
            var t = mk1.GetType();
            // metoda GetHashCode
            //  za svaki objekt pozvati njegovu metodu GetHashCode i ispisati na konzolu ono što ona vraća
            Console.WriteLine(mk1.GetHashCode());
            Console.WriteLine(mk2.GetHashCode());
            Console.WriteLine(mk3.GetHashCode());

            // metoda Equals
            //  za svaki objekt pozvati njegovu metodu Equals i usporedbu napraviti sa svim ostalim objektima te ispisati na konzolu ono što ona vraća
            Console.WriteLine(mk1.Equals(mk2));
            Console.WriteLine(mk1.Equals(mk3));
            Console.WriteLine(mk2.Equals(mk3));
            Console.WriteLine(mk2.Equals(mk1));
            Console.WriteLine(mk3.Equals(mk1));
            Console.WriteLine(mk3.Equals(mk2));
            
            //  ispise pohraniti u datoteku SystemObjects.txt priloženu projektu te u njoj obrazložiti rezultate za svaku metodu!


            Console.ReadKey();
        }
    }
}
