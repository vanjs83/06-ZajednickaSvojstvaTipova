﻿using System;
using System.Diagnostics;

namespace Vsite.CSharp
{
    class Osoba
    {
        public Osoba(string ime, int matičniBroj)
        {
            m_ime = ime;
            m_matičniBroj = matičniBroj;
        }

        string m_ime;       // član referentnog tipa
        int m_matičniBroj;  // član vrijednosnog tipa

        public override bool Equals(object obj) 
        {
            //  Preslikati implementaciju metode iz EqualsRefTip1
            Osoba drugi = (Osoba)obj;
            if (Osoba.Equals(this.m_ime, drugi.m_ime) == false)
                return false;
            return m_matičniBroj.Equals(drugi.m_matičniBroj);


            if (obj == null || obj is Osoba)
                return false;

            if (this.GetType() != obj.GetType())
                return false;
          



            //return true;
        }

        //  TODO: implementirati operatore == i != tako da se metoda Main izvede bez problema
        public static bool operator ==(Osoba rt1, Osoba rt2)
        {
            return false;
        }

        // POGREŠNA IMPLEMENTACIJA (beskonačna rekurzija)
        
        /*public static bool operator ==(Osoba rt1, Osoba rt2)
        {
            if (rt1 == rt2) 
                return true; 
            if (rt1 == null || rt2 == null) 
                return false;
            // ...
            return true;
        }
        
        */
        public override string ToString()
        {
            return string.Format("'{0}, {1}'", m_ime, m_matičniBroj);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            // dvije osobe s različitim imenima i MB
            Osoba osobaA = new Osoba("Janko", 1);
            Osoba osobaB = new Osoba("Darko", 2);
            Debug.Assert((osobaA == osobaB) == false);
            Debug.Assert(osobaA != osobaB);

            // novi "Janko" s drugim matičnim brojem
            osobaB = new Osoba("Janko", 2);
            Debug.Assert((osobaA == osobaB) == false);
            Debug.Assert(osobaA != osobaB);

            // novi "Janko" s istim matičnim brojem
            osobaB = new Osoba("Janko", 1);
            Debug.Assert(osobaA == osobaB);
            Debug.Assert((osobaA != osobaB) == false);

            osobaB = osobaA;
            Debug.Assert(osobaA == osobaB);
            Debug.Assert((osobaA != osobaB) == false);

            osobaB = null;
            Debug.Assert((osobaA == osobaB) == false);
            Debug.Assert(osobaA != osobaB);

            osobaA = null;
            Debug.Assert(osobaA == osobaB);
            Debug.Assert((osobaA != osobaB) == false);


            Console.ReadLine();
        }
    }
}
