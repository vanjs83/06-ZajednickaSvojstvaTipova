﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GetHashCode
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
            //  Prekopirati implementaciju metode Equals iz EqualsRefTip1
            if (obj == null) 
                return false;
            if (this.GetType() != obj.GetType()) 
                return false;
            Osoba drugi = (Osoba)obj;
            if (Osoba.Equals(this.m_ime, drugi.m_ime) == false)
                return false;
            return m_matičniBroj.Equals(drugi.m_matičniBroj);
               
          
        }

        // TODO: Implementirati metodu GetHashCode tako da se metoda Main može izvesti bez problema

        
        
        public override string ToString()
        {
            return string.Format("'{0}, {1}'", m_ime, m_matičniBroj);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<Osoba, string> mjestaRođenja = new Dictionary<Osoba, string>();
            mjestaRođenja[new Osoba("Pero", 1)] = "Babina Greda";
            mjestaRođenja[new Osoba("Janko", 2)] = "Jarče Polje";
            mjestaRođenja[new Osoba("Darko", 3)] = "Vukova Gorica";

            Console.WriteLine(mjestaRođenja[new Osoba("Pero", 1)]);
            Console.WriteLine(mjestaRođenja[new Osoba("Janko", 2)]);
            Console.WriteLine(mjestaRođenja[new Osoba("Darko", 3)]);

            Console.ReadKey();

        }
    }
}
